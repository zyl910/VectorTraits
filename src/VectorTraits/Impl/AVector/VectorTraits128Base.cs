using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector {
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
                return Ceiling_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Ceiling(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.Ceiling(value);
#else
                return Ceiling_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<float> Ceiling_Basic(Vector<float> value) {
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
            public static unsafe Vector<double> Ceiling_Basic(Vector<double> value) {
                Vector<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Ceiling(p[0]);
                p[1] = Math.Ceiling(p[1]);
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Narrow(Vector<double> lower, Vector<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Narrow(Vector<short> lower, Vector<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Narrow(Vector<ushort> lower, Vector<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Narrow(Vector<int> lower, Vector<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Narrow(Vector<uint> lower, Vector<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Narrow(Vector<long> lower, Vector<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Narrow(Vector<ulong> lower, Vector<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                return Vector.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Narrow_Basic(Vector<double> lower, Vector<double> upper) {
                nint cnt = Vector<double>.Count;
                UnsafeEx.SkipInit(out Vector<float> rt);
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                ref double plower = ref Unsafe.As<Vector<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector<double>, double>(ref upper);
                p = (float)plower;
                Unsafe.Add(ref p, 1) = (float)Unsafe.Add(ref plower, 1);
                p = ref Unsafe.Add(ref p, cnt);
                p = (float)pupper;
                Unsafe.Add(ref p, 1) = (float)Unsafe.Add(ref pupper, 1);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Narrow_Basic(Vector<short> lower, Vector<short> upper) {
                nint cnt = Vector<short>.Count;
                UnsafeEx.SkipInit(out Vector<sbyte> rt);
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                ref short plower = ref Unsafe.As<Vector<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector<short>, short>(ref upper);
                p = (sbyte)plower;
                Unsafe.Add(ref p, 1) = (sbyte)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (sbyte)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (sbyte)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (sbyte)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (sbyte)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (sbyte)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (sbyte)Unsafe.Add(ref plower, 7);
                p = ref Unsafe.Add(ref p, cnt);
                p = (sbyte)pupper;
                Unsafe.Add(ref p, 1) = (sbyte)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (sbyte)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (sbyte)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (sbyte)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (sbyte)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (sbyte)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (sbyte)Unsafe.Add(ref pupper, 7);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Narrow_Basic(Vector<ushort> lower, Vector<ushort> upper) {
                nint cnt = Vector<ushort>.Count;
                UnsafeEx.SkipInit(out Vector<byte> rt);
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                ref ushort plower = ref Unsafe.As<Vector<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector<ushort>, ushort>(ref upper);
                p = (byte)plower;
                Unsafe.Add(ref p, 1) = (byte)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (byte)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (byte)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (byte)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (byte)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (byte)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (byte)Unsafe.Add(ref plower, 7);
                p = ref Unsafe.Add(ref p, cnt);
                p = (byte)pupper;
                Unsafe.Add(ref p, 1) = (byte)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (byte)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (byte)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (byte)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (byte)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (byte)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (byte)Unsafe.Add(ref pupper, 7);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Narrow_Basic(Vector<int> lower, Vector<int> upper) {
                nint cnt = Vector<int>.Count;
                UnsafeEx.SkipInit(out Vector<short> rt);
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                ref int plower = ref Unsafe.As<Vector<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector<int>, int>(ref upper);
                p = (short)plower;
                Unsafe.Add(ref p, 1) = (short)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (short)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (short)Unsafe.Add(ref plower, 3);
                p = ref Unsafe.Add(ref p, cnt);
                p = (short)pupper;
                Unsafe.Add(ref p, 1) = (short)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (short)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (short)Unsafe.Add(ref pupper, 3);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Narrow_Basic(Vector<uint> lower, Vector<uint> upper) {
                nint cnt = Vector<uint>.Count;
                UnsafeEx.SkipInit(out Vector<ushort> rt);
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref rt);
                ref uint plower = ref Unsafe.As<Vector<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector<uint>, uint>(ref upper);
                p = (ushort)plower;
                Unsafe.Add(ref p, 1) = (ushort)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (ushort)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (ushort)Unsafe.Add(ref plower, 3);
                p = ref Unsafe.Add(ref p, cnt);
                p = (ushort)pupper;
                Unsafe.Add(ref p, 1) = (ushort)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (ushort)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (ushort)Unsafe.Add(ref pupper, 3);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Narrow_Basic(Vector<long> lower, Vector<long> upper) {
                nint cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out Vector<int> rt);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                p = (int)plower;
                Unsafe.Add(ref p, 1) = (int)Unsafe.Add(ref plower, 1);
                p = ref Unsafe.Add(ref p, cnt);
                p = (int)pupper;
                Unsafe.Add(ref p, 1) = (int)Unsafe.Add(ref pupper, 1);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Narrow_Basic(Vector<ulong> lower, Vector<ulong> upper) {
                nint cnt = Vector<ulong>.Count;
                UnsafeEx.SkipInit(out Vector<uint> rt);
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref rt);
                ref ulong plower = ref Unsafe.As<Vector<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector<ulong>, ulong>(ref upper);
                p = (uint)plower;
                Unsafe.Add(ref p, 1) = (uint)Unsafe.Add(ref plower, 1);
                p = ref Unsafe.Add(ref p, cnt);
                p = (uint)pupper;
                Unsafe.Add(ref p, 1) = (uint)Unsafe.Add(ref pupper, 1);
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
                return ShiftLeft_Basic(value, shiftAmount);
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
                return ShiftLeft_Basic(value, shiftAmount);
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
                return ShiftLeft_Basic(value, shiftAmount);
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
                return ShiftLeft_Basic(value, shiftAmount);
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
                return ShiftLeft_Basic(value, shiftAmount);
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
                return ShiftLeft_Basic(value, shiftAmount);
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
                return ShiftLeft_Basic(value, shiftAmount);
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
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Basic(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Basic(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Basic(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Basic(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Basic(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Basic(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Basic(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Basic(Vector<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

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
                args1 = VectorConstants.GetResidueMaskBits_Byte(shiftAmount);
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
                return BaseStatics.ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Fast(Vector<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Fast(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Fast(Vector<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Fast(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Fast(Vector<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Fast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return BaseStatics.ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Fast(Vector<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return BaseStatics.ShiftLeft_Fast_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Fast_Basic(Vector<sbyte> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Fast_Basic(Vector<byte> value, int shiftAmount) {
                Vector<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                Unsafe.Add(ref p, 2) <<= shiftAmount;
                Unsafe.Add(ref p, 3) <<= shiftAmount;
                Unsafe.Add(ref p, 4) <<= shiftAmount;
                Unsafe.Add(ref p, 5) <<= shiftAmount;
                Unsafe.Add(ref p, 6) <<= shiftAmount;
                Unsafe.Add(ref p, 7) <<= shiftAmount;
                Unsafe.Add(ref p, 8) <<= shiftAmount;
                Unsafe.Add(ref p, 9) <<= shiftAmount;
                Unsafe.Add(ref p, 10) <<= shiftAmount;
                Unsafe.Add(ref p, 11) <<= shiftAmount;
                Unsafe.Add(ref p, 12) <<= shiftAmount;
                Unsafe.Add(ref p, 13) <<= shiftAmount;
                Unsafe.Add(ref p, 14) <<= shiftAmount;
                Unsafe.Add(ref p, 15) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Fast_Basic(Vector<short> value, int shiftAmount) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                Unsafe.Add(ref p, 2) <<= shiftAmount;
                Unsafe.Add(ref p, 3) <<= shiftAmount;
                Unsafe.Add(ref p, 4) <<= shiftAmount;
                Unsafe.Add(ref p, 5) <<= shiftAmount;
                Unsafe.Add(ref p, 6) <<= shiftAmount;
                Unsafe.Add(ref p, 7) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Fast_Basic(Vector<ushort> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Fast_Basic(Vector<int> value, int shiftAmount) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                Unsafe.Add(ref p, 2) <<= shiftAmount;
                Unsafe.Add(ref p, 3) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Fast_Basic(Vector<uint> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsInt32(), shiftAmount).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Fast_Basic(Vector<long> value, int shiftAmount) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Fast_Basic(Vector<ulong> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsInt64(), shiftAmount).AsUInt64();
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
                return ShiftRightArithmetic_Basic(value, shiftAmount);
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
                return ShiftRightArithmetic_Basic(value, shiftAmount);
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
                return ShiftRightArithmetic_Basic(value, shiftAmount);
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
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Basic(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Basic(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Basic(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Basic(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                Vector<sbyte> args0 = default;
                args1 = VectorConstants.GetResidueMaskBits_SByte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{short}, int, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
                _ = dummy;
                shiftAmount &= 0x0F;
                Vector<short> args0 = default;
                args1 = VectorConstants.GetResidueMaskBits_Int16(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{int}, int, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
                _ = dummy;
                shiftAmount &= 0x1F;
                Vector<int> args0 = default;
                args1 = VectorConstants.GetResidueMaskBits_Int32(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{long}, int, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
                _ = dummy;
                shiftAmount &= 0x3F;
                Vector<long> args0 = default;
                args1 = VectorConstants.GetResidueMaskBits_Int64(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                _ = args0;
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER // .NET7 no hardware acceleration! X86(sse, avx)
                _ = args1;
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#else
                shiftAmount &= 7;
                Vector<sbyte> sign = Vector.GreaterThan(Vector<sbyte>.Zero, value);
                Vector<sbyte> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsSByte();
                Vector<sbyte> rt = Vector.ConditionalSelect(args1, shifted, sign);
                return rt;
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
                _ = args0;
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                _ = args1;
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#else
                shiftAmount &= 0x0F;
                Vector<short> sign = Vector.GreaterThan(Vector<short>.Zero, value);
                Vector<short> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsInt16();
                Vector<short> rt = Vector.ConditionalSelect(args1, shifted, sign);
                return rt;
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
                _ = args0;
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                _ = args1;
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#else
                shiftAmount &= 0x1F;
                Vector<int> sign = Vector.GreaterThan(Vector<int>.Zero, value);
                Vector<int> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsInt32();
                Vector<int> rt = Vector.ConditionalSelect(args1, shifted, sign);
                return rt;
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
                _ = args0;
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER && SOFTWARE_OPTIMIZATION
                // .NET7 no hardware acceleration! X86(sse, avx)
                if (VectorEnvironment.ProcessIsX86Family) {
                    shiftAmount &= 0x3F;
                    Vector<long> sign = Vector.GreaterThan(Vector<long>.Zero, value);
                    Vector<long> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsInt64();
                    Vector<long> rt = Vector.ConditionalSelect(args1, shifted, sign);
                    return rt;
                } else {
                    _ = args1;
                    return Vector.ShiftRightArithmetic(value, shiftAmount);
                }
#elif BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                _ = args1;
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#else
                _ = args1;
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                _ = args0;
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER // .NET7 no hardware acceleration! X86(sse, avx)
                _ = args1;
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#else
                Vector<sbyte> sign = Vector.GreaterThan(Vector<sbyte>.Zero, value);
                Vector<sbyte> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsSByte();
                Vector<sbyte> rt = Vector.ConditionalSelect(args1, shifted, sign);
                return rt;
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
                _ = args0;
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                _ = args1;
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#else
                Vector<short> sign = Vector.GreaterThan(Vector<short>.Zero, value);
                Vector<short> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsInt16();
                Vector<short> rt = Vector.ConditionalSelect(args1, shifted, sign);
                return rt;
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
                _ = args0;
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                _ = args1;
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#else
                Vector<int> sign = Vector.GreaterThan(Vector<int>.Zero, value);
                Vector<int> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsInt32();
                Vector<int> rt = Vector.ConditionalSelect(args1, shifted, sign);
                return rt;
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
                _ = args0;
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER && SOFTWARE_OPTIMIZATION
                // .NET7 no hardware acceleration! X86(sse, avx)
                if (VectorEnvironment.ProcessIsX86Family) {
                    Vector<long> sign = Vector.GreaterThan(Vector<long>.Zero, value);
                    Vector<long> shifted = ShiftRightLogical_Fast(value.AsUInt64(), shiftAmount).AsInt64();
                    Vector<long> rt = Vector.ConditionalSelect(args1, shifted, sign);
                    return rt;
                } else {
                    _ = args1;
                    return Vector.ShiftRightArithmetic(value, shiftAmount);
                }
#elif BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                _ = args1;
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#else
                _ = args1;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Fast(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER // .NET7 no hardware acceleration! X86(sse, avx)
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
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
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
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
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Fast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER && SOFTWARE_OPTIMIZATION
                // .NET7 no hardware acceleration! X86(sse, avx)
                if (VectorEnvironment.ProcessIsX86Family) {
                    return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
                } else {
                    return Vector.ShiftRightArithmetic(value, shiftAmount);
                }
#elif BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Fast_Basic(Vector<sbyte> value, int shiftAmount) {
                Vector<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                Unsafe.Add(ref p, 8) >>= shiftAmount;
                Unsafe.Add(ref p, 9) >>= shiftAmount;
                Unsafe.Add(ref p, 10) >>= shiftAmount;
                Unsafe.Add(ref p, 11) >>= shiftAmount;
                Unsafe.Add(ref p, 12) >>= shiftAmount;
                Unsafe.Add(ref p, 13) >>= shiftAmount;
                Unsafe.Add(ref p, 14) >>= shiftAmount;
                Unsafe.Add(ref p, 15) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Fast_Basic(Vector<short> value, int shiftAmount) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Fast_Basic(Vector<int> value, int shiftAmount) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Fast_Basic(Vector<long> value, int shiftAmount) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
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
                return ShiftRightLogical_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Basic(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Basic(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Basic(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Basic(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Basic(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Basic(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Basic(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Basic(Vector<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
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
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{short}, int, out Vector{short})"/>
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
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
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
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Fast_Basic(Vector<sbyte> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Fast_Basic(Vector<byte> value, int shiftAmount) {
                Vector<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                Unsafe.Add(ref p, 8) >>= shiftAmount;
                Unsafe.Add(ref p, 9) >>= shiftAmount;
                Unsafe.Add(ref p, 10) >>= shiftAmount;
                Unsafe.Add(ref p, 11) >>= shiftAmount;
                Unsafe.Add(ref p, 12) >>= shiftAmount;
                Unsafe.Add(ref p, 13) >>= shiftAmount;
                Unsafe.Add(ref p, 14) >>= shiftAmount;
                Unsafe.Add(ref p, 15) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Fast_Basic(Vector<short> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Fast_Basic(Vector<ushort> value, int shiftAmount) {
                Vector<ushort> rt = value;
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Fast_Basic(Vector<int> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Fast_Basic(Vector<uint> value, int shiftAmount) {
                Vector<uint> rt = value;
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Fast_Basic(Vector<long> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsUInt64(), shiftAmount).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Fast_Basic(Vector<ulong> value, int shiftAmount) {
                Vector<ulong> rt = value;
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
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
                Vector<byte> t = ShiftRightLogical_Fast_Basic(value.AsUInt64(), shiftAmount).AsByte();
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
                Vector<ushort> t = ShiftRightLogical_Fast_Basic(value.AsUInt64(), shiftAmount).AsUInt16();
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
                Vector<uint> t = ShiftRightLogical_Fast_Basic(value.AsUInt64(), shiftAmount).AsUInt32();
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
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
                nint cnt = Vector<double>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref float p = ref Unsafe.As<Vector<float>, float>(ref source);
                ref double plower = ref Unsafe.As<Vector<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector<double>, double>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
                nint cnt = Vector<short>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref source);
                ref short plower = ref Unsafe.As<Vector<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector<short>, short>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
                nint cnt = Vector<ushort>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref source);
                ref ushort plower = ref Unsafe.As<Vector<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector<ushort>, ushort>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
                nint cnt = Vector<int>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref short p = ref Unsafe.As<Vector<short>, short>(ref source);
                ref int plower = ref Unsafe.As<Vector<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector<int>, int>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
                nint cnt = Vector<uint>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref source);
                ref uint plower = ref Unsafe.As<Vector<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector<uint>, uint>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
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
                nint cnt = Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                p = ref Unsafe.Add(ref p, cnt);
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
                nint cnt = 2; // Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                plower = p; pupper = Unsafe.Add(ref p, cnt); plower = ref Unsafe.Add(ref plower, 1); pupper = ref Unsafe.Add(ref pupper, 1); p = ref Unsafe.Add(ref p, 1);
                plower = p; pupper = Unsafe.Add(ref p, cnt);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_RefInc2(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                nint cnt = 2; // Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref int q = ref Unsafe.Add(ref p, cnt);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                plower = p; pupper = q; p = ref Unsafe.Add(ref p, 1); q = ref Unsafe.Add(ref q, 1); plower = ref Unsafe.Add(ref plower, 1); pupper = ref Unsafe.Add(ref pupper, 1);
                plower = p; pupper = q;
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
                nint cnt = Vector<ulong>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref source);
                ref ulong plower = ref Unsafe.As<Vector<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector<ulong>, ulong>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
            }

        } // Statics
    }
}
