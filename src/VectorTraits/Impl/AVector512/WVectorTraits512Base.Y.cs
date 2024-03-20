#if NET7_0_OR_GREATER
#define VECTOR_HAS_METHOD
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl.AVector512 {
    partial class WVectorTraits512Base {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits512.YBitToByte_IsAccelerated"/>
            public static bool YBitToByte_IsAccelerated {
                get {
                    bool rt = false;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = true;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YBitToByte(uint value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YBitToByte_Widen(value);
#else
                return YBitToByte_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YBitToByte_Basic(uint value) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref sbyte p = ref Unsafe.As<Vector512<byte>, sbyte>(ref rt);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    p = (sbyte)-((value >> i) & 1); // 1 for all bits: (sbyte)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YBitToByte_Widen(uint value) {
                Vector512<byte> a = Vector512.Create(value).AsByte();
                Vector512<int> scale = Vector512.Create(0x01010101);
                Vector512<byte> bitPosMask = Vector512Constants.MaskBitPosSerialRotate8;
                // Widen 8bit to 64bit
                (Vector512<ushort> b, _) = Vector512.Widen(a);
                (Vector512<uint> c, _) = Vector512.Widen(b);
                (Vector512<ulong> d, _) = Vector512.Widen(c);
                // Duplicate 8bit value to 64bit
                Vector512<ulong> e = Vector512.Multiply(d.AsInt32(), scale).AsUInt64(); // Duplicate 8bit value to 32bit
                Vector512<ulong> f = Vector512.BitwiseOr(e, Vector512.ShiftLeft(e, 32)); // Duplicate 32bit value to 64bit
                // Check bit.
                Vector512<byte> hit = Vector512.BitwiseAnd(f.AsByte(), bitPosMask);
                Vector512<byte> rt = Vector512.OnesComplement(Vector512.Equals(hit, Vector512<byte>.Zero));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YBitToInt16_IsAccelerated"/>
            public static bool YBitToInt16_IsAccelerated {
                get {
                    bool rt = false;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = true;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YBitToInt16(uint value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YBitToInt16_And(value);
#else
                return YBitToInt16_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YBitToInt16_Basic(uint value) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref short p = ref Unsafe.As<Vector512<short>, short>(ref rt);
                for (int i = 0; i < Vector512<short>.Count; ++i) {
                    p = (short)-((value >> i) & 1); // 1 for all bits: (short)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YBitToInt16_And(uint value) {
                Vector512<short> bitPosMask = Vector512Constants.MaskBitPosSerialRotate16;
                // Duplicate 16bit value
                Vector512<short> a = Vector512.Create((ushort)value).AsInt16();
                // Check bit.
                Vector512<short> hit = Vector512.BitwiseAnd(a, bitPosMask);
                Vector512<short> rt = Vector512.OnesComplement(Vector512.Equals(hit, Vector512<short>.Zero));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YBitToInt32_IsAccelerated"/>
            public static bool YBitToInt32_IsAccelerated {
                get {
                    bool rt = false;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = true;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YBitToInt32(uint value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YBitToInt32_And(value);
#else
                return YBitToInt32_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YBitToInt32_Basic(uint value) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref int p = ref Unsafe.As<Vector512<int>, int>(ref rt);
                for (int i = 0; i < Vector512<int>.Count; ++i) {
                    p = (int)-((value >> i) & 1); // 1 for all bits: (int)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YBitToInt32_And(uint value) {
                Vector512<int> bitPosMask = Vector512Constants.MaskBitPosSerialRotate32;
                // Duplicate 32bit value
                Vector512<int> a = Vector512.Create((uint)value).AsInt32();
                // Check bit.
                Vector512<int> hit = Vector512.BitwiseAnd(a, bitPosMask);
                Vector512<int> rt = Vector512.OnesComplement(Vector512.Equals(hit, Vector512<int>.Zero));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YBitToInt64_IsAccelerated"/>
            public static bool YBitToInt64_IsAccelerated {
                get {
                    bool rt = false;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = true;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YBitToInt64(uint value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YBitToInt64_And(value);
#else
                return YBitToInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YBitToInt64_Basic(uint value) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref long p = ref Unsafe.As<Vector512<long>, long>(ref rt);
                for (int i = 0; i < Vector512<long>.Count; ++i) {
                    p = (long)-((value >> i) & 1); // 1 for all bits: (long)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YBitToInt64_And(uint value) {
                Vector512<long> bitPosMask = Vector512Constants.MaskBitPosSerialRotate64;
                // Duplicate 64bit value
                Vector512<long> a = Vector512.Create((ulong)value).AsInt64();
                // Check bit.
                Vector512<long> hit = Vector512.BitwiseAnd(a, bitPosMask);
                Vector512<long> rt = Vector512.OnesComplement(Vector512.Equals(hit, Vector512<long>.Zero));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return Max_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{float}, Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YClamp(Vector512<float> value, Vector512<float> amin, Vector512<float> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{double}, Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YClamp(Vector512<double> value, Vector512<double> amin, Vector512<double> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YClamp(Vector512<sbyte> value, Vector512<sbyte> amin, Vector512<sbyte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YClamp(Vector512<byte> value, Vector512<byte> amin, Vector512<byte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YClamp(Vector512<short> value, Vector512<short> amin, Vector512<short> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YClamp(Vector512<ushort> value, Vector512<ushort> amin, Vector512<ushort> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YClamp(Vector512<int> value, Vector512<int> amin, Vector512<int> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YClamp(Vector512<uint> value, Vector512<uint> amin, Vector512<uint> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YClamp(Vector512<long> value, Vector512<long> amin, Vector512<long> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YClamp(Vector512<ulong> value, Vector512<ulong> amin, Vector512<ulong> amax) {
                return Min(Max(amin, value), amax);
            }


            /// <inheritdoc cref="IWVectorTraits512.YCopySign_AcceleratedTypes"/>
            public static TypeCodeFlags YCopySign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                        rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64); // & ShiftRightArithmetic_AcceleratedTypes
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YCopySign(Vector512<float> value, Vector512<float> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YCopySign(Vector512<double> value, Vector512<double> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YCopySign(Vector512<sbyte> value, Vector512<sbyte> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YCopySign(Vector512<short> value, Vector512<short> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YCopySign(Vector512<int> value, Vector512<int> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YCopySign(Vector512<long> value, Vector512<long> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YCopySign_Basic(Vector512<float> value, Vector512<float> sign) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<float> psign = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref sign);
                ref FixedArray8<float> p = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                p.I2 = MathINumber.CopySign(pvalue.I2, psign.I2);
                p.I3 = MathINumber.CopySign(pvalue.I3, psign.I3);
                p.I4 = MathINumber.CopySign(pvalue.I4, psign.I4);
                p.I5 = MathINumber.CopySign(pvalue.I5, psign.I5);
                p.I6 = MathINumber.CopySign(pvalue.I6, psign.I6);
                p.I7 = MathINumber.CopySign(pvalue.I7, psign.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YCopySign_Basic(Vector512<double> value, Vector512<double> sign) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<double> psign = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref sign);
                ref FixedArray4<double> p = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                p.I2 = MathINumber.CopySign(pvalue.I2, psign.I2);
                p.I3 = MathINumber.CopySign(pvalue.I3, psign.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YCopySign_Basic(Vector512<sbyte> value, Vector512<sbyte> sign) {
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref FixedArray32<sbyte> pvalue = ref Unsafe.As<Vector512<sbyte>, FixedArray32<sbyte>>(ref value);
                ref FixedArray32<sbyte> psign = ref Unsafe.As<Vector512<sbyte>, FixedArray32<sbyte>>(ref sign);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector512<sbyte>, FixedArray32<sbyte>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                p.I2 = MathINumber.CopySign(pvalue.I2, psign.I2);
                p.I3 = MathINumber.CopySign(pvalue.I3, psign.I3);
                p.I4 = MathINumber.CopySign(pvalue.I4, psign.I4);
                p.I5 = MathINumber.CopySign(pvalue.I5, psign.I5);
                p.I6 = MathINumber.CopySign(pvalue.I6, psign.I6);
                p.I7 = MathINumber.CopySign(pvalue.I7, psign.I7);
                p.I8 = MathINumber.CopySign(pvalue.I8, psign.I8);
                p.I9 = MathINumber.CopySign(pvalue.I9, psign.I9);
                p.I10 = MathINumber.CopySign(pvalue.I10, psign.I10);
                p.I11 = MathINumber.CopySign(pvalue.I11, psign.I11);
                p.I12 = MathINumber.CopySign(pvalue.I12, psign.I12);
                p.I13 = MathINumber.CopySign(pvalue.I13, psign.I13);
                p.I14 = MathINumber.CopySign(pvalue.I14, psign.I14);
                p.I15 = MathINumber.CopySign(pvalue.I15, psign.I15);
                p.I16 = MathINumber.CopySign(pvalue.I16, psign.I16);
                p.I17 = MathINumber.CopySign(pvalue.I17, psign.I17);
                p.I18 = MathINumber.CopySign(pvalue.I18, psign.I18);
                p.I19 = MathINumber.CopySign(pvalue.I19, psign.I19);
                p.I20 = MathINumber.CopySign(pvalue.I20, psign.I20);
                p.I21 = MathINumber.CopySign(pvalue.I21, psign.I21);
                p.I22 = MathINumber.CopySign(pvalue.I22, psign.I22);
                p.I23 = MathINumber.CopySign(pvalue.I23, psign.I23);
                p.I24 = MathINumber.CopySign(pvalue.I24, psign.I24);
                p.I25 = MathINumber.CopySign(pvalue.I25, psign.I25);
                p.I26 = MathINumber.CopySign(pvalue.I26, psign.I26);
                p.I27 = MathINumber.CopySign(pvalue.I27, psign.I27);
                p.I28 = MathINumber.CopySign(pvalue.I28, psign.I28);
                p.I29 = MathINumber.CopySign(pvalue.I29, psign.I29);
                p.I30 = MathINumber.CopySign(pvalue.I30, psign.I30);
                p.I31 = MathINumber.CopySign(pvalue.I31, psign.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YCopySign_Basic(Vector512<short> value, Vector512<short> sign) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref FixedArray16<short> pvalue = ref Unsafe.As<Vector512<short>, FixedArray16<short>>(ref value);
                ref FixedArray16<short> psign = ref Unsafe.As<Vector512<short>, FixedArray16<short>>(ref sign);
                ref FixedArray16<short> p = ref Unsafe.As<Vector512<short>, FixedArray16<short>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                p.I2 = MathINumber.CopySign(pvalue.I2, psign.I2);
                p.I3 = MathINumber.CopySign(pvalue.I3, psign.I3);
                p.I4 = MathINumber.CopySign(pvalue.I4, psign.I4);
                p.I5 = MathINumber.CopySign(pvalue.I5, psign.I5);
                p.I6 = MathINumber.CopySign(pvalue.I6, psign.I6);
                p.I7 = MathINumber.CopySign(pvalue.I7, psign.I7);
                p.I8 = MathINumber.CopySign(pvalue.I8, psign.I8);
                p.I9 = MathINumber.CopySign(pvalue.I9, psign.I9);
                p.I10 = MathINumber.CopySign(pvalue.I10, psign.I10);
                p.I11 = MathINumber.CopySign(pvalue.I11, psign.I11);
                p.I12 = MathINumber.CopySign(pvalue.I12, psign.I12);
                p.I13 = MathINumber.CopySign(pvalue.I13, psign.I13);
                p.I14 = MathINumber.CopySign(pvalue.I14, psign.I14);
                p.I15 = MathINumber.CopySign(pvalue.I15, psign.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YCopySign_Basic(Vector512<int> value, Vector512<int> sign) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref FixedArray8<int> pvalue = ref Unsafe.As<Vector512<int>, FixedArray8<int>>(ref value);
                ref FixedArray8<int> psign = ref Unsafe.As<Vector512<int>, FixedArray8<int>>(ref sign);
                ref FixedArray8<int> p = ref Unsafe.As<Vector512<int>, FixedArray8<int>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                p.I2 = MathINumber.CopySign(pvalue.I2, psign.I2);
                p.I3 = MathINumber.CopySign(pvalue.I3, psign.I3);
                p.I4 = MathINumber.CopySign(pvalue.I4, psign.I4);
                p.I5 = MathINumber.CopySign(pvalue.I5, psign.I5);
                p.I6 = MathINumber.CopySign(pvalue.I6, psign.I6);
                p.I7 = MathINumber.CopySign(pvalue.I7, psign.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YCopySign_Basic(Vector512<long> value, Vector512<long> sign) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref FixedArray4<long> pvalue = ref Unsafe.As<Vector512<long>, FixedArray4<long>>(ref value);
                ref FixedArray4<long> psign = ref Unsafe.As<Vector512<long>, FixedArray4<long>>(ref sign);
                ref FixedArray4<long> p = ref Unsafe.As<Vector512<long>, FixedArray4<long>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                p.I2 = MathINumber.CopySign(pvalue.I2, psign.I2);
                p.I3 = MathINumber.CopySign(pvalue.I3, psign.I3);
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YCopySign_Bit(Vector512<float> value, Vector512<float> sign) {
                Vector512<float> signMask = Vector512Constants.Single_SignMask;
                Vector512<float> rt = Vector512.ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YCopySign_Bit(Vector512<double> value, Vector512<double> sign) {
                Vector512<double> signMask = Vector512Constants.Double_SignMask;
                Vector512<double> rt = Vector512.ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YCopySign_Bit(Vector512<sbyte> value, Vector512<sbyte> sign) {
                Vector512<sbyte> t = Vector512.GreaterThan(Vector512<sbyte>.Zero, Vector512.Xor(value, sign));
                Vector512<sbyte> rt = Vector512.Subtract(Vector512.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YCopySign_Bit(Vector512<short> value, Vector512<short> sign) {
                Vector512<short> t = Vector512.GreaterThan(Vector512<short>.Zero, Vector512.Xor(value, sign));
                Vector512<short> rt = Vector512.Subtract(Vector512.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YCopySign_Bit(Vector512<int> value, Vector512<int> sign) {
                // Vector512<int> t = Vector512.ShiftRightArithmetic(Vector512.Xor(value, sign), 31); // Need .NET 7.
                Vector512<int> t = Vector512.GreaterThan(Vector512<int>.Zero, Vector512.Xor(value, sign));
                Vector512<int> rt = Vector512.Subtract(Vector512.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YCopySign_Bit(Vector512<long> value, Vector512<long> sign) {
                Vector512<long> t = Vector512.GreaterThan(Vector512<long>.Zero, Vector512.Xor(value, sign));
                Vector512<long> rt = Vector512.Subtract(Vector512.Xor(value, t), t);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = YIsNaN_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YMaxNumber(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YMaxNumber_Bit(left, right);
#else
                return YMaxNumber_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YMaxNumber(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YMaxNumber_Bit(left, right);
#else
                return YMaxNumber_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YMaxNumber_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref FixedArray8<float> pleft = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref left);
                ref FixedArray8<float> pright = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref right);
                ref FixedArray8<float> p = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref rt);
                p.I0 = MathINumber.MaxNumber(pleft.I0, pright.I0);
                p.I1 = MathINumber.MaxNumber(pleft.I1, pright.I1);
                p.I2 = MathINumber.MaxNumber(pleft.I2, pright.I2);
                p.I3 = MathINumber.MaxNumber(pleft.I3, pright.I3);
                p.I4 = MathINumber.MaxNumber(pleft.I4, pright.I4);
                p.I5 = MathINumber.MaxNumber(pleft.I5, pright.I5);
                p.I6 = MathINumber.MaxNumber(pleft.I6, pright.I6);
                p.I7 = MathINumber.MaxNumber(pleft.I7, pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YMaxNumber_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray4<double> pleft = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref left);
                ref FixedArray4<double> pright = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref right);
                ref FixedArray4<double> p = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref rt);
                p.I0 = MathINumber.MaxNumber(pleft.I0, pright.I0);
                p.I1 = MathINumber.MaxNumber(pleft.I1, pright.I1);
                p.I2 = MathINumber.MaxNumber(pleft.I2, pright.I2);
                p.I3 = MathINumber.MaxNumber(pleft.I3, pright.I3);
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YMaxNumber_Bit(Vector512<float> left, Vector512<float> right) {
                Vector512<float> mask = Vector512.BitwiseOr(Vector512.GreaterThan(left, right), YIsNaN(right).AsSingle());
                mask = Vector512.BitwiseOr(mask, Vector512.BitwiseAnd(Vector512.Equals(left, right), YIsNegative(right).AsSingle()));
                Vector512<float> rt = ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YMaxNumber_Bit(Vector512<double> left, Vector512<double> right) {
                Vector512<double> mask = Vector512.BitwiseOr(Vector512.GreaterThan(left, right), YIsNaN(right).AsDouble());
                mask = Vector512.BitwiseOr(mask, Vector512.BitwiseAnd(Vector512.Equals(left, right), YIsNegative(right).AsDouble()));
                Vector512<double> rt = ConditionalSelect(mask, left, right);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YMinNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMinNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = YIsNaN_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YMinNumber(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YMinNumber_Bit(left, right);
#else
                return YMinNumber_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YMinNumber(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YMinNumber_Bit(left, right);
#else
                return YMinNumber_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YMinNumber_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref FixedArray8<float> pleft = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref left);
                ref FixedArray8<float> pright = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref right);
                ref FixedArray8<float> p = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref rt);
                p.I0 = MathINumber.MinNumber(pleft.I0, pright.I0);
                p.I1 = MathINumber.MinNumber(pleft.I1, pright.I1);
                p.I2 = MathINumber.MinNumber(pleft.I2, pright.I2);
                p.I3 = MathINumber.MinNumber(pleft.I3, pright.I3);
                p.I4 = MathINumber.MinNumber(pleft.I4, pright.I4);
                p.I5 = MathINumber.MinNumber(pleft.I5, pright.I5);
                p.I6 = MathINumber.MinNumber(pleft.I6, pright.I6);
                p.I7 = MathINumber.MinNumber(pleft.I7, pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YMinNumber_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray4<double> pleft = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref left);
                ref FixedArray4<double> pright = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref right);
                ref FixedArray4<double> p = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref rt);
                p.I0 = MathINumber.MinNumber(pleft.I0, pright.I0);
                p.I1 = MathINumber.MinNumber(pleft.I1, pright.I1);
                p.I2 = MathINumber.MinNumber(pleft.I2, pright.I2);
                p.I3 = MathINumber.MinNumber(pleft.I3, pright.I3);
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YMinNumber_Bit(Vector512<float> left, Vector512<float> right) {
                Vector512<float> mask = Vector512.BitwiseOr(Vector512.LessThan(left, right), YIsNaN(right).AsSingle());
                mask = Vector512.BitwiseOr(mask, Vector512.BitwiseAnd(Vector512.Equals(left, right), YIsNegative(left).AsSingle()));
                Vector512<float> rt = ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YMinNumber_Bit(Vector512<double> left, Vector512<double> right) {
                Vector512<double> mask = Vector512.BitwiseOr(Vector512.LessThan(left, right), YIsNaN(right).AsDouble());
                mask = Vector512.BitwiseOr(mask, Vector512.BitwiseAnd(Vector512.Equals(left, right), YIsNegative(left).AsDouble()));
                Vector512<double> rt = ConditionalSelect(mask, left, right);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{short}, Vector512{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YNarrowSaturate(Vector512<short> lower, Vector512<short> upper) {
                //Vector512<short> amin = Vector512s<short>.VMinSByte;
                //Vector512<short> amax = Vector512s<short>.VMaxSByte;
                Vector512<short> amin = Vector512.Create((short)sbyte.MinValue); // .NET5+ has better performance .
                Vector512<short> amax = Vector512.Create((short)sbyte.MaxValue);
                Vector512<short> l = YClamp(lower, amin, amax);
                Vector512<short> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ushort}, Vector512{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YNarrowSaturate(Vector512<ushort> lower, Vector512<ushort> upper) {
                // Vector512<ushort> amax = Vector512s<ushort>.VMaxByte;
                Vector512<ushort> amax = Vector512.Create((ushort)byte.MaxValue); // .NET5+ has better performance .
                Vector512<ushort> l = Min(lower, amax);
                Vector512<ushort> u = Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{int}, Vector512{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YNarrowSaturate(Vector512<int> lower, Vector512<int> upper) {
                //Vector512<int> amin = Vector512s<int>.VMinInt16;
                //Vector512<int> amax = Vector512s<int>.VMaxInt16;
                Vector512<int> amin = Vector512.Create((int)short.MinValue); // .NET5+ has better performance .
                Vector512<int> amax = Vector512.Create((int)short.MaxValue);
                Vector512<int> l = YClamp(lower, amin, amax);
                Vector512<int> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{uint}, Vector512{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YNarrowSaturate(Vector512<uint> lower, Vector512<uint> upper) {
                //Vector512<uint> amax = Vector512s<uint>.VMaxUInt16;
                Vector512<uint> amax = Vector512.Create((uint)ushort.MaxValue); // .NET5+ has better performance .
                Vector512<uint> l = Min(lower, amax);
                Vector512<uint> u = Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{long}, Vector512{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YNarrowSaturate(Vector512<long> lower, Vector512<long> upper) {
                //Vector512<long> amin = Vector512s<long>.VMinInt32;
                //Vector512<long> amax = Vector512s<long>.VMaxInt32;
                Vector512<long> amin = Vector512Constants.Int64_VMinInt32;
                Vector512<long> amax = Vector512Constants.Int64_VMaxInt32;
                Vector512<long> l = YClamp(lower, amin, amax);
                Vector512<long> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ulong}, Vector512{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YNarrowSaturate(Vector512<ulong> lower, Vector512<ulong> upper) {
                //Vector512<ulong> amax = Vector512s<ulong>.VMaxUInt32;
                Vector512<ulong> amax = Vector512Constants.Int64_VMaxUInt32.AsUInt64();
                Vector512<ulong> l = Min(lower, amax);
                Vector512<ulong> u = Min(upper, amax);
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{short}, Vector512{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YNarrowSaturateUnsigned(Vector512<short> lower, Vector512<short> upper) {
                Vector512<short> amin = Vector512<short>.Zero;
                //Vector512<short> amax = Vector512s<short>.VMaxByte;
                Vector512<short> amax = Vector512.Create((short)byte.MaxValue); // .NET5+ has better performance .
                Vector512<ushort> l = YClamp(lower, amin, amax).AsUInt16();
                Vector512<ushort> u = YClamp(upper, amin, amax).AsUInt16();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{int}, Vector512{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YNarrowSaturateUnsigned(Vector512<int> lower, Vector512<int> upper) {
                Vector512<int> amin = Vector512<int>.Zero;
                //Vector512<int> amax = Vector512s<int>.VMaxUInt16;
                Vector512<int> amax = Vector512.Create((int)ushort.MaxValue); // .NET5+ has better performance .
                Vector512<uint> l = YClamp(lower, amin, amax).AsUInt32();
                Vector512<uint> u = YClamp(upper, amin, amax).AsUInt32();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{long}, Vector512{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YNarrowSaturateUnsigned(Vector512<long> lower, Vector512<long> upper) {
                Vector512<long> amin = Vector512<long>.Zero;
                //Vector512<long> amax = Vector512s<long>.VMaxUInt32;
                Vector512<long> amax = Vector512Constants.Int64_VMaxUInt32;
                Vector512<ulong> l = YClamp(lower, amin, amax).AsUInt64();
                Vector512<ulong> u = YClamp(upper, amin, amax).AsUInt64();
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits512.YOrNot_AcceleratedTypes"/>
            public static TypeCodeFlags YOrNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YOrNot{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YOrNot<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YOrNot_Or(left, right);
#else
                return YOrNot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YOrNot{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YOrNot_Basic<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector512<T> rt);
                ref FixedArray4<ulong> p = ref Unsafe.As<Vector512<T>, FixedArray4<ulong>>(ref rt);
                ref FixedArray4<ulong> pleft = ref Unsafe.As<Vector512<T>, FixedArray4<ulong>>(ref left);
                ref FixedArray4<ulong> pright = ref Unsafe.As<Vector512<T>, FixedArray4<ulong>>(ref right);
                p.I0 = pleft.I0 | ~pright.I0;
                p.I1 = pleft.I1 | ~pright.I1;
                p.I2 = pleft.I2 | ~pright.I2;
                p.I3 = pleft.I3 | ~pright.I3;
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YOrNot{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YOrNot_Or<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                Vector512<T> right2 = Vector512.OnesComplement(right);
                Vector512<T> rt = Vector512.BitwiseOr(left, right2);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YRoundToEven(Vector512<float> value) {
#if VECTOR_HAS_METHOD
                return YRoundToEven_Add(value);
#else
                return YRoundToEven_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YRoundToEven(Vector512<double> value) {
#if VECTOR_HAS_METHOD
                return YRoundToEven_Add(value);
#else
                return YRoundToEven_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YRoundToEven_Basic(Vector512<float> value) {
                Vector512<float> rt = value;
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref rt);
                p = MathF.Round(p);
                Unsafe.Add(ref p, 1) = MathF.Round(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Round(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Round(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = MathF.Round(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = MathF.Round(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = MathF.Round(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = MathF.Round(Unsafe.Add(ref p, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YRoundToEven_Basic(Vector512<double> value) {
                Vector512<double> rt = value;
                ref double p = ref Unsafe.As<Vector512<double>, double>(ref rt);
                p = Math.Round(p);
                Unsafe.Add(ref p, 1) = Math.Round(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Round(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Round(Unsafe.Add(ref p, 3));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YRoundToEven_Add(Vector512<float> value) {
                // [Single type] If (0<=x && x<pow(2,23)), `round_to_even(x) = x + pow(2,23) - pow(2,23)`. Next generalize this approach to all number ranges.
                Vector512<float> delta = Vector512.Create(ScalarConstants.SingleVal_2Pow23);
                Vector512<float> signMask = Vector512Constants.Single_SignMask;
                Vector512<float> valueAbs = Vector512.AndNot(value, signMask);
                Vector512<float> signData = Vector512.BitwiseAnd(value, signMask);
                Vector512<float> allowMask = Vector512.LessThan(valueAbs, delta); // Allow is `(value[i] < pow(2,23) )`.
                delta = Vector512.BitwiseOr(delta, signData);
                delta = Vector512.BitwiseAnd(delta, allowMask);
                Vector512<float> rt = Vector512.Add(value, delta);
                rt = Vector512.Subtract(rt, delta);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YRoundToEven_Add(Vector512<double> value) {
                // [Double type] If (0<=x && x<pow(2,52)), `round_to_even(x) = x + pow(2,52) - pow(2,52)`. Next generalize this approach to all number ranges.
                Vector512<double> delta = Vector512.Create(ScalarConstants.DoubleVal_2Pow52);
                Vector512<double> signMask = Vector512Constants.Double_SignMask;
                Vector512<double> valueAbs = Vector512.AndNot(value, signMask);
                Vector512<double> signData = Vector512.BitwiseAnd(value, signMask);
                Vector512<double> allowMask = Vector512.LessThan(valueAbs, delta); // Allow is `(value[i] < pow(2,52) )`.
                delta = Vector512.BitwiseOr(delta, signData);
                delta = Vector512.BitwiseAnd(delta, allowMask);
                Vector512<double> rt = Vector512.Add(value, delta);
                rt = Vector512.Subtract(rt, delta);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YRoundToZero(Vector512<float> value) {
#if VECTOR_HAS_METHOD
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YRoundToZero(Vector512<double> value) {
#if VECTOR_HAS_METHOD
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YRoundToZero_Basic(Vector512<float> value) {
                Vector512<float> rt = value;
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref rt);
                p = MathF.Truncate(p);
                Unsafe.Add(ref p, 1) = MathF.Truncate(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Truncate(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Truncate(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = MathF.Truncate(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = MathF.Truncate(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = MathF.Truncate(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = MathF.Truncate(Unsafe.Add(ref p, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YRoundToZero_Basic(Vector512<double> value) {
                Vector512<double> rt = value;
                ref double p = ref Unsafe.As<Vector512<double>, double>(ref rt);
                p = Math.Truncate(p);
                Unsafe.Add(ref p, 1) = Math.Truncate(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Truncate(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Truncate(Unsafe.Add(ref p, 3));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YRoundToZero_Floor(Vector512<float> value) {
                Vector512<float> signMask = Vector512Constants.Single_SignMask;
                Vector512<float> valueAbs = Vector512.AndNot(value, signMask);
                Vector512<float> signData = Vector512.BitwiseAnd(value, signMask);
                Vector512<float> rt = Vector512.Floor(valueAbs);
                rt = Vector512.BitwiseOr(rt, signData);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YRoundToZero_Floor(Vector512<double> value) {
                Vector512<double> signMask = Vector512Constants.Double_SignMask;
                Vector512<double> valueAbs = Vector512.AndNot(value, signMask);
                Vector512<double> signData = Vector512.BitwiseAnd(value, signMask);
                Vector512<double> rt = Vector512.Floor(valueAbs);
                rt = Vector512.BitwiseOr(rt, signData);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


#endif // NET8_0_OR_GREATER
        }
    }
}
