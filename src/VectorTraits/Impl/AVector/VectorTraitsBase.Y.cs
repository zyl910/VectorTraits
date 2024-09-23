#define VECTOR_HAS_METHOD

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl.AVector {

    partial class VectorTraitsBase {

        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YBitToByte_IsAccelerated"/>
            public static bool YBitToByte_IsAccelerated {
                get {
                    bool rt = false;
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                    if (Vector.IsHardwareAccelerated) {
                        rt = true;
                    }
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YBitToByte(ulong value) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return YBitToByte_Widen(value);
#else
                return YBitToByte_WidenScalar(value);
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YBitToByte_Basic(ulong value) {
                UnsafeUtil.SkipInit(out Vector<byte> rt);
                ref sbyte p = ref Unsafe.As<Vector<byte>, sbyte>(ref rt);
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    p = (sbyte)-(long)((value >> i) & 1); // 1 for all bits: (sbyte)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if NET7_0_OR_GREATER // ShiftLeft need .NET7
            /// <inheritdoc cref="IVectorTraits.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YBitToByte_Widen(ulong value) {
                if (!BitConverter.IsLittleEndian) {
                    value = MathBinaryPrimitives.ReverseEndianness(value);
                }
                Vector<byte> a = new Vector<ulong>(value).AsByte();
                Vector<int> scale = new Vector<int>(0x01010101);
                Vector<byte> bitPosMask = Vectors<byte>.MaskBitPosSerialRotate;
                // Widen 8bit to 64bit
                Vector.Widen(a, out Vector<ushort> b, out _);
                Vector.Widen(b, out Vector<uint> c, out _);
                Vector.Widen(c, out Vector<ulong> d, out _);
                // Duplicate 8bit value to 64bit
                Vector<ulong> e = Vector.Multiply(d.AsInt32(), scale).AsUInt64(); // Duplicate 8bit value to 32bit
                Vector<ulong> f = Vector.BitwiseOr(e, Vector.ShiftLeft(e, 32)); // Duplicate 32bit value to 64bit
                // Check bit.
                Vector<byte> hit = Vector.BitwiseAnd(f.AsByte(), bitPosMask);
                Vector<byte> rt = Vector.Equals(hit, bitPosMask);
                return rt;
            }
#endif // NET7_0_OR_GREATER

            /// <inheritdoc cref="IVectorTraits.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YBitToByte_WidenScalar(ulong value) {
                Vector<byte> bitPosMask = Vectors<byte>.MaskBitPosSerialRotate;
                // Widen 8bit to 64bit with duplicate
                UnsafeUtil.SkipInit(out Vector<ulong> f);
                ulong m = value;
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref f);
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    ulong temp = (m & 0xFFU) * 0x0101010101010101UL;
                    p = temp;
                    p = ref Unsafe.Add(ref p, 1);
                    m >>= 8;
                }
                // Check bit.
                Vector<byte> hit = Vector.BitwiseAnd(f.AsByte(), bitPosMask);
                Vector<byte> rt = Vector.Equals(hit, bitPosMask);
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.YBitToInt16_IsAccelerated"/>
            public static bool YBitToInt16_IsAccelerated {
                get {
                    bool rt = false;
                    if (Vector.IsHardwareAccelerated) {
                        rt = true;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YBitToInt16(ulong value) {
                return YBitToInt16_And(value);
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YBitToInt16_Basic(ulong value) {
                UnsafeUtil.SkipInit(out Vector<short> rt);
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                for (int i = 0; i < Vector<short>.Count; ++i) {
                    p = (short)-(long)((value >> i) & 1); // 1 for all bits: (short)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YBitToInt16_And(ulong value) {
#if NET8_0_OR_GREATER
                if (Vector<byte>.Count >= BitOfByte.Bit512) {
                    return YBitToInt16_Basic(value);
                }
#endif // NET8_0_OR_GREATER
                Vector<short> bitPosMask = Vectors<short>.MaskBitPosSerialRotate;
                // Duplicate 16bit value
                Vector<short> a = new Vector<ushort>((ushort)value).AsInt16();
                // Check bit.
                Vector<short> hit = Vector.BitwiseAnd(a, bitPosMask);
                Vector<short> rt = Vector.OnesComplement(Vector.Equals(hit, Vector<short>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.YBitToInt32_IsAccelerated"/>
            public static bool YBitToInt32_IsAccelerated {
                get {
                    bool rt = false;
                    if (Vector.IsHardwareAccelerated) {
                        rt = true;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YBitToInt32(ulong value) {
                return YBitToInt32_And(value);
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YBitToInt32_Basic(ulong value) {
                UnsafeUtil.SkipInit(out Vector<int> rt);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                for (int i = 0; i < Vector<int>.Count; ++i) {
                    p = (int)-(long)((value >> i) & 1); // 1 for all bits: (int)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YBitToInt32_And(ulong value) {
                Vector<int> bitPosMask = Vectors<int>.MaskBitPosSerialRotate;
                // Duplicate 32bit value
                Vector<int> a = new Vector<uint>((uint)value).AsInt32();
                // Check bit.
                Vector<int> hit = Vector.BitwiseAnd(a, bitPosMask);
                Vector<int> rt = Vector.Equals(hit, bitPosMask);
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.YBitToInt64_IsAccelerated"/>
            public static bool YBitToInt64_IsAccelerated {
                get {
                    bool rt = false;
                    if (Vector.IsHardwareAccelerated) {
                        rt = true;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YBitToInt64(ulong value) {
                return YBitToInt64_And(value);
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YBitToInt64_Basic(ulong value) {
                UnsafeUtil.SkipInit(out Vector<long> rt);
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                for (int i = 0; i < Vector<long>.Count; ++i) {
                    p = -(long)((value >> i) & 1); // 1 for all bits: (long)-1
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YBitToInt64_And(ulong value) {
                Vector<long> bitPosMask = Vectors<long>.MaskBitPosSerialRotate;
                // Duplicate 64bit value
                Vector<long> a = new Vector<ulong>((ulong)value).AsInt64();
                // Check bit.
                Vector<long> hit = Vector.BitwiseAnd(a, bitPosMask);
                Vector<long> rt = Vector.Equals(hit, bitPosMask);
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


            /// <inheritdoc cref="IVectorTraits.YCopySign_AcceleratedTypes"/>
            public static TypeCodeFlags YCopySign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                        rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64); // & ShiftRightArithmetic_AcceleratedTypes
                    }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YCopySign(Vector<float> value, Vector<float> sign) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YCopySign(Vector<double> value, Vector<double> sign) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YCopySign(Vector<sbyte> value, Vector<sbyte> sign) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YCopySign(Vector<short> value, Vector<short> sign) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YCopySign(Vector<int> value, Vector<int> sign) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YCopySign(Vector<long> value, Vector<long> sign) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YCopySign_Bit(value, sign);
#else
                return YCopySign_Basic(value, sign);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YCopySign_Basic(Vector<float> value, Vector<float> sign) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                ref float psign = ref Unsafe.As<Vector<float>, float>(ref sign);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathINumber.CopySign(p, psign);
                    p = ref Unsafe.Add(ref p, 1);
                    psign = ref Unsafe.Add(ref psign, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YCopySign_Basic(Vector<double> value, Vector<double> sign) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                ref double psign = ref Unsafe.As<Vector<double>, double>(ref sign);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathINumber.CopySign(p, psign);
                    p = ref Unsafe.Add(ref p, 1);
                    psign = ref Unsafe.Add(ref psign, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YCopySign_Basic(Vector<sbyte> value, Vector<sbyte> sign) {
                Vector<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                ref sbyte psign = ref Unsafe.As<Vector<sbyte>, sbyte>(ref sign);
                for (nint i = 0; i < Vector<sbyte>.Count; ++i) {
                    p = MathINumber.CopySign(p, psign);
                    p = ref Unsafe.Add(ref p, 1);
                    psign = ref Unsafe.Add(ref psign, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YCopySign_Basic(Vector<short> value, Vector<short> sign) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                ref short psign = ref Unsafe.As<Vector<short>, short>(ref sign);
                for (nint i = 0; i < Vector<short>.Count; ++i) {
                    p = MathINumber.CopySign(p, psign);
                    p = ref Unsafe.Add(ref p, 1);
                    psign = ref Unsafe.Add(ref psign, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YCopySign_Basic(Vector<int> value, Vector<int> sign) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                ref int psign = ref Unsafe.As<Vector<int>, int>(ref sign);
                for (nint i = 0; i < Vector<int>.Count; ++i) {
                    p = MathINumber.CopySign(p, psign);
                    p = ref Unsafe.Add(ref p, 1);
                    psign = ref Unsafe.Add(ref psign, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YCopySign_Basic(Vector<long> value, Vector<long> sign) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                ref long psign = ref Unsafe.As<Vector<long>, long>(ref sign);
                for (nint i = 0; i < Vector<long>.Count; ++i) {
                    p = MathINumber.CopySign(p, psign);
                    p = ref Unsafe.Add(ref p, 1);
                    psign = ref Unsafe.Add(ref psign, 1);
                }
                return rt;
            }

#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YCopySign_Bit(Vector<float> value, Vector<float> sign) {
                Vector<float> signMask = VectorConstants.Single_SignMask;
                Vector<float> rt = Vector.ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YCopySign_Bit(Vector<double> value, Vector<double> sign) {
                Vector<double> signMask = VectorConstants.Double_SignMask;
                Vector<double> rt = Vector.ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YCopySign_Bit(Vector<sbyte> value, Vector<sbyte> sign) {
                Vector<sbyte> t = Vector.GreaterThan(Vector<sbyte>.Zero, Vector.Xor(value, sign));
                Vector<sbyte> rt = Vector.Subtract(Vector.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YCopySign_Bit(Vector<short> value, Vector<short> sign) {
                Vector<short> t = Vector.GreaterThan(Vector<short>.Zero, Vector.Xor(value, sign));
                Vector<short> rt = Vector.Subtract(Vector.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YCopySign_Bit(Vector<int> value, Vector<int> sign) {
                // Vector<int> t = Vector.ShiftRightArithmetic(Vector.Xor(value, sign), 31); // Need .NET 7.
                Vector<int> t = Vector.GreaterThan(Vector<int>.Zero, Vector.Xor(value, sign));
                Vector<int> rt = Vector.Subtract(Vector.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YCopySign_Bit(Vector<long> value, Vector<long> sign) {
                Vector<long> t = Vector.GreaterThan(Vector<long>.Zero, Vector.Xor(value, sign));
                Vector<long> rt = Vector.Subtract(Vector.Xor(value, t), t);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YMaxNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt = YIsNaN_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YMaxNumber(Vector<float> left, Vector<float> right) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YMaxNumber_Bit(left, right);
#else
                return YMaxNumber_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMaxNumber(Vector<double> left, Vector<double> right) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YMaxNumber_Bit(left, right);
#else
                return YMaxNumber_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YMaxNumber_Basic(Vector<float> left, Vector<float> right) {
                Vector<float> rt = left;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                ref float pright = ref Unsafe.As<Vector<float>, float>(ref right);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathINumber.MaxNumber(p, pright);
                    p = ref Unsafe.Add(ref p, 1);
                    pright = ref Unsafe.Add(ref pright, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMaxNumber_Basic(Vector<double> left, Vector<double> right) {
                Vector<double> rt = left;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                ref double pright = ref Unsafe.As<Vector<double>, double>(ref right);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathINumber.MaxNumber(p, pright);
                    p = ref Unsafe.Add(ref p, 1);
                    pright = ref Unsafe.Add(ref pright, 1);
                }
                return rt;
            }

#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YMaxNumber_Bit(Vector<float> left, Vector<float> right) {
                Vector<int> mask = Vector.BitwiseOr(Vector.GreaterThan(left, right), YIsNaN(right));
                mask = Vector.BitwiseOr(mask, Vector.BitwiseAnd(Vector.Equals(left, right), YIsNegative(right)));
                Vector<float> rt = Vector.ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMaxNumber_Bit(Vector<double> left, Vector<double> right) {
                Vector<long> mask = Vector.BitwiseOr(Vector.GreaterThan(left, right), YIsNaN(right));
                mask = Vector.BitwiseOr(mask, Vector.BitwiseAnd(Vector.Equals(left, right), YIsNegative(right)));
                Vector<double> rt = Vector.ConditionalSelect(mask, left, right);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YMinNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMinNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt = YIsNaN_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YMinNumber(Vector<float> left, Vector<float> right) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YMinNumber_Bit(left, right);
#else
                return YMinNumber_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMinNumber(Vector<double> left, Vector<double> right) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YMinNumber_Bit(left, right);
#else
                return YMinNumber_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YMinNumber_Basic(Vector<float> left, Vector<float> right) {
                Vector<float> rt = left;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                ref float pright = ref Unsafe.As<Vector<float>, float>(ref right);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathINumber.MinNumber(p, pright);
                    p = ref Unsafe.Add(ref p, 1);
                    pright = ref Unsafe.Add(ref pright, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMinNumber_Basic(Vector<double> left, Vector<double> right) {
                Vector<double> rt = left;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                ref double pright = ref Unsafe.As<Vector<double>, double>(ref right);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathINumber.MinNumber(p, pright);
                    p = ref Unsafe.Add(ref p, 1);
                    pright = ref Unsafe.Add(ref pright, 1);
                }
                return rt;
            }

#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YMinNumber_Bit(Vector<float> left, Vector<float> right) {
                Vector<int> mask = Vector.BitwiseOr(Vector.LessThan(left, right), YIsNaN(right));
                mask = Vector.BitwiseOr(mask, Vector.BitwiseAnd(Vector.Equals(left, right), YIsNegative(left)));
                Vector<float> rt = Vector.ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMinNumber_Bit(Vector<double> left, Vector<double> right) {
                Vector<long> mask = Vector.BitwiseOr(Vector.LessThan(left, right), YIsNaN(right));
                mask = Vector.BitwiseOr(mask, Vector.BitwiseAnd(Vector.Equals(left, right), YIsNegative(left)));
                Vector<double> rt = Vector.ConditionalSelect(mask, left, right);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper) {
                Vector<short> amin = Vectors<short>.VMinSByte;
                Vector<short> amax = Vectors<short>.VMaxSByte;
                Vector<short> l = YClamp(lower, amin, amax);
                Vector<short> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper) {
                Vector<ushort> amax = Vectors<ushort>.VMaxByte;
                Vector<ushort> l = Vector.Min(lower, amax);
                Vector<ushort> u = Vector.Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper) {
                Vector<int> amin = Vectors<int>.VMinInt16;
                Vector<int> amax = Vectors<int>.VMaxInt16;
                Vector<int> l = YClamp(lower, amin, amax);
                Vector<int> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper) {
                Vector<uint> amax = Vectors<uint>.VMaxUInt16;
                Vector<uint> l = Vector.Min(lower, amax);
                Vector<uint> u = Vector.Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper) {
                Vector<long> amin = Vectors<long>.VMinInt32;
                Vector<long> amax = Vectors<long>.VMaxInt32;
                Vector<long> l = YClamp(lower, amin, amax);
                Vector<long> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper) {
                Vector<ulong> amax = Vectors<ulong>.VMaxUInt32;
                Vector<ulong> l = Vector.Min(lower, amax);
                Vector<ulong> u = Vector.Min(upper, amax);
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{short}, Vector{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper) {
                Vector<short> amin = Vector<short>.Zero;
                Vector<short> amax = Vectors<short>.VMaxByte;
                Vector<ushort> l = YClamp(lower, amin, amax).AsUInt16();
                Vector<ushort> u = YClamp(upper, amin, amax).AsUInt16();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{int}, Vector{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper) {
                Vector<int> amin = Vector<int>.Zero;
                Vector<int> amax = Vectors<int>.VMaxUInt16;
                Vector<uint> l = YClamp(lower, amin, amax).AsUInt32();
                Vector<uint> u = YClamp(upper, amin, amax).AsUInt32();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{long}, Vector{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper) {
                Vector<long> amin = Vector<long>.Zero;
                Vector<long> amax = Vectors<long>.VMaxUInt32;
                Vector<ulong> l = YClamp(lower, amin, amax).AsUInt64();
                Vector<ulong> u = YClamp(upper, amin, amax).AsUInt64();
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IVectorTraits.YOrNot_AcceleratedTypes"/>
            public static TypeCodeFlags YOrNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YOrNot{T}(Vector{T}, Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YOrNot<T>(Vector<T> left, Vector<T> right) where T : struct {
                Vector<T> right2 = Vector.OnesComplement(right);
                Vector<T> rt = Vector.BitwiseOr(left, right2);
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToEven(Vector<float> value) {
                return YRoundToEven_Add(value);
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToEven(Vector<double> value) {
                return YRoundToEven_Add(value);
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToEven_Add(Vector<float> value) {
                // [Single type] If (0<=x && x<pow(2,23)), `round_to_even(x) = x + pow(2,23) - pow(2,23)`. Next generalize this approach to all number ranges.
                Vector<float> delta = new Vector<float>(ScalarConstants.SingleVal_2Pow23);
                Vector<float> signMask = VectorConstants.Single_SignMask;
                Vector<float> valueAbs = Vector.AndNot(value, signMask);
                Vector<float> signData = Vector.BitwiseAnd(value, signMask);
                Vector<float> allowMask = Vector.LessThan(valueAbs, delta).AsSingle(); // Allow is `(value[i] < pow(2,23) )`.
                delta = Vector.BitwiseOr(delta, signData);
                delta = Vector.BitwiseAnd(delta, allowMask);
                Vector<float> rt = Vector.Add(value, delta);
                rt = Vector.Subtract(rt, delta);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToEven_Add(Vector<double> value) {
                // [Double type] If (0<=x && x<pow(2,52)), `round_to_even(x) = x + pow(2,52) - pow(2,52)`. Next generalize this approach to all number ranges.
                Vector<double> delta = new Vector<double>(ScalarConstants.DoubleVal_2Pow52);
                Vector<double> signMask = VectorConstants.Double_SignMask;
                Vector<double> valueAbs = Vector.AndNot(value, signMask);
                Vector<double> signData = Vector.BitwiseAnd(value, signMask);
                Vector<double> allowMask = Vector.LessThan(valueAbs, delta).AsDouble(); // Allow is `(value[i] < pow(2,52) )`.
                delta = Vector.BitwiseOr(delta, signData);
                delta = Vector.BitwiseAnd(delta, allowMask);
                Vector<double> rt = Vector.Add(value, delta);
                rt = Vector.Subtract(rt, delta);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToZero(Vector<float> value) {
#if NET5_0_OR_GREATER
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_ClearBit(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToZero(Vector<double> value) {
#if NET5_0_OR_GREATER
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_ClearBit(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToZero_ClearBit(Vector<float> value) {
                // Float encode is `sign*(1.m)*pow(2,e) = sign*(1.m)*pow(2,eBias - BIAS)`. Single's BIAS is `127`.
                // If (e>=23): Has 0bit fractional part. The mask is `0`.
                // If (e==22): Has 1bit fractional part. The mask is `0x1`.
                // ...
                // If (e==1): Has 22bit fractional part. The mask is `0x003FFFFF`.
                // If (e==0): Has 23bit fractional part. The mask is `0x007FFFFF`.
                // If (e< 0): Need set to zero (0.0 / -0.0). The mask is `0x7FFFFFFF`.
                //
                // If (0<=e && e<=23): The mask is `pow(2,23-e) - 1`. So `RoundToZero(x) = x & ~mask`.
                //Constants.
                Vector<float> exponentMask = new Vector<float>(ScalarConstants.SingleVal_ExponentMask);
                Vector<float> one = new Vector<float>(1.0f);
                Vector<float> rangeEnd = new Vector<float>(ScalarConstants.SingleVal_2Pow23); // Single value: pow(2, 23)
                Vector<float> nonSignMask = VectorConstants.Single_NonSignMask;
                //Operations.
                Vector<float> valueExpData = Vector.BitwiseAnd(value, exponentMask); // Get exponent field.
                Vector<int> maskBegin = Vector.GreaterThan(one, valueExpData); // `1 > valueExpData[i] = pow(2,0) > pow(2,e)`, it mean `e<0`.
                valueExpData = Vector.Min(valueExpData, rangeEnd); // Clamp to `e<=23`.
                maskBegin = Vector.BitwiseAnd(maskBegin, nonSignMask.AsInt32()); // Keep sign flag.
                Vector<int> expMinuend = new Vector<int>(ScalarConstants.SingleBit_Truncate_expMinuend); // Item is `(int)(127*2 + 23)<<23`. Binary is `0x8A800000`.
                Vector<float> maskRawPow = Vector.Subtract(expMinuend.AsUInt32(), valueExpData.AsUInt32()).AsSingle(); // If valueExpData is `(127 + e)<<23`, `expMinuend-valueExpData` exponent field will be `(127*2 + 23) - (127 + e) = 127 + (23-e)`
                maskRawPow = Vector.Subtract(maskRawPow, one); // The mask is `pow(2,23-e) - 1`.
                Vector<int> mask = Vector.Add(maskRawPow, rangeEnd).AsInt32(); // Step 1 of ConvertToUInt32_Range23RoundToEven .
                mask = Vector.Xor(mask, rangeEnd.AsInt32()); // mask = ConvertToUInt32_Range23RoundToEven(maskRawPow).AsInt32();
                mask = Vector.BitwiseOr(mask, maskBegin); // Choose (e<0).
                //writer.WriteLine(VectorTextUtil.Format("The mask:\t{0}", mask));
                Vector<float> rt = Vector.AndNot(value, mask.AsSingle());
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToZero_ClearBit(Vector<double> value) {
                // Float encode is `sign*(1.m)*pow(2,e) = sign*(1.m)*pow(2,eBias - BIAS)`. Double's BIAS is `1023`.
                // If (e>=52): Has 0bit fractional part. The mask is `0`.
                // If (e==51): Has 1bit fractional part. The mask is `0x1`.
                // ...
                // If (e==1): Has 51bit fractional part. The mask is `0x0007FFFF_FFFFFFFF`.
                // If (e==0): Has 52bit fractional part. The mask is `0x000FFFFF_FFFFFFFF`.
                // If (e< 0): Need set to zero (0.0 / -0.0). The mask is `0x7FFFFFFF_FFFFFFFF`.
                //
                // If (0<=e && e<=52): The mask is `pow(2,52-e) - 1`. So `RoundToZero(x) = x & ~mask`.
                //Constants.
                Vector<double> exponentMask = new Vector<double>(ScalarConstants.DoubleVal_ExponentMask);
                Vector<double> one = new Vector<double>(1.0);
                Vector<double> rangeEnd = new Vector<double>(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                Vector<double> nonSignMask = VectorConstants.Double_NonSignMask;
                //Operations.
                Vector<double> valueExpData = Vector.BitwiseAnd(value, exponentMask); // Get exponent field.
                Vector<long> maskBegin = Vector.GreaterThan(one, valueExpData); // `1 > valueExpData[i] = pow(2,0) > pow(2,e)`, it mean `e<0`.
                valueExpData = Vector.Min(valueExpData, rangeEnd); // Clamp to `e<=52`.
                maskBegin = Vector.BitwiseAnd(maskBegin, nonSignMask.AsInt64()); // Keep sign flag.
                Vector<double> expMinuend = new Vector<double>(ScalarConstants.DoubleVal_Truncate_expMinuend); // Item is `(long)(1023*2 + 52)<<52`. Binary is `0x8320000000000000`.
                Vector<double> maskRawPow = Vector.Subtract(expMinuend.AsUInt64(), valueExpData.AsUInt64()).AsDouble(); // If valueExpData is `(1023 + e)<<52`, `expMinuend-valueExpData` exponent field will be `(1023*2 + 52) - (1023 + e) = 1023 + (52-e)`
                maskRawPow = Vector.Subtract(maskRawPow, one); // The mask is `pow(2,52-e) - 1`.
                Vector<long> mask = Vector.Add(maskRawPow, rangeEnd).AsInt64(); // Step 1 of ConvertToUInt64_Range52RoundToEven .
                mask = Vector.Xor(mask, rangeEnd.AsInt64()); // mask = ConvertToUInt64_Range52RoundToEven(maskRawPow).AsInt64();
                mask = Vector.BitwiseOr(mask, maskBegin); // Choose (e<0).
                //writer.WriteLine(VectorTextUtil.Format("The mask:\t{0}", mask));
                Vector<double> rt = Vector.AndNot(value, mask.AsDouble()); // If lower than netcore3.0, AndNot is not a single instruction, performance is worse (split into 2 parts of And and Not, and Not is loaded in memory).
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToZero_ClearBit_Not(Vector<double> value) {
                // Float encode is `sign*(1.m)*pow(2,e) = sign*(1.m)*pow(2,eBias - BIAS)`. Double's BIAS is `1023`.
                // If (e>=52): Has 0bit fractional part. The mask is `0`.
                // If (e==51): Has 1bit fractional part. The mask is `0x1`.
                // ...
                // If (e==1): Has 51bit fractional part. The mask is `0x0007FFFF_FFFFFFFF`.
                // If (e==0): Has 52bit fractional part. The mask is `0x000FFFFF_FFFFFFFF`.
                // If (e< 0): Need set to zero (0.0 / -0.0). The mask is `0x7FFFFFFF_FFFFFFFF`.
                //
                // If (0<=e && e<=52): The mask is `pow(2,52-e) - 1`. So `RoundToZero(x) = x & ~mask`.
                //Constants.
                Vector<double> exponentMask = new Vector<double>(ScalarConstants.DoubleVal_ExponentMask);
                Vector<double> one = new Vector<double>(1.0);
                Vector<double> rangeEnd = new Vector<double>(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                Vector<double> nonSignMask = VectorConstants.Double_NonSignMask;
                //Operations.
                Vector<double> valueExpData = Vector.BitwiseAnd(value, exponentMask); // Get exponent field.
                Vector<long> maskBegin = Vector.GreaterThan(one, valueExpData); // `1 > valueExpData[i] = pow(2,0) > pow(2,e)`, it mean `e<0`.
                valueExpData = Vector.Min(valueExpData, rangeEnd); // Clamp to `e<=52`.
                maskBegin = Vector.BitwiseAnd(maskBegin, nonSignMask.AsInt64()); // Keep sign flag.
                Vector<double> expMinuend = new Vector<double>(ScalarConstants.DoubleVal_Truncate_expMinuend); // Item is `(long)(1023*2 + 52)<<52`. Binary is `0x8320000000000000`.
                Vector<double> maskRawPow = Vector.Subtract(expMinuend.AsUInt64(), valueExpData.AsUInt64()).AsDouble(); // If valueExpData is `(1023 + e)<<52`, `expMinuend-valueExpData` exponent field will be `(1023*2 + 52) - (1023 + e) = 1023 + (52-e)`
                maskRawPow = Vector.Subtract(maskRawPow, one); // The mask is `pow(2,52-e) - 1`.
                Vector<long> mask = Vector.Add(maskRawPow, rangeEnd).AsInt64(); // Step 1 of ConvertToUInt64_Range52RoundToEven .
                mask = Vector.Xor(mask, rangeEnd.AsInt64()); // mask = ConvertToUInt64_Range52RoundToEven(maskRawPow).AsInt64();
                Vector<long> allBitsSet = Vectors<long>.AllBitsSet;
                mask = Vector.BitwiseOr(mask, maskBegin); // Choose (e<0).
                //writer.WriteLine(VectorTextUtil.Format("The mask:\t{0}", mask));
                mask = Vector.Xor(mask, allBitsSet); // mask = ~mask;
                Vector<double> rt = Vector.BitwiseAnd(value, mask.AsDouble());
                return rt;
            }

#if NET5_0_OR_GREATER
            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToZero_Floor(Vector<float> value) {
                Vector<float> signMask = VectorConstants.Single_SignMask;
                Vector<float> valueAbs = Vector.AndNot(value, signMask);
                Vector<float> signData = Vector.BitwiseAnd(value, signMask);
                Vector<float> rt = Vector.Floor(valueAbs);
                rt = Vector.BitwiseOr(rt, signData);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToZero_Floor(Vector<double> value) {
                Vector<double> signMask = VectorConstants.Double_SignMask;
                Vector<double> valueAbs = Vector.AndNot(value, signMask);
                Vector<double> signData = Vector.BitwiseAnd(value, signMask);
                Vector<double> rt = Vector.Floor(valueAbs); // Vector.Floor need .NET 5+ .
                rt = Vector.BitwiseOr(rt, signData);
                return rt;
            }
#endif // NET5_0_OR_GREATER


        }
    }
}
