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

namespace Zyl.VectorTraits.Impl.AVector128 {

    partial class WVectorTraits128Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YBitToByte_IsAccelerated"/>
            public static bool YBitToByte_IsAccelerated {
                get {
                    bool rt = false;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt = true;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YBitToByte(uint value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YBitToByte_Widen(value);
#else
                return YBitToByte_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YBitToByte_Basic(uint value) {
                UnsafeUtil.SkipInit(out Vector128<byte> rt);
                ref sbyte p = ref Unsafe.As<Vector128<byte>, sbyte>(ref rt);
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    p = (sbyte)-((value >> i) & 1); // 1 for all bits: (sbyte)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YBitToByte_Widen(uint value) {
                Vector128<byte> a = Vector128.Create(value).AsByte();
                Vector128<int> scale = Vector128.Create(0x01010101);
                Vector128<byte> bitPosMask = Vector128Constants.MaskBitPosSerialRotate8;
                // Widen 8bit to 64bit
                (Vector128<ushort> b, _) = Vector128.Widen(a);
                (Vector128<uint> c, _) = Vector128.Widen(b);
                (Vector128<ulong> d, _) = Vector128.Widen(c);
                //Console.WriteLine(VectorTextUtil.Format("d':\t{0}", d));
                // Duplicate 8bit value to 64bit
                Vector128<ulong> e = Vector128.Multiply(d.AsInt32(), scale).AsUInt64(); // Duplicate 8bit value to 32bit
                Vector128<ulong> f = Vector128.BitwiseOr(e, Vector128.ShiftLeft(e, 32)); // Duplicate 32bit value to 64bit
                //Console.WriteLine(VectorTextUtil.Format("f':\t{0}", f));
                // Check bit.
                Vector128<byte> hit = Vector128.BitwiseAnd(f.AsByte(), bitPosMask);
                Vector128<byte> rt = Vector128.OnesComplement(Vector128.Equals(hit, Vector128<byte>.Zero));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YBitToInt16_IsAccelerated"/>
            public static bool YBitToInt16_IsAccelerated {
                get {
                    bool rt = false;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt = true;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YBitToInt16(uint value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YBitToInt16_And(value);
#else
                return YBitToInt16_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YBitToInt16_Basic(uint value) {
                UnsafeUtil.SkipInit(out Vector128<short> rt);
                ref short p = ref Unsafe.As<Vector128<short>, short>(ref rt);
                for (int i = 0; i < Vector128<short>.Count; ++i) {
                    p = (short)-((value >> i) & 1); // 1 for all bits: (short)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YBitToInt16_And(uint value) {
                Vector128<short> bitPosMask = Vector128Constants.MaskBitPosSerialRotate16;
                // Duplicate 16bit value
                Vector128<short> a = Vector128.Create((ushort)value).AsInt16();
                // Check bit.
                Vector128<short> hit = Vector128.BitwiseAnd(a, bitPosMask);
                Vector128<short> rt = Vector128.OnesComplement(Vector128.Equals(hit, Vector128<short>.Zero));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YBitToInt32_IsAccelerated"/>
            public static bool YBitToInt32_IsAccelerated {
                get {
                    bool rt = false;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt = true;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YBitToInt32(uint value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YBitToInt32_And(value);
#else
                return YBitToInt32_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YBitToInt32_Basic(uint value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref rt);
                for (int i = 0; i < Vector128<int>.Count; ++i) {
                    p = (int)-((value >> i) & 1); // 1 for all bits: (int)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YBitToInt32_And(uint value) {
                Vector128<int> bitPosMask = Vector128Constants.MaskBitPosSerialRotate32;
                // Duplicate 32bit value
                Vector128<int> a = Vector128.Create((uint)value).AsInt32();
                // Check bit.
                Vector128<int> hit = Vector128.BitwiseAnd(a, bitPosMask);
                Vector128<int> rt = Vector128.OnesComplement(Vector128.Equals(hit, Vector128<int>.Zero));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YBitToInt64_IsAccelerated"/>
            public static bool YBitToInt64_IsAccelerated {
                get {
                    bool rt = false;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt = true;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YBitToInt64(uint value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YBitToInt64_And(value);
#else
                return YBitToInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YBitToInt64_Basic(uint value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref long p = ref Unsafe.As<Vector128<long>, long>(ref rt);
                for (int i = 0; i < Vector128<long>.Count; ++i) {
                    p = (long)-((value >> i) & 1); // 1 for all bits: (long)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YBitToInt64_And(uint value) {
                Vector128<long> bitPosMask = Vector128Constants.MaskBitPosSerialRotate64;
                // Duplicate 64bit value
                Vector128<long> a = Vector128.Create((ulong)value).AsInt64();
                // Check bit.
                Vector128<long> hit = Vector128.BitwiseAnd(a, bitPosMask);
                Vector128<long> rt = Vector128.OnesComplement(Vector128.Equals(hit, Vector128<long>.Zero));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return Max_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YClamp(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YClamp(Vector128<sbyte> value, Vector128<sbyte> amin, Vector128<sbyte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YClamp(Vector128<byte> value, Vector128<byte> amin, Vector128<byte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YClamp(Vector128<short> value, Vector128<short> amin, Vector128<short> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YClamp(Vector128<ushort> value, Vector128<ushort> amin, Vector128<ushort> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YClamp(Vector128<int> value, Vector128<int> amin, Vector128<int> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YClamp(Vector128<uint> value, Vector128<uint> amin, Vector128<uint> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
                return Min(Max(amin, value), amax);
            }


            /// <inheritdoc cref="IWVectorTraits128.YCopySign_AcceleratedTypes"/>
            public static TypeCodeFlags YCopySign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                        rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64); // & ShiftRightArithmetic_AcceleratedTypes
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YCopySign(Vector128<float> value, Vector128<float> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YCopySign(Vector128<double> value, Vector128<double> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YCopySign(Vector128<sbyte> value, Vector128<sbyte> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YCopySign(Vector128<short> value, Vector128<short> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YCopySign(Vector128<int> value, Vector128<int> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YCopySign(Vector128<long> value, Vector128<long> sign) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YCopySign_Basic(Vector128<float> value, Vector128<float> sign) {
                UnsafeUtil.SkipInit(out Vector128<float> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<float> psign = ref Unsafe.As<Vector128<float>, FixedArray8<float>>(ref sign);
                ref FixedArray8<float> p = ref Unsafe.As<Vector128<float>, FixedArray8<float>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                p.I2 = MathINumber.CopySign(pvalue.I2, psign.I2);
                p.I3 = MathINumber.CopySign(pvalue.I3, psign.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YCopySign_Basic(Vector128<double> value, Vector128<double> sign) {
                UnsafeUtil.SkipInit(out Vector128<double> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<double> psign = ref Unsafe.As<Vector128<double>, FixedArray4<double>>(ref sign);
                ref FixedArray4<double> p = ref Unsafe.As<Vector128<double>, FixedArray4<double>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YCopySign_Basic(Vector128<sbyte> value, Vector128<sbyte> sign) {
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray32<sbyte> pvalue = ref Unsafe.As<Vector128<sbyte>, FixedArray32<sbyte>>(ref value);
                ref FixedArray32<sbyte> psign = ref Unsafe.As<Vector128<sbyte>, FixedArray32<sbyte>>(ref sign);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray32<sbyte>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YCopySign_Basic(Vector128<short> value, Vector128<short> sign) {
                UnsafeUtil.SkipInit(out Vector128<short> rt);
                ref FixedArray16<short> pvalue = ref Unsafe.As<Vector128<short>, FixedArray16<short>>(ref value);
                ref FixedArray16<short> psign = ref Unsafe.As<Vector128<short>, FixedArray16<short>>(ref sign);
                ref FixedArray16<short> p = ref Unsafe.As<Vector128<short>, FixedArray16<short>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YCopySign_Basic(Vector128<int> value, Vector128<int> sign) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray8<int> pvalue = ref Unsafe.As<Vector128<int>, FixedArray8<int>>(ref value);
                ref FixedArray8<int> psign = ref Unsafe.As<Vector128<int>, FixedArray8<int>>(ref sign);
                ref FixedArray8<int> p = ref Unsafe.As<Vector128<int>, FixedArray8<int>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                p.I2 = MathINumber.CopySign(pvalue.I2, psign.I2);
                p.I3 = MathINumber.CopySign(pvalue.I3, psign.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YCopySign_Basic(Vector128<long> value, Vector128<long> sign) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray4<long> pvalue = ref Unsafe.As<Vector128<long>, FixedArray4<long>>(ref value);
                ref FixedArray4<long> psign = ref Unsafe.As<Vector128<long>, FixedArray4<long>>(ref sign);
                ref FixedArray4<long> p = ref Unsafe.As<Vector128<long>, FixedArray4<long>>(ref rt);
                p.I0 = MathINumber.CopySign(pvalue.I0, psign.I0);
                p.I1 = MathINumber.CopySign(pvalue.I1, psign.I1);
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YCopySign_Bit(Vector128<float> value, Vector128<float> sign) {
                Vector128<float> signMask = Vector128Constants.Single_SignMask;
                Vector128<float> rt = Vector128.ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YCopySign_Bit(Vector128<double> value, Vector128<double> sign) {
                Vector128<double> signMask = Vector128Constants.Double_SignMask;
                Vector128<double> rt = Vector128.ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YCopySign_Bit(Vector128<sbyte> value, Vector128<sbyte> sign) {
                Vector128<sbyte> t = Vector128.GreaterThan(Vector128<sbyte>.Zero, Vector128.Xor(value, sign));
                Vector128<sbyte> rt = Vector128.Subtract(Vector128.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YCopySign_Bit(Vector128<short> value, Vector128<short> sign) {
                Vector128<short> t = Vector128.GreaterThan(Vector128<short>.Zero, Vector128.Xor(value, sign));
                Vector128<short> rt = Vector128.Subtract(Vector128.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YCopySign_Bit(Vector128<int> value, Vector128<int> sign) {
                // Vector128<int> t = Vector128.ShiftRightArithmetic(Vector128.Xor(value, sign), 31); // Need .NET 7.
                Vector128<int> t = Vector128.GreaterThan(Vector128<int>.Zero, Vector128.Xor(value, sign));
                Vector128<int> rt = Vector128.Subtract(Vector128.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YCopySign_Bit(Vector128<long> value, Vector128<long> sign) {
                Vector128<long> t = Vector128.GreaterThan(Vector128<long>.Zero, Vector128.Xor(value, sign));
                Vector128<long> rt = Vector128.Subtract(Vector128.Xor(value, t), t);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{short}, Vector128{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper) {
                //Vector128<short> amin = Vector128s<short>.VMinSByte;
                //Vector128<short> amax = Vector128s<short>.VMaxSByte;
                Vector128<short> amin = Vector128.Create((short)sbyte.MinValue); // .NET5+ has better performance .
                Vector128<short> amax = Vector128.Create((short)sbyte.MaxValue);
                Vector128<short> l = YClamp(lower, amin, amax);
                Vector128<short> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ushort}, Vector128{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper) {
                // Vector128<ushort> amax = Vector128s<ushort>.VMaxByte;
                Vector128<ushort> amax = Vector128.Create((ushort)byte.MaxValue); // .NET5+ has better performance .
                Vector128<ushort> l = Min(lower, amax);
                Vector128<ushort> u = Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{int}, Vector128{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper) {
                //Vector128<int> amin = Vector128s<int>.VMinInt16;
                //Vector128<int> amax = Vector128s<int>.VMaxInt16;
                Vector128<int> amin = Vector128.Create((int)short.MinValue); // .NET5+ has better performance .
                Vector128<int> amax = Vector128.Create((int)short.MaxValue);
                Vector128<int> l = YClamp(lower, amin, amax);
                Vector128<int> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{uint}, Vector128{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper) {
                //Vector128<uint> amax = Vector128s<uint>.VMaxUInt16;
                Vector128<uint> amax = Vector128.Create((uint)ushort.MaxValue); // .NET5+ has better performance .
                Vector128<uint> l = Min(lower, amax);
                Vector128<uint> u = Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{long}, Vector128{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper) {
                //Vector128<long> amin = Vector128s<long>.VMinInt32;
                //Vector128<long> amax = Vector128s<long>.VMaxInt32;
                Vector128<long> amin = Vector128Constants.Int64_VMinInt32;
                Vector128<long> amax = Vector128Constants.Int64_VMaxInt32;
                Vector128<long> l = YClamp(lower, amin, amax);
                Vector128<long> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ulong}, Vector128{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper) {
                //Vector128<ulong> amax = Vector128s<ulong>.VMaxUInt32;
                Vector128<ulong> amax = Vector128Constants.Int64_VMaxUInt32.AsUInt64();
                Vector128<ulong> l = Min(lower, amax);
                Vector128<ulong> u = Min(upper, amax);
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper) {
                Vector128<short> amin = Vector128<short>.Zero;
                //Vector128<short> amax = Vector128s<short>.VMaxByte;
                Vector128<short> amax = Vector128.Create((short)byte.MaxValue); // .NET5+ has better performance .
                Vector128<ushort> l = YClamp(lower, amin, amax).AsUInt16();
                Vector128<ushort> u = YClamp(upper, amin, amax).AsUInt16();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{int}, Vector128{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper) {
                Vector128<int> amin = Vector128<int>.Zero;
                //Vector128<int> amax = Vector128s<int>.VMaxUInt16;
                Vector128<int> amax = Vector128.Create((int)ushort.MaxValue); // .NET5+ has better performance .
                Vector128<uint> l = YClamp(lower, amin, amax).AsUInt32();
                Vector128<uint> u = YClamp(upper, amin, amax).AsUInt32();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{long}, Vector128{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper) {
                Vector128<long> amin = Vector128<long>.Zero;
                //Vector128<long> amax = Vector128s<long>.VMaxUInt32;
                Vector128<long> amax = Vector128Constants.Int64_VMaxUInt32; // .NET5+ has better performance .
                Vector128<ulong> l = YClamp(lower, amin, amax).AsUInt64();
                Vector128<ulong> u = YClamp(upper, amin, amax).AsUInt64();
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits128.YOrNot_AcceleratedTypes"/>
            public static TypeCodeFlags YOrNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YOrNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> YOrNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YOrNot_Or(left, right);
#else
                return YOrNot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YOrNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> YOrNot_Basic<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector128<T> rt);
                ref FixedArray2<ulong> p = ref Unsafe.As<Vector128<T>, FixedArray2<ulong>>(ref rt);
                ref FixedArray2<ulong> pleft = ref Unsafe.As<Vector128<T>, FixedArray2<ulong>>(ref left);
                ref FixedArray2<ulong> pright = ref Unsafe.As<Vector128<T>, FixedArray2<ulong>>(ref right);
                p.I0 = pleft.I0 | ~pright.I0;
                p.I1 = pleft.I1 | ~pright.I1;
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YOrNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> YOrNot_Or<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                Vector128<T> right2 = Vector128.OnesComplement(right);
                Vector128<T> rt = Vector128.BitwiseOr(left, right2);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToEven(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YRoundToEven_Add(value);
#else
                return YRoundToEven_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToEven(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YRoundToEven_Add(value);
#else
                return YRoundToEven_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToEven_Basic(Vector128<float> value) {
                Vector128<float> rt = value;
                ref float p = ref Unsafe.As<Vector128<float>, float>(ref rt);
                p = MathF.Round(p);
                Unsafe.Add(ref p, 1) = MathF.Round(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Round(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Round(Unsafe.Add(ref p, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToEven_Basic(Vector128<double> value) {
                Vector128<double> rt = value;
                ref double p = ref Unsafe.As<Vector128<double>, double>(ref rt);
                p = Math.Round(p);
                Unsafe.Add(ref p, 1) = Math.Round(Unsafe.Add(ref p, 1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToEven_Add(Vector128<float> value) {
                // [Single type] If (0<=x && x<pow(2,23)), `round_to_even(x) = x + pow(2,23) - pow(2,23)`. Next generalize this approach to all number ranges.
                Vector128<float> delta = Vector128.Create(ScalarConstants.SingleVal_2Pow23);
                Vector128<float> signMask = Vector128Constants.Single_SignMask;
                Vector128<float> valueAbs = Vector128.AndNot(value, signMask);
                Vector128<float> signData = Vector128.BitwiseAnd(value, signMask);
                Vector128<float> allowMask = Vector128.LessThan(valueAbs, delta); // Allow is `(value[i] < pow(2,23) )`.
                delta = Vector128.BitwiseOr(delta, signData);
                delta = Vector128.BitwiseAnd(delta, allowMask);
                Vector128<float> rt = Vector128.Add(value, delta);
                rt = Vector128.Subtract(rt, delta);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToEven_Add(Vector128<double> value) {
                // [Double type] If (0<=x && x<pow(2,52)), `round_to_even(x) = x + pow(2,52) - pow(2,52)`. Next generalize this approach to all number ranges.
                Vector128<double> delta = Vector128.Create(ScalarConstants.DoubleVal_2Pow52);
                Vector128<double> signMask = Vector128Constants.Double_SignMask;
                Vector128<double> valueAbs = Vector128.AndNot(value, signMask);
                Vector128<double> signData = Vector128.BitwiseAnd(value, signMask);
                Vector128<double> allowMask = Vector128.LessThan(valueAbs, delta); // Allow is `(value[i] < pow(2,52) )`.
                delta = Vector128.BitwiseOr(delta, signData);
                delta = Vector128.BitwiseAnd(delta, allowMask);
                Vector128<double> rt = Vector128.Add(value, delta);
                rt = Vector128.Subtract(rt, delta);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToZero(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToZero(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToZero_Basic(Vector128<float> value) {
                Vector128<float> rt = value;
                ref float p = ref Unsafe.As<Vector128<float>, float>(ref rt);
                p = MathF.Truncate(p);
                Unsafe.Add(ref p, 1) = MathF.Truncate(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Truncate(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Truncate(Unsafe.Add(ref p, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToZero_Basic(Vector128<double> value) {
                Vector128<double> rt = value;
                ref double p = ref Unsafe.As<Vector128<double>, double>(ref rt);
                p = Math.Truncate(p);
                Unsafe.Add(ref p, 1) = Math.Truncate(Unsafe.Add(ref p, 1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToZero_Floor(Vector128<float> value) {
                Vector128<float> signMask = Vector128Constants.Single_SignMask;
                Vector128<float> valueAbs = Vector128.AndNot(value, signMask);
                Vector128<float> signData = Vector128.BitwiseAnd(value, signMask);
                Vector128<float> rt = Vector128.Floor(valueAbs);
                rt = Vector128.BitwiseOr(rt, signData);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToZero_Floor(Vector128<double> value) {
                Vector128<double> signMask = Vector128Constants.Double_SignMask;
                Vector128<double> valueAbs = Vector128.AndNot(value, signMask);
                Vector128<double> signData = Vector128.BitwiseAnd(value, signMask);
                Vector128<double> rt = Vector128.Floor(valueAbs);
                rt = Vector128.BitwiseOr(rt, signData);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
