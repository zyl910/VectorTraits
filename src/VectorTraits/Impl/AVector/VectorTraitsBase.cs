using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector {

    /// <summary>
    /// <see cref="Vector{T}"/> traits - Variable base.
    /// </summary>
    public sealed partial class VectorTraitsBase : VectorTraitsAbstract {
        private static readonly VectorTraitsBase _instance = new VectorTraitsBase(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraitsBase Instance {
            get { return _instance; }
        }

        /// <summary>
        /// <see cref="Vector{T}"/> traits.Statics - Variable base.
        /// </summary>
        public static partial class Statics {

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


            /// <inheritdoc cref="IVectorTraits.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR
#endif // BCL_OVERRIDE_BASE_VAR
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> ConvertToDouble(Vector<long> value) {
                return Vector.ConvertToDouble(value);
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> ConvertToDouble(Vector<ulong> value) {
                return Vector.ConvertToDouble(value);
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToInt32(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ConvertToInt32(Vector<float> value) {
                return Vector.ConvertToInt32(value);
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToInt64(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ConvertToInt64(Vector<double> value) {
                return Vector.ConvertToInt64(value);
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToSingle_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Int32;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToSingle(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> ConvertToSingle(Vector<int> value) {
                return Vector.ConvertToSingle(value);
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToSingle(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> ConvertToSingle(Vector<uint> value) {
                return Vector.ConvertToSingle(value);
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToUInt32(Vector{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ConvertToUInt32(Vector<float> value) {
                return Vector.ConvertToUInt32(value);
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToUInt64(Vector{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ConvertToUInt64(Vector<double> value) {
                return Vector.ConvertToUInt64(value);
            }


            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<float> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<double> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<sbyte> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<byte> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<short> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<ushort> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<int> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<uint> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<long> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<ulong> vector) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<float> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt32());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<double> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt64());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<sbyte> vector) {
                return Statics.ExtractMostSignificantBits_Base(vector.AsByte());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<byte> vector) {
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref vector);
                ulong rt = BitMath.GetMostSignificantBit(p);
                for (int i = 1; i < Vector<byte>.Count; ++i) {
                    rt |= ((ulong)BitMath.GetMostSignificantBit(Unsafe.Add(ref p, i))) << i;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<short> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt16());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<ushort> vector) {
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p);
                for (int i = 1; i < Vector<ushort>.Count; ++i) {
                    rt |= BitMath.GetMostSignificantBit(Unsafe.Add(ref p, i)) << i;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<int> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt32());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<uint> vector) {
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p);
                for (int i = 1; i < Vector<uint>.Count; ++i) {
                    rt |= BitMath.GetMostSignificantBit(Unsafe.Add(ref p, i)) << i;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<long> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt64());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Base(Vector<ulong> vector) {
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p);
                for (int i = 1; i < Vector<ulong>.Count; ++i) {
                    rt |= BitMath.GetMostSignificantBit(Unsafe.Add(ref p, i)) << i;
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


            /// <inheritdoc cref="IVectorTraits.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_VAR
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Narrow(Vector<double> lower, Vector<double> upper) {
#if BCL_OVERRIDE_BASE_VAR
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Narrow(Vector<short> lower, Vector<short> upper) {
#if BCL_OVERRIDE_BASE_VAR
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Narrow(Vector<ushort> lower, Vector<ushort> upper) {
#if BCL_OVERRIDE_BASE_VAR
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Narrow(Vector<int> lower, Vector<int> upper) {
#if BCL_OVERRIDE_BASE_VAR
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Narrow(Vector<uint> lower, Vector<uint> upper) {
#if BCL_OVERRIDE_BASE_VAR
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Narrow(Vector<long> lower, Vector<long> upper) {
#if BCL_OVERRIDE_BASE_VAR
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Narrow(Vector<ulong> lower, Vector<ulong> upper) {
#if BCL_OVERRIDE_BASE_VAR
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Narrow_Base(Vector<double> lower, Vector<double> upper) {
                nint cnt = Vector<double>.Count;
                UnsafeEx.SkipInit(out Vector<float> rt);
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                ref double plower = ref Unsafe.As<Vector<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector<double>, double>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref p, i) = (float)Unsafe.Add(ref plower, i);
                    Unsafe.Add(ref p, i + cnt) = (float)Unsafe.Add(ref pupper, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Narrow_Base(Vector<short> lower, Vector<short> upper) {
                nint cnt = Vector<short>.Count;
                UnsafeEx.SkipInit(out Vector<sbyte> rt);
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                ref short plower = ref Unsafe.As<Vector<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector<short>, short>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref p, i) = (sbyte)Unsafe.Add(ref plower, i);
                    Unsafe.Add(ref p, i + cnt) = (sbyte)Unsafe.Add(ref pupper, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Narrow_Base(Vector<ushort> lower, Vector<ushort> upper) {
                nint cnt = Vector<ushort>.Count;
                UnsafeEx.SkipInit(out Vector<byte> rt);
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                ref ushort plower = ref Unsafe.As<Vector<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector<ushort>, ushort>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref p, i) = (byte)Unsafe.Add(ref plower, i);
                    Unsafe.Add(ref p, i + cnt) = (byte)Unsafe.Add(ref pupper, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Narrow_Base(Vector<int> lower, Vector<int> upper) {
                nint cnt = Vector<int>.Count;
                UnsafeEx.SkipInit(out Vector<short> rt);
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                ref int plower = ref Unsafe.As<Vector<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector<int>, int>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref p, i) = (short)Unsafe.Add(ref plower, i);
                    Unsafe.Add(ref p, i + cnt) = (short)Unsafe.Add(ref pupper, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Narrow_Base(Vector<uint> lower, Vector<uint> upper) {
                nint cnt = Vector<uint>.Count;
                UnsafeEx.SkipInit(out Vector<ushort> rt);
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref rt);
                ref uint plower = ref Unsafe.As<Vector<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector<uint>, uint>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref p, i) = (ushort)Unsafe.Add(ref plower, i);
                    Unsafe.Add(ref p, i + cnt) = (ushort)Unsafe.Add(ref pupper, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Narrow_Base(Vector<long> lower, Vector<long> upper) {
                nint cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out Vector<int> rt);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref p, i) = (int)Unsafe.Add(ref plower, i);
                    Unsafe.Add(ref p, i + cnt) = (int)Unsafe.Add(ref pupper, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Narrow_Base(Vector<ulong> lower, Vector<ulong> upper) {
                nint cnt = Vector<ulong>.Count;
                UnsafeEx.SkipInit(out Vector<uint> rt);
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref rt);
                ref ulong plower = ref Unsafe.As<Vector<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector<ulong>, ulong>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref p, i) = (uint)Unsafe.Add(ref plower, i);
                    Unsafe.Add(ref p, i + cnt) = (uint)Unsafe.Add(ref pupper, i);
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
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Base(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Base(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Base(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Base(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Base(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Base(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Base(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Base(Vector<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Multiply(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Multiply(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Multiply(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Multiply(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Multiply(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Multiply(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
            }

            // No hardware acceleration!
            ///// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            //[EditorBrowsable(EditorBrowsableState.Never)]
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector<long> ShiftLeft_Multiply(Vector<long> value, int shiftAmount) {
            //    shiftAmount &= 0x3F;
            //    return ShiftLeft_Fast_Multiply(value, shiftAmount);
            //}

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
                var a0 = ShiftLeft_Args(dummy.AsByte(), shiftAmount, out var a1);
                args1 = a1.AsSByte();
                return a0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{byte}, int, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                _ = dummy;
                shiftAmount &= 7;
                var args0 = new Vector<ushort>((ushort)(1 << shiftAmount)).AsByte();
                args1 = new Vector<byte>((byte)((1U << (8 - shiftAmount)) - 1));
                return args0;
#else
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{short}, int, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
                //return ShiftLeft_Args_Mov(dummy, shiftAmount, out args1);
                var a0 = ShiftLeft_Args(dummy.AsUInt16(), shiftAmount, out var a1);
                args1 = a1.AsInt16();
                return a0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{short}, int, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Args_Element(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
                _ = dummy;
                Vector<int> args0 = new Vector<int>(shiftAmount & 0x0F);
                args1 = default;
                return args0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{short}, int, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Args_Mov(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
                _ = dummy;
                Vector<short> args0 = default;
                Unsafe.As<Vector<short>, int>(ref args0) = shiftAmount & 0x0F;
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{ushort}, int, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                _ = dummy;
                shiftAmount &= 0x0F;
                var args0 = new Vector<ushort>((ushort)(1 << shiftAmount));
                args1 = default;
                return args0;
#else
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{int}, int, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
                var a0 = ShiftLeft_Args(dummy.AsUInt32(), shiftAmount, out var a1);
                args1 = a1.AsInt32();
                return a0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{uint}, int, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                _ = dummy;
                shiftAmount &= 0x1F;
                var args0 = new Vector<uint>((uint)(1 << shiftAmount));
                args1 = default;
                return args0;
#else
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{long}, int, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{ulong}, int, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                return ShiftLeft_Core(value.AsByte(), shiftAmount, args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                _ = shiftAmount;
                Vector<byte> t = Vector.BitwiseAnd(value, args1);
                return Vector.Multiply(t.AsInt16(), args0.AsInt16()).AsByte();
#else
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Core(Vector<short> value, Vector<short> args0, Vector<short> args1) {
                return ShiftLeft_Core_Mov(value, args0, args1);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Core_Element(Vector<short> value, Vector<short> args0, Vector<short> args1) {
                _ = args1;
                int shiftAmount = args0.AsInt32()[0];
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Core_Mov(Vector<short> value, Vector<short> args0, Vector<short> args1) {
                _ = args1;
                int shiftAmount = Unsafe.As<Vector<short>, int>(ref args0);
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                _ = args1;
                _ = shiftAmount;
                return Vector.Multiply(value, args0);
#else
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
                return ShiftLeft_Core(value.AsInt16(), shiftAmount, args0.AsInt16(), args1.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                _ = args1;
                _ = shiftAmount;
                return Vector.Multiply(value, args0);
#else
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
                return ShiftLeft_Core(value.AsInt32(), shiftAmount, args0.AsInt32(), args1.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
                _ = args0;
                _ = args1;
                return ShiftLeft_Const(value, shiftAmount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
                _ = args0;
                _ = args1;
                return ShiftLeft_Const(value, shiftAmount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
                _ = args0;
                _ = args1;
                return ShiftLeft_Const(value, shiftAmount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
                _ = args0;
                _ = args1;
                return ShiftLeft_Const(value, shiftAmount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
                _ = args0;
                _ = args1;
                return ShiftLeft_Const(value, shiftAmount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
#if SOFTWARE_OPTIMIZATION && !(BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER)
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
                _ = args0;
                _ = args1;
                return ShiftLeft_Const(value, shiftAmount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Const(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Const(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Fast(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Fast(Vector<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Fast(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Fast(Vector<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Fast(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Fast(Vector<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Fast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Fast(Vector<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Fast_Base(Vector<sbyte> value, int shiftAmount) {
                return ShiftLeft_Fast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Fast_Base(Vector<byte> value, int shiftAmount) {
                Vector<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                for (nint i = 0; i < Vector<byte>.Count; ++i) {
                    p <<= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Fast_Base(Vector<short> value, int shiftAmount) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                for (nint i = 0; i < Vector<short>.Count; ++i) {
                    p <<= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Fast_Base(Vector<ushort> value, int shiftAmount) {
                return ShiftLeft_Fast_Base(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Fast_Base(Vector<int> value, int shiftAmount) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                for (nint i = 0; i < Vector<int>.Count; ++i) {
                    p <<= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Fast_Base(Vector<uint> value, int shiftAmount) {
                return ShiftLeft_Fast_Base(value.AsInt32(), shiftAmount).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Fast_Base(Vector<long> value, int shiftAmount) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                for (nint i = 0; i < Vector<long>.Count; ++i) {
                    p <<= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Fast_Base(Vector<ulong> value, int shiftAmount) {
                return ShiftLeft_Fast_Base(value.AsInt64(), shiftAmount).AsUInt64();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Fast_Multiply(Vector<sbyte> value, int shiftAmount) {
                return ShiftLeft_Fast_Multiply(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Fast_Multiply(Vector<byte> value, int shiftAmount) {
                //Vector<byte> t = Vector.BitwiseAnd(value, Vectors<byte>.GetMaskBits(8 - shiftAmount));
                Vector<byte> t = Vector.BitwiseAnd(value, new Vector<byte>((byte)((1U << (8 - shiftAmount)) - 1)));
                short m = (short)(1 << shiftAmount);
                return Vector.AsVectorByte(Vector.Multiply(Vector.AsVectorInt16(t), m));
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Fast_Multiply(Vector<short> value, int shiftAmount) {
                short m = (short)(1 << shiftAmount);
                return Vector.Multiply(value, m);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Fast_Multiply(Vector<ushort> value, int shiftAmount) {
                return ShiftLeft_Fast_Multiply(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Fast_Multiply(Vector<int> value, int shiftAmount) {
                int m = 1 << shiftAmount;
                return Vector.Multiply(value, m);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Fast_Multiply(Vector<uint> value, int shiftAmount) {
                return ShiftLeft_Fast_Multiply(value.AsInt32(), shiftAmount).AsUInt32();
            }

            // No hardware acceleration!
            ///// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{long}, int)"/>
            //[EditorBrowsable(EditorBrowsableState.Never)]
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector<long> ShiftLeft_Fast_Multiply(Vector<long> value, int shiftAmount) {
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
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Int64; // ShiftRightArithmetic_Fast_Negative.
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
            public static Vector<sbyte> ShiftRightArithmetic_Base(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Base(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Base(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Base(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Negative(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Negative(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Negative(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Negative(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Fast(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Fast(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Fast(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Fast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION && NET7_0_OR_GREATER
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Fast_Base(Vector<sbyte> value, int shiftAmount) {
                Vector<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                for (nint i = 0; i < Vector<sbyte>.Count; ++i) {
                    p >>= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Fast_Base(Vector<short> value, int shiftAmount) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                for (nint i = 0; i < Vector<short>.Count; ++i) {
                    p >>= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Fast_Base(Vector<int> value, int shiftAmount) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                for (nint i = 0; i < Vector<int>.Count; ++i) {
                    p >>= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Fast_Base(Vector<long> value, int shiftAmount) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                for (nint i = 0; i < Vector<long>.Count; ++i) {
                    p >>= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Fast_Negative(Vector<sbyte> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<sbyte> shifted = Vector.ShiftRightLogical(value.AsUInt16(), shiftAmount).AsSByte();
#else
                Vector<sbyte> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsSByte();
#endif // NET7_0_OR_GREATER
                Vector<sbyte> mask = Vectors<sbyte>.GetMaskBits(8 - shiftAmount);
                Vector<sbyte> sign = Vector.GreaterThan(Vector<sbyte>.Zero, value);
                Vector<sbyte> rt = Vector.ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Fast_Negative(Vector<short> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<short> shifted = Vector.ShiftRightLogical(value, shiftAmount);
#else
                Vector<short> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsInt16();
#endif // NET7_0_OR_GREATER
                Vector<short> mask = Vectors<short>.GetMaskBits(16 - shiftAmount);
                Vector<short> sign = Vector.GreaterThan(Vector<short>.Zero, value);
                Vector<short> rt = Vector.ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Fast_Negative(Vector<int> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<int> shifted = Vector.ShiftRightLogical(value, shiftAmount);
#else
                Vector<int> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsInt32();
#endif // NET7_0_OR_GREATER
                Vector<int> mask = Vectors<int>.GetMaskBits(32 - shiftAmount);
                Vector<int> sign = Vector.GreaterThan(Vector<int>.Zero, value);
                Vector<int> rt = Vector.ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Fast_Negative(Vector<long> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<long> shifted = Vector.ShiftRightLogical(value, shiftAmount);
#else
                Vector<long> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsInt64();
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
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte; // ShiftRightLogical_Fast_Widen
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
            public static Vector<sbyte> ShiftRightLogical_Base(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Base(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Base(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Base(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Base(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Base(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Base(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Base(Vector<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Widen(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Widen(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Widen(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Widen(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Widen(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Widen(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{byte}, int, out Vector{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{short}, int, out Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{ushort}, int, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{int}, int, out Vector{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{uint}, int, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{long}, int, out Vector{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{ulong}, int, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Fast(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Fast(Vector<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Fast(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Fast(Vector<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Fast(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Fast(Vector<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Fast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Fast(Vector<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftRightLogical_Fast_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Fast_Base(Vector<sbyte> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Fast_Base(Vector<byte> value, int shiftAmount) {
                Vector<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                for (nint i = 0; i < Vector<byte>.Count; ++i) {
                    p >>= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Fast_Base(Vector<short> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Base(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Fast_Base(Vector<ushort> value, int shiftAmount) {
                Vector<ushort> rt = value;
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref rt);
                for (nint i = 0; i < Vector<ushort>.Count; ++i) {
                    p >>= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Fast_Base(Vector<int> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Base(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Fast_Base(Vector<uint> value, int shiftAmount) {
                Vector<uint> rt = value;
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref rt);
                for (nint i = 0; i < Vector<uint>.Count; ++i) {
                    p >>= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Fast_Base(Vector<long> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Base(value.AsUInt64(), shiftAmount).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Fast_Base(Vector<ulong> value, int shiftAmount) {
                Vector<ulong> rt = value;
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref rt);
                for (nint i = 0; i < Vector<ulong>.Count; ++i) {
                    p >>= shiftAmount;
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Fast_Widen(Vector<sbyte> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Widen(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Fast_Widen(Vector<byte> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<byte> t = Vector.ShiftRightLogical(value.AsUInt64(), shiftAmount).AsByte();
#else
                Vector<byte> t = ShiftRightLogical_Fast_Base(value.AsUInt64(), shiftAmount).AsByte();
#endif
                Vector<byte> rt = Vector.BitwiseAnd(t, Vectors<byte>.GetMaskBits(8 - shiftAmount));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Fast_Widen(Vector<short> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Widen(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Fast_Widen(Vector<ushort> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<ushort> t = Vector.ShiftRightLogical(value.AsUInt64(), shiftAmount).AsUInt16();
#else
                Vector<ushort> t = ShiftRightLogical_Fast_Base(value.AsUInt64(), shiftAmount).AsUInt16();
#endif
                Vector<ushort> rt = Vector.BitwiseAnd(t, Vectors<ushort>.GetMaskBits(16 - shiftAmount));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Fast_Widen(Vector<int> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Widen(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Fast_Widen(Vector<uint> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<uint> t = Vector.ShiftRightLogical(value.AsUInt64(), shiftAmount).AsUInt32();
#else
                Vector<uint> t = ShiftRightLogical_Fast_Base(value.AsUInt64(), shiftAmount).AsUInt32();
#endif
                Vector<uint> rt = Vector.BitwiseAnd(t, Vectors<uint>.GetMaskBits(32 - shiftAmount));
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.None; // `.NET 7.0` doesn't have hardware acceleration yet .
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Shuffle(Vector<float> vector, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Shuffle(Vector<double> vector, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Shuffle(Vector<sbyte> vector, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Shuffle(Vector<byte> vector, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Shuffle(Vector<short> vector, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Shuffle(Vector<ushort> vector, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Shuffle(Vector<int> vector, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Shuffle(Vector<uint> vector, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Shuffle(Vector<long> vector, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Shuffle(Vector<ulong> vector, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Shuffle_Base(Vector<float> vector, Vector<int> indices) {
                return Shuffle_Base(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Shuffle_Base(Vector<double> vector, Vector<long> indices) {
                return Shuffle_Base(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Shuffle_Base(Vector<sbyte> vector, Vector<sbyte> indices) {
                return Shuffle_Base(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Shuffle_Base(Vector<byte> vector, Vector<byte> indices) {
                UnsafeEx.SkipInit(out Vector<byte> rt);
                byte cnt = (byte)Vector<byte>.Count;
                ref byte q = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref vector);
                ref byte pindices = ref Unsafe.As<Vector<byte>, byte>(ref indices);
                for (nint i = 0; i < Vector<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Shuffle_Base(Vector<short> vector, Vector<short> indices) {
                return Shuffle_Base(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Shuffle_Base(Vector<ushort> vector, Vector<ushort> indices) {
                UnsafeEx.SkipInit(out Vector<ushort> rt);
                ushort cnt = (ushort)Vector<ushort>.Count;
                ref ushort q = ref Unsafe.As<Vector<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref vector);
                ref ushort pindices = ref Unsafe.As<Vector<ushort>, ushort>(ref indices);
                for (nint i = 0; i < Vector<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Shuffle_Base(Vector<int> vector, Vector<int> indices) {
                return Shuffle_Base(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Shuffle_Base(Vector<uint> vector, Vector<uint> indices) {
                UnsafeEx.SkipInit(out Vector<uint> rt);
                uint cnt = (uint)Vector<uint>.Count;
                ref uint q = ref Unsafe.As<Vector<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref vector);
                ref uint pindices = ref Unsafe.As<Vector<uint>, uint>(ref indices);
                for (nint i = 0; i < Vector<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Shuffle_Base(Vector<long> vector, Vector<long> indices) {
                return Shuffle_Base(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Shuffle_Base(Vector<ulong> vector, Vector<ulong> indices) {
                UnsafeEx.SkipInit(out Vector<ulong> rt);
                ulong cnt = (ulong)Vector<ulong>.Count;
                ref ulong q = ref Unsafe.As<Vector<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref vector);
                ref ulong pindices = ref Unsafe.As<Vector<ulong>, ulong>(ref indices);
                for (nint i = 0; i < Vector<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1) {
                args0 = indices;
                args1 = default;
            }


            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{float}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Shuffle_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{double}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Shuffle_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Shuffle_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Shuffle_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Shuffle_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Shuffle_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Shuffle_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Shuffle_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Shuffle_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Shuffle_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }


            /// <inheritdoc cref="IVectorTraits.Sum_AcceleratedTypes"/>
            public static TypeCodeFlags Sum_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector<float> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector<double> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector<sbyte> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector<byte> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector<short> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector<ushort> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector<int> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector<uint> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector<long> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector<ulong> value) {
#if BCL_OVERRIDE_BASE_VAR && NET6_0_OR_GREATER
                return Vector.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum_Base(Vector<float> value) {
                ref float p = ref Unsafe.As<Vector<float>, float>(ref value);
                float rt = p;
                for (nint i = 1; i < Vector<float>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum_Base(Vector<double> value) {
                ref double p = ref Unsafe.As<Vector<double>, double>(ref value);
                double rt = p;
                for (nint i = 1; i < Vector<double>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum_Base(Vector<sbyte> value) {
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref value);
                sbyte rt = p;
                for (nint i = 1; i < Vector<sbyte>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum_Base(Vector<byte> value) {
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref value);
                byte rt = p;
                for (nint i = 1; i < Vector<byte>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum_Base(Vector<short> value) {
                ref short p = ref Unsafe.As<Vector<short>, short>(ref value);
                short rt = p;
                for (nint i = 1; i < Vector<short>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum_Base(Vector<ushort> value) {
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref value);
                ushort rt = p;
                for (nint i = 1; i < Vector<ushort>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum_Base(Vector<int> value) {
                ref int p = ref Unsafe.As<Vector<int>, int>(ref value);
                int rt = p;
                for (nint i = 1; i < Vector<int>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum_Base(Vector<uint> value) {
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref value);
                uint rt = p;
                for (nint i = 1; i < Vector<uint>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum_Base(Vector<long> value) {
                ref long p = ref Unsafe.As<Vector<long>, long>(ref value);
                long rt = p;
                for (nint i = 1; i < Vector<long>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum_Base(Vector<ulong> value) {
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref value);
                ulong rt = p;
                for (nint i = 1; i < Vector<ulong>.Count; ++i) {
                    rt += Unsafe.Add(ref p, i);
                }
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_VAR
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
#if BCL_OVERRIDE_BASE_VAR
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
#if BCL_OVERRIDE_BASE_VAR
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
#if BCL_OVERRIDE_BASE_VAR
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
#if BCL_OVERRIDE_BASE_VAR
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
#if BCL_OVERRIDE_BASE_VAR
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
#if BCL_OVERRIDE_BASE_VAR
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
#if BCL_OVERRIDE_BASE_VAR
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
                nint cnt = Vector<double>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref float p = ref Unsafe.As<Vector<float>, float>(ref source);
                ref double plower = ref Unsafe.As<Vector<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector<double>, double>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, i + cnt);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
                nint cnt = Vector<short>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref source);
                ref short plower = ref Unsafe.As<Vector<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector<short>, short>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, i + cnt);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
                nint cnt = Vector<ushort>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref source);
                ref ushort plower = ref Unsafe.As<Vector<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector<ushort>, ushort>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, i + cnt);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
                nint cnt = Vector<int>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref short p = ref Unsafe.As<Vector<short>, short>(ref source);
                ref int plower = ref Unsafe.As<Vector<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector<int>, int>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, i + cnt);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
                nint cnt = Vector<uint>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref source);
                ref uint plower = ref Unsafe.As<Vector<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector<uint>, uint>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, i + cnt);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
#if UNSAFE
                Widen_Base_NPtr(source, out lower, out upper);
#else
                Widen_Base_NRef(source, out lower, out upper);
#endif // UNSAFE
            }

#if UNSAFE
            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base_NPtr(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                nint cnt = Vector<long>.Count;
                int* p = (int*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    long* plower = (long*)plower0;
                    long* pupper = (long*)pupper0;
                    for (nint i = 0; i < cnt; ++i) {
                        plower[i] = p[i];
                        pupper[i] = p[i + cnt];
                    }
                }
            }
#endif // UNSAFE

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_NRef(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                nint cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, i + cnt);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_NRef2(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                nint cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref int q = ref Unsafe.Add(ref p, cnt);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref q, i);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_NRefInc(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                nint cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    plower = p;
                    pupper = Unsafe.Add(ref p, cnt);
                    p = ref Unsafe.Add(ref p, 1);
                    plower = ref Unsafe.Add(ref plower, 1);
                    pupper = ref Unsafe.Add(ref pupper, 1);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_NRefInc2(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                nint cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref int q = ref Unsafe.Add(ref p, cnt);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    // C language: *plower++ = *p++; *pupper++ = *q++;
                    plower = p;
                    pupper = q;
                    p = ref Unsafe.Add(ref p, 1);
                    q = ref Unsafe.Add(ref q, 1);
                    plower = ref Unsafe.Add(ref plower, 1);
                    pupper = ref Unsafe.Add(ref pupper, 1);
                }
            }

#if UNSAFE
            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base_Ptr(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                int cnt = Vector<long>.Count;
                int* p = (int*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    long* plower = (long*)plower0;
                    long* pupper = (long*)pupper0;
                    for (int i = 0; i < cnt; ++i) {
                        plower[i] = p[i];
                        pupper[i] = p[i + cnt];
                    }
                }
            }
#endif // UNSAFE

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_Ref(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                int cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                for (int i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, i + cnt);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_Ref2(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                int cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref int q = ref Unsafe.Add(ref p, cnt);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                for (int i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref q, i);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_RefInc(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                int cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                for (int i = 0; i < cnt; ++i) {
                    plower = p;
                    pupper = Unsafe.Add(ref p, cnt);
                    p = ref Unsafe.Add(ref p, 1);
                    plower = ref Unsafe.Add(ref plower, 1);
                    pupper = ref Unsafe.Add(ref pupper, 1);
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
                nint cnt = Vector<ulong>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref source);
                ref ulong plower = ref Unsafe.As<Vector<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector<ulong>, ulong>(ref upper);
                for (nint i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i);
                    Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, i + cnt);
                }
            }


        } // Statics

    }
}
