using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using Zyl.VectorTraits.Impl.Util;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Base.
    /// </summary>
    public sealed partial class WVectorTraits256Base : WVectorTraits256Abstract {
        private static readonly WVectorTraits256Base _instance = new WVectorTraits256Base(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits256Base Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector256{T}"/> traits.Statics - Base.
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
                bool rt = false;
#if NETCOREAPP3_0_OR_GREATER
                rt = true;
#else
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Vector256 type is not supported!";
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Ceiling(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Ceiling(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Ceiling_Base(Vector256<float> value) {
                Vector256<float> rt = value;
                float* p = (float*)&rt;
                p[0] = MathF.Ceiling(p[0]);
                p[1] = MathF.Ceiling(p[1]);
                p[2] = MathF.Ceiling(p[2]);
                p[3] = MathF.Ceiling(p[3]);
                p[4] = MathF.Ceiling(p[4]);
                p[5] = MathF.Ceiling(p[5]);
                p[6] = MathF.Ceiling(p[6]);
                p[7] = MathF.Ceiling(p[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Ceiling_Base(Vector256<double> value) {
                Vector256<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Ceiling(p[0]);
                p[1] = Math.Ceiling(p[1]);
                p[2] = Math.Ceiling(p[2]);
                p[3] = Math.Ceiling(p[3]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ConvertToDouble(value);
#else
                return ConvertToDouble_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble(Vector256<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ConvertToDouble(value);
#else
                return ConvertToDouble_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Base(Vector256<long> value) {
                UnsafeEx.SkipInit(out Vector256<double> rt);
                ref double prt = ref Unsafe.As<Vector256<double>, double>(ref rt);
                ref long p = ref Unsafe.As<Vector256<long>, long>(ref value);
                prt = (Double)p;
                Unsafe.Add(ref prt, 1) = (Double)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Double)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Double)Unsafe.Add(ref p, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Base(Vector256<ulong> value) {
                UnsafeEx.SkipInit(out Vector256<double> rt);
                ref double prt = ref Unsafe.As<Vector256<double>, double>(ref rt);
                ref ulong p = ref Unsafe.As<Vector256<ulong>, ulong>(ref value);
                prt = (Double)p;
                Unsafe.Add(ref prt, 1) = (Double)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Double)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Double)Unsafe.Add(ref p, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Floor(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Floor(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Floor_Base(Vector256<float> value) {
                Vector256<float> rt = value;
                float* p = (float*)&rt;
                p[0] = MathF.Floor(p[0]);
                p[1] = MathF.Floor(p[1]);
                p[2] = MathF.Floor(p[2]);
                p[3] = MathF.Floor(p[3]);
                p[4] = MathF.Floor(p[4]);
                p[5] = MathF.Floor(p[5]);
                p[6] = MathF.Floor(p[6]);
                p[7] = MathF.Floor(p[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Floor_Base(Vector256<double> value) {
                Vector256<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Floor(p[0]);
                p[1] = Math.Floor(p[1]);
                p[2] = Math.Floor(p[2]);
                p[3] = Math.Floor(p[3]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{double}, Vector256{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Narrow(Vector256<double> lower, Vector256<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{short}, Vector256{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Narrow(Vector256<short> lower, Vector256<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ushort}, Vector256{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Narrow(Vector256<ushort> lower, Vector256<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{int}, Vector256{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Narrow(Vector256<int> lower, Vector256<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{uint}, Vector256{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Narrow(Vector256<uint> lower, Vector256<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{long}, Vector256{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Narrow(Vector256<long> lower, Vector256<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ulong}, Vector256{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Narrow(Vector256<ulong> lower, Vector256<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{double}, Vector256{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Narrow_Base(Vector256<double> lower, Vector256<double> upper) {
                nint cnt = Vector256<double>.Count;
                UnsafeEx.SkipInit(out Vector256<float> rt);
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref rt);
                ref double plower = ref Unsafe.As<Vector256<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector256<double>, double>(ref upper);
                p = (float)plower;
                Unsafe.Add(ref p, 1) = (float)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (float)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (float)Unsafe.Add(ref plower, 3);
                p = ref Unsafe.Add(ref p, cnt);
                p = (float)pupper;
                Unsafe.Add(ref p, 1) = (float)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (float)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (float)Unsafe.Add(ref pupper, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{short}, Vector256{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Narrow_Base(Vector256<short> lower, Vector256<short> upper) {
                nint cnt = Vector256<short>.Count;
                UnsafeEx.SkipInit(out Vector256<sbyte> rt);
                ref sbyte p = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref rt);
                ref short plower = ref Unsafe.As<Vector256<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector256<short>, short>(ref upper);
                p = (sbyte)plower;
                Unsafe.Add(ref p, 1) = (sbyte)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (sbyte)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (sbyte)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (sbyte)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (sbyte)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (sbyte)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (sbyte)Unsafe.Add(ref plower, 7);
                Unsafe.Add(ref p, 8) = (sbyte)Unsafe.Add(ref plower, 8);
                Unsafe.Add(ref p, 9) = (sbyte)Unsafe.Add(ref plower, 9);
                Unsafe.Add(ref p, 10) = (sbyte)Unsafe.Add(ref plower, 10);
                Unsafe.Add(ref p, 11) = (sbyte)Unsafe.Add(ref plower, 11);
                Unsafe.Add(ref p, 12) = (sbyte)Unsafe.Add(ref plower, 12);
                Unsafe.Add(ref p, 13) = (sbyte)Unsafe.Add(ref plower, 13);
                Unsafe.Add(ref p, 14) = (sbyte)Unsafe.Add(ref plower, 14);
                Unsafe.Add(ref p, 15) = (sbyte)Unsafe.Add(ref plower, 15);
                p = ref Unsafe.Add(ref p, cnt);
                p = (sbyte)pupper;
                Unsafe.Add(ref p, 1) = (sbyte)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (sbyte)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (sbyte)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (sbyte)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (sbyte)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (sbyte)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (sbyte)Unsafe.Add(ref pupper, 7);
                Unsafe.Add(ref p, 8) = (sbyte)Unsafe.Add(ref pupper, 8);
                Unsafe.Add(ref p, 9) = (sbyte)Unsafe.Add(ref pupper, 9);
                Unsafe.Add(ref p, 10) = (sbyte)Unsafe.Add(ref pupper, 10);
                Unsafe.Add(ref p, 11) = (sbyte)Unsafe.Add(ref pupper, 11);
                Unsafe.Add(ref p, 12) = (sbyte)Unsafe.Add(ref pupper, 12);
                Unsafe.Add(ref p, 13) = (sbyte)Unsafe.Add(ref pupper, 13);
                Unsafe.Add(ref p, 14) = (sbyte)Unsafe.Add(ref pupper, 14);
                Unsafe.Add(ref p, 15) = (sbyte)Unsafe.Add(ref pupper, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ushort}, Vector256{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Narrow_Base(Vector256<ushort> lower, Vector256<ushort> upper) {
                nint cnt = Vector256<ushort>.Count;
                UnsafeEx.SkipInit(out Vector256<byte> rt);
                ref byte p = ref Unsafe.As<Vector256<byte>, byte>(ref rt);
                ref ushort plower = ref Unsafe.As<Vector256<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector256<ushort>, ushort>(ref upper);
                p = (byte)plower;
                Unsafe.Add(ref p, 1) = (byte)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (byte)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (byte)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (byte)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (byte)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (byte)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (byte)Unsafe.Add(ref plower, 7);
                Unsafe.Add(ref p, 8) = (byte)Unsafe.Add(ref plower, 8);
                Unsafe.Add(ref p, 9) = (byte)Unsafe.Add(ref plower, 9);
                Unsafe.Add(ref p, 10) = (byte)Unsafe.Add(ref plower, 10);
                Unsafe.Add(ref p, 11) = (byte)Unsafe.Add(ref plower, 11);
                Unsafe.Add(ref p, 12) = (byte)Unsafe.Add(ref plower, 12);
                Unsafe.Add(ref p, 13) = (byte)Unsafe.Add(ref plower, 13);
                Unsafe.Add(ref p, 14) = (byte)Unsafe.Add(ref plower, 14);
                Unsafe.Add(ref p, 15) = (byte)Unsafe.Add(ref plower, 15);
                p = ref Unsafe.Add(ref p, cnt);
                p = (byte)pupper;
                Unsafe.Add(ref p, 1) = (byte)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (byte)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (byte)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (byte)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (byte)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (byte)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (byte)Unsafe.Add(ref pupper, 7);
                Unsafe.Add(ref p, 8) = (byte)Unsafe.Add(ref pupper, 8);
                Unsafe.Add(ref p, 9) = (byte)Unsafe.Add(ref pupper, 9);
                Unsafe.Add(ref p, 10) = (byte)Unsafe.Add(ref pupper, 10);
                Unsafe.Add(ref p, 11) = (byte)Unsafe.Add(ref pupper, 11);
                Unsafe.Add(ref p, 12) = (byte)Unsafe.Add(ref pupper, 12);
                Unsafe.Add(ref p, 13) = (byte)Unsafe.Add(ref pupper, 13);
                Unsafe.Add(ref p, 14) = (byte)Unsafe.Add(ref pupper, 14);
                Unsafe.Add(ref p, 15) = (byte)Unsafe.Add(ref pupper, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{int}, Vector256{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Narrow_Base(Vector256<int> lower, Vector256<int> upper) {
                nint cnt = Vector256<int>.Count;
                UnsafeEx.SkipInit(out Vector256<short> rt);
                ref short p = ref Unsafe.As<Vector256<short>, short>(ref rt);
                ref int plower = ref Unsafe.As<Vector256<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector256<int>, int>(ref upper);
                p = (short)plower;
                Unsafe.Add(ref p, 1) = (short)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (short)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (short)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (short)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (short)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (short)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (short)Unsafe.Add(ref plower, 7);
                p = ref Unsafe.Add(ref p, cnt);
                p = (short)pupper;
                Unsafe.Add(ref p, 1) = (short)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (short)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (short)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (short)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (short)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (short)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (short)Unsafe.Add(ref pupper, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{uint}, Vector256{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Narrow_Base(Vector256<uint> lower, Vector256<uint> upper) {
                nint cnt = Vector256<uint>.Count;
                UnsafeEx.SkipInit(out Vector256<ushort> rt);
                ref ushort p = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt);
                ref uint plower = ref Unsafe.As<Vector256<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector256<uint>, uint>(ref upper);
                p = (ushort)plower;
                Unsafe.Add(ref p, 1) = (ushort)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (ushort)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (ushort)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (ushort)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (ushort)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (ushort)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (ushort)Unsafe.Add(ref plower, 7);
                p = ref Unsafe.Add(ref p, cnt);
                p = (ushort)pupper;
                Unsafe.Add(ref p, 1) = (ushort)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (ushort)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (ushort)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (ushort)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (ushort)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (ushort)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (ushort)Unsafe.Add(ref pupper, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{long}, Vector256{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Narrow_Base(Vector256<long> lower, Vector256<long> upper) {
                nint cnt = Vector256<long>.Count;
                UnsafeEx.SkipInit(out Vector256<int> rt);
                ref int p = ref Unsafe.As<Vector256<int>, int>(ref rt);
                ref long plower = ref Unsafe.As<Vector256<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector256<long>, long>(ref upper);
                p = (int)plower;
                Unsafe.Add(ref p, 1) = (int)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (int)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (int)Unsafe.Add(ref plower, 3);
                p = ref Unsafe.Add(ref p, cnt);
                p = (int)pupper;
                Unsafe.Add(ref p, 1) = (int)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (int)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (int)Unsafe.Add(ref pupper, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ulong}, Vector256{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Narrow_Base(Vector256<ulong> lower, Vector256<ulong> upper) {
                nint cnt = Vector256<ulong>.Count;
                UnsafeEx.SkipInit(out Vector256<uint> rt);
                ref uint p = ref Unsafe.As<Vector256<uint>, uint>(ref rt);
                ref ulong plower = ref Unsafe.As<Vector256<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector256<ulong>, ulong>(ref upper);
                p = (uint)plower;
                Unsafe.Add(ref p, 1) = (uint)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (uint)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (uint)Unsafe.Add(ref plower, 3);
                p = ref Unsafe.Add(ref p, cnt);
                p = (uint)pupper;
                Unsafe.Add(ref p, 1) = (uint)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (uint)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (uint)Unsafe.Add(ref pupper, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Base(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Base(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Base(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Base(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Base(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Base(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Base(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Base(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeftFast_Base(Vector256<sbyte> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> ShiftLeftFast_Base(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> rt = value;
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
                p[16] <<= shiftAmount;
                p[17] <<= shiftAmount;
                p[18] <<= shiftAmount;
                p[19] <<= shiftAmount;
                p[20] <<= shiftAmount;
                p[21] <<= shiftAmount;
                p[22] <<= shiftAmount;
                p[23] <<= shiftAmount;
                p[24] <<= shiftAmount;
                p[25] <<= shiftAmount;
                p[26] <<= shiftAmount;
                p[27] <<= shiftAmount;
                p[28] <<= shiftAmount;
                p[29] <<= shiftAmount;
                p[30] <<= shiftAmount;
                p[31] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftLeftFast_Base(Vector256<short> value, int shiftAmount) {
                Vector256<short> rt = value;
                short* p = (short*)&rt;
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> ShiftLeftFast_Base(Vector256<ushort> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftLeftFast_Base(Vector256<int> value, int shiftAmount) {
                Vector256<int> rt = value;
                int* p = (int*)&rt;
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> ShiftLeftFast_Base(Vector256<uint> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt32(), shiftAmount).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftLeftFast_Base(Vector256<long> value, int shiftAmount) {
                Vector256<long> rt = value;
                long* p = (long*)&rt;
                p[0] <<= shiftAmount;
                p[1] <<= shiftAmount;
                p[2] <<= shiftAmount;
                p[3] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> ShiftLeftFast_Base(Vector256<ulong> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt64(), shiftAmount).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftRightArithmetic_Base(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftRightArithmetic_Base(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftRightArithmetic_Base(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftRightArithmetic_Base(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmeticFast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmeticFast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmeticFast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmeticFast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftRightArithmeticFast_Base(Vector256<sbyte> value, int shiftAmount) {
                Vector256<sbyte> rt = value;
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
                p[16] >>= shiftAmount;
                p[17] >>= shiftAmount;
                p[18] >>= shiftAmount;
                p[19] >>= shiftAmount;
                p[20] >>= shiftAmount;
                p[21] >>= shiftAmount;
                p[22] >>= shiftAmount;
                p[23] >>= shiftAmount;
                p[24] >>= shiftAmount;
                p[25] >>= shiftAmount;
                p[26] >>= shiftAmount;
                p[27] >>= shiftAmount;
                p[28] >>= shiftAmount;
                p[29] >>= shiftAmount;
                p[30] >>= shiftAmount;
                p[31] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftRightArithmeticFast_Base(Vector256<short> value, int shiftAmount) {
                Vector256<short> rt = value;
                short* p = (short*)&rt;
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftRightArithmeticFast_Base(Vector256<int> value, int shiftAmount) {
                Vector256<int> rt = value;
                int* p = (int*)&rt;
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftRightArithmeticFast_Base(Vector256<long> value, int shiftAmount) {
                Vector256<long> rt = value;
                long* p = (long*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftRightLogical_Base(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> ShiftRightLogical_Base(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftRightLogical_Base(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> ShiftRightLogical_Base(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftRightLogical_Base(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> ShiftRightLogical_Base(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftRightLogical_Base(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> ShiftRightLogical_Base(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogicalFast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogicalFast(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogicalFast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogicalFast(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogicalFast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogicalFast(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogicalFast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogicalFast(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftRightLogicalFast_Base(Vector256<sbyte> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> ShiftRightLogicalFast_Base(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> rt = value;
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
                p[16] >>= shiftAmount;
                p[17] >>= shiftAmount;
                p[18] >>= shiftAmount;
                p[19] >>= shiftAmount;
                p[20] >>= shiftAmount;
                p[21] >>= shiftAmount;
                p[22] >>= shiftAmount;
                p[23] >>= shiftAmount;
                p[24] >>= shiftAmount;
                p[25] >>= shiftAmount;
                p[26] >>= shiftAmount;
                p[27] >>= shiftAmount;
                p[28] >>= shiftAmount;
                p[29] >>= shiftAmount;
                p[30] >>= shiftAmount;
                p[31] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftRightLogicalFast_Base(Vector256<short> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> ShiftRightLogicalFast_Base(Vector256<ushort> value, int shiftAmount) {
                Vector256<ushort> rt = value;
                ushort* p = (ushort*)&rt;
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftRightLogicalFast_Base(Vector256<int> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> ShiftRightLogicalFast_Base(Vector256<uint> value, int shiftAmount) {
                Vector256<uint> rt = value;
                uint* p = (uint*)&rt;
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftRightLogicalFast_Base(Vector256<long> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt64(), shiftAmount).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> ShiftRightLogicalFast_Base(Vector256<ulong> value, int shiftAmount) {
                Vector256<ulong> rt = value;
                ulong* p = (ulong*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper) {
                nint cnt = Vector256<double>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref source);
                ref double plower = ref Unsafe.As<Vector256<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector256<double>, double>(ref upper);
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

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
                nint cnt = Vector256<short>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref sbyte p = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref source);
                ref short plower = ref Unsafe.As<Vector256<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector256<short>, short>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref plower, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref plower, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref plower, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref plower, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref plower, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref plower, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref plower, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref plower, 15) = Unsafe.Add(ref p, 15);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref pupper, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref pupper, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref pupper, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref pupper, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref pupper, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref pupper, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref pupper, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref pupper, 15) = Unsafe.Add(ref p, 15);
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
                nint cnt = Vector256<ushort>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref byte p = ref Unsafe.As<Vector256<byte>, byte>(ref source);
                ref ushort plower = ref Unsafe.As<Vector256<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector256<ushort>, ushort>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref plower, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref plower, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref plower, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref plower, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref plower, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref plower, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref plower, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref plower, 15) = Unsafe.Add(ref p, 15);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref pupper, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref pupper, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref pupper, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref pupper, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref pupper, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref pupper, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref pupper, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref pupper, 15) = Unsafe.Add(ref p, 15);
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
                nint cnt = Vector256<int>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref short p = ref Unsafe.As<Vector256<short>, short>(ref source);
                ref int plower = ref Unsafe.As<Vector256<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector256<int>, int>(ref upper);
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

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
                nint cnt = Vector256<uint>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref ushort p = ref Unsafe.As<Vector256<ushort>, ushort>(ref source);
                ref uint plower = ref Unsafe.As<Vector256<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector256<uint>, uint>(ref upper);
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

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
                nint cnt = Vector256<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector256<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector256<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector256<long>, long>(ref upper);
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

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
                nint cnt = Vector256<ulong>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref uint p = ref Unsafe.As<Vector256<uint>, uint>(ref source);
                ref ulong plower = ref Unsafe.As<Vector256<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector256<ulong>, ulong>(ref upper);
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


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
