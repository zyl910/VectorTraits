#if NET7_0_OR_GREATER
#define BCL_SHUFFLE_HAS
#endif // NET7_0_OR_GREATER
#if NET7_0_OR_GREATER
#define VECTOR_HAS_METHOD
#endif // NET7_0_OR_GREATER

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
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector256 {
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

#if NETX_0_OR_GREATER
            private const bool Bcl_Shuffle_Used = true;
#else
            private const bool Bcl_Shuffle_Used = false;
#endif // NETX_0_OR_GREATER

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsHardwareAccelerated"/>
            public static bool IsHardwareAccelerated {
                get {
#if VECTOR_HAS_METHOD
                    return Vector256.IsHardwareAccelerated;
#else
                    return false;
#endif // VECTOR_HAS_METHOD
                }
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

            /// <inheritdoc cref="IBaseTraits.UsedInstructionSets"/>
            public static string UsedInstructionSets { get; } = MakeUsedInstructionSets();

            /// <inheritdoc cref="Zyl.VectorTraits.Impl.AVector.VectorTraitsBase.Statics.MakeUsedInstructionSets"/>
            internal static string MakeUsedInstructionSets() {
                string rt = "";
                return rt;
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Ceiling(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Ceiling(value);
                // .NET7~8 on Avx2~Avx512: It has hardware-accelerated.
                //00007FFD4FE2477E  mov         rdx,1EE0012DCC0h  
                //00007FFD4FE24788  vroundps    ymm0,ymmword ptr [rdx],2  
                //00007FFD4FE2478E  vmovups     ymmword ptr [rbp-1910h],ymm0  
#else
                return Ceiling_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Ceiling(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Ceiling(value);
                // .NET7~8 on Avx2~Avx512: It has hardware-accelerated.
                //00007FFD4FE2483B  mov         rdx,1EE0012EB20h  
                //00007FFD4FE24845  vroundpd    ymm0,ymmword ptr [rdx],2  
                //00007FFD4FE2484B  vmovups     ymmword ptr [rbp-1970h],ymm0  
#else
                return Ceiling_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Ceiling_Basic(Vector256<float> value) {
                Vector256<float> rt = value;
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref rt);
                p = MathF.Ceiling(p);
                Unsafe.Add(ref p, 1) = MathF.Ceiling(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Ceiling(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Ceiling(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = MathF.Ceiling(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = MathF.Ceiling(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = MathF.Ceiling(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = MathF.Ceiling(Unsafe.Add(ref p, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Ceiling_Basic(Vector256<double> value) {
                Vector256<double> rt = value;
                ref double p = ref Unsafe.As<Vector256<double>, double>(ref rt);
                p = Math.Ceiling(p);
                Unsafe.Add(ref p, 1) = Math.Ceiling(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Ceiling(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Ceiling(Unsafe.Add(ref p, 3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ConvertToDouble(value);
                // .NET8 on Avx512: No hardware accelerated.
                //   208: 		return Create(Vector128.ConvertToDouble(vector._lower), Vector128.ConvertToDouble(vector._upper));
                //00007FFDE22AAC98  movups      xmm0,xmmword ptr [rdx]  
                //00007FFDE22AAC9B  movaps      xmm1,xmm0  
                //00007FFDE22AAC9E  psrlq       xmm1,20h  
                //00007FFDE22AACA3  movups      xmm2,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E500h (07FFDE29D1BD0h)]  
                //00007FFDE22AACAA  pxor        xmm1,xmm2  
                //00007FFDE22AACAE  movups      xmm3,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E510h (07FFDE29D1BE0h)]  
                //00007FFDE22AACB5  subpd       xmm1,xmm3  
                //00007FFDE22AACB9  movups      xmm4,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E520h (07FFDE29D1BF0h)]  
                //00007FFDE22AACC0  pand        xmm0,xmm4  
                //00007FFDE22AACC4  movups      xmm5,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E530h (07FFDE29D1C00h)]  
                //00007FFDE22AACCB  por         xmm0,xmm5  
                //00007FFDE22AACCF  addpd       xmm0,xmm1  
                //00007FFDE22AACD3  movups      xmm1,xmmword ptr [rdx+10h]  
                //00007FFDE22AACD7  movaps      xmm6,xmm1  
                //00007FFDE22AACDA  psrlq       xmm6,20h  
                //00007FFDE22AACDF  pxor        xmm2,xmm6  
                //00007FFDE22AACE3  subpd       xmm2,xmm3  
                //00007FFDE22AACE7  pand        xmm1,xmm4  
                //00007FFDE22AACEB  por         xmm1,xmm5  
                //00007FFDE22AACEF  addpd       xmm1,xmm2  
                //00007FFDE22AACF3  movups      xmmword ptr [rcx],xmm0  
                //00007FFDE22AACF6  movups      xmmword ptr [rcx+10h],xmm1  
#else
                return ConvertToDouble_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble(Vector256<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ConvertToDouble(value);
                // .NET8 on Avx512: No hardware accelerated.
                //   225: 		return Create(Vector128.ConvertToDouble(vector._lower), Vector128.ConvertToDouble(vector._upper));
                //00007FFDAE85AD18  movups      xmm0,xmmword ptr [rdx]  
                //00007FFDAE85AD1B  movaps      xmm1,xmm0  
                //00007FFDAE85AD1E  psrlq       xmm1,20h  
                //00007FFDAE85AD23  movups      xmm2,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E540h (07FFDAEF81C10h)]  
                //00007FFDAE85AD2A  pxor        xmm1,xmm2  
                //00007FFDAE85AD2E  movups      xmm3,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E550h (07FFDAEF81C20h)]  
                //00007FFDAE85AD35  subpd       xmm1,xmm3  
                //00007FFDAE85AD39  movups      xmm4,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E560h (07FFDAEF81C30h)]  
                //00007FFDAE85AD40  pand        xmm0,xmm4  
                //00007FFDAE85AD44  movups      xmm5,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E570h (07FFDAEF81C40h)]  
                //00007FFDAE85AD4B  por         xmm0,xmm5  
                //00007FFDAE85AD4F  addpd       xmm0,xmm1  
                //00007FFDAE85AD53  movups      xmm1,xmmword ptr [rdx+10h]  
                //00007FFDAE85AD57  movaps      xmm6,xmm1  
                //00007FFDAE85AD5A  psrlq       xmm6,20h  
                //00007FFDAE85AD5F  pxor        xmm2,xmm6  
                //00007FFDAE85AD63  subpd       xmm2,xmm3  
                //00007FFDAE85AD67  pand        xmm1,xmm4  
                //00007FFDAE85AD6B  por         xmm1,xmm5  
                //00007FFDAE85AD6F  addpd       xmm1,xmm2  
                //00007FFDAE85AD73  movups      xmmword ptr [rcx],xmm0  
                //00007FFDAE85AD76  movups      xmmword ptr [rcx+10h],xmm1  
#else
                return ConvertToDouble_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Basic(Vector256<long> value) {
                UnsafeUtil.SkipInit(out Vector256<double> rt);
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
            public static Vector256<double> ConvertToDouble_Basic(Vector256<ulong> value) {
                UnsafeUtil.SkipInit(out Vector256<double> rt);
                ref double prt = ref Unsafe.As<Vector256<double>, double>(ref rt);
                ref ulong p = ref Unsafe.As<Vector256<ulong>, ulong>(ref value);
                prt = (Double)p;
                Unsafe.Add(ref prt, 1) = (Double)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Double)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Double)Unsafe.Add(ref p, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Range52(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (VectorEnvironment.ProcessIsX86Family && Vector<byte>.Count < BitOfByte.Bit512) {
                    return ConvertToDouble_Range52_Impl(value);
                } else {
                    return Vector256.ConvertToDouble(value);
                }
#elif VECTOR_HAS_METHOD
                return ConvertToDouble_Range52_Impl(value);
#else
                return ConvertToDouble_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Range52(Vector256<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (VectorEnvironment.ProcessIsX86Family && Vector<byte>.Count < BitOfByte.Bit512) {
                    return ConvertToDouble_Range52_Impl(value);
                } else {
                    return Vector256.ConvertToDouble(value);
                }
#elif VECTOR_HAS_METHOD
                return ConvertToDouble_Range52_Impl(value);
#else
                return ConvertToDouble_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Range52_Impl(Vector256<long> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits256Avx2.ConvertToDouble_Range52
                Vector256<long> magicNumber = Vector256.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector256<long> x = Vector256.Add(value, magicNumber);
                Vector256<double> result = Vector256.Subtract(x.AsDouble(), magicNumber.AsDouble());
#else
                Vector256<double> result = ConvertToDouble_Basic(value);
#endif // VECTOR_HAS_METHOD
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Range52_Impl(Vector256<ulong> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits256Avx2.ConvertToDouble_Range52
                Vector256<ulong> magicNumber = Vector256.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                Vector256<ulong> x = Vector256.BitwiseOr(value, magicNumber);
                Vector256<double> result = Vector256.Subtract(x.AsDouble(), magicNumber.AsDouble());
#else
                Vector256<double> result = ConvertToDouble_Basic(value);
#endif // VECTOR_HAS_METHOD
                return result;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ConvertToInt32(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ConvertToInt32(value);
                // .NET7~8 on Avx2~Avx512: It has hardware-accelerated.
                //00007FFD4FE2531A  mov         rdx,1EE0012DCC0h  
                //00007FFD4FE25324  vcvttps2dq  ymm0,ymmword ptr [rdx]  
                //00007FFD4FE25328  vmovups     ymmword ptr [rbp-1E50h],ymm0  
#else
                return ConvertToInt32_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ConvertToInt32_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref int prt = ref Unsafe.As<Vector256<int>, int>(ref rt);
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref value);
                prt = (Int32)p;
                Unsafe.Add(ref prt, 1) = (Int32)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Int32)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Int32)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (Int32)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (Int32)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (Int32)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (Int32)Unsafe.Add(ref p, 7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        //rt |= TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ConvertToInt64(value);
                // .NET8 on Avx512: No hardware accelerated.
                //   239: 		return Create(Vector128.ConvertToInt64(vector._lower), Vector128.ConvertToInt64(vector._upper));
                //00007FFDAE85ADB0  sub         rsp,88h  
                //00007FFDAE85ADB7  movups      xmm0,xmmword ptr [rdx]  
                //00007FFDAE85ADBA  movaps      xmmword ptr [rsp+70h],xmm0  
                //00007FFDAE85ADBF  mov         rax,qword ptr [rsp+70h]  
                //00007FFDAE85ADC4  mov         qword ptr [rsp+60h],rax  
                //00007FFDAE85ADC9  cvttsd2si   rax,mmword ptr [rsp+60h]  
                //00007FFDAE85ADD0  mov         qword ptr [rsp+68h],rax  
                //00007FFDAE85ADD5  mov         rax,qword ptr [rsp+68h]  
                //00007FFDAE85ADDA  mov         r8,qword ptr [rsp+78h]  
                //00007FFDAE85ADDF  mov         qword ptr [rsp+50h],r8  
                //00007FFDAE85ADE4  cvttsd2si   r8,mmword ptr [rsp+50h]  
                //00007FFDAE85ADEB  mov         qword ptr [rsp+58h],r8  
                //00007FFDAE85ADF0  mov         r8,qword ptr [rsp+58h]  
                //00007FFDAE85ADF5  mov         qword ptr [rsp+40h],rax  
                //00007FFDAE85ADFA  mov         qword ptr [rsp+48h],r8  
                //00007FFDAE85ADFF  movaps      xmm0,xmmword ptr [rsp+40h]  
                //00007FFDAE85AE04  movups      xmm1,xmmword ptr [rdx+10h]  
                //00007FFDAE85AE08  movaps      xmmword ptr [rsp+30h],xmm1  
                //00007FFDAE85AE0D  mov         rax,qword ptr [rsp+30h]  
                //00007FFDAE85AE12  mov         qword ptr [rsp+20h],rax  
                //00007FFDAE85AE17  cvttsd2si   rax,mmword ptr [rsp+20h]  
                //00007FFDAE85AE1E  mov         qword ptr [rsp+28h],rax  
                //00007FFDAE85AE23  mov         rax,qword ptr [rsp+28h]  
                //00007FFDAE85AE28  mov         rdx,qword ptr [rsp+38h]  
                //00007FFDAE85AE2D  mov         qword ptr [rsp+10h],rdx  
                //00007FFDAE85AE32  cvttsd2si   rdx,mmword ptr [rsp+10h]  
                //00007FFDAE85AE39  mov         qword ptr [rsp+18h],rdx  
                //00007FFDAE85AE3E  mov         rdx,qword ptr [rsp+18h]  
                //00007FFDAE85AE43  mov         qword ptr [rsp],rax  
                //00007FFDAE85AE47  mov         qword ptr [rsp+8],rdx  
                //00007FFDAE85AE4C  movaps      xmm1,xmmword ptr [rsp]  
                //00007FFDAE85AE50  movups      xmmword ptr [rcx],xmm0  
                //00007FFDAE85AE53  movups      xmmword ptr [rcx+10h],xmm1  
#else
                return ConvertToInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref long prt = ref Unsafe.As<Vector256<long>, long>(ref rt);
                ref double p = ref Unsafe.As<Vector256<double>, double>(ref value);
                prt = (Int64)p;
                Unsafe.Add(ref prt, 1) = (Int64)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Int64)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Int64)Unsafe.Add(ref p, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_Range52(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_Range52(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (VectorEnvironment.ProcessIsX86Family && Vector<byte>.Count < BitOfByte.Bit512) {
                    return ConvertToInt64_Range52_Impl(value);
                } else {
                    return Vector256.ConvertToInt64(value);
                }
#elif VECTOR_HAS_METHOD
                return ConvertToInt64_Range52_Impl(value);
#else
                return ConvertToInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_Range52(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_Range52_Impl(Vector256<double> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits256Avx2.ConvertToInt64_Range52_Impl
                value = YRoundToZero(value); // Truncate.
                return ConvertToInt64_Range52RoundToEven(value);
#else
                return ConvertToInt64_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_Range52RoundToEven(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_Range52RoundToEven(Vector256<double> value) {
#if VECTOR_HAS_METHOD
                // See more: WVector256Traits256Avx2.ConvertToInt64_Range52RoundToEven
                Vector256<long> magicNumber = Vector256.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector256<double> x = Vector256.Add(value, magicNumber.AsDouble());
                Vector256<long> result = Vector256.Subtract(x.AsInt64(), magicNumber);
                return result;
#else
                return ConvertToInt64_Basic(value);
#endif // VECTOR_HAS_METHOD
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> ConvertToSingle(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ConvertToSingle(value);
                // .NET7~8 on Avx2~Avx512: It has hardware-accelerated.
                //00007FFD87345494  mov         rdx,20180133148h  
                //00007FFD8734549E  vcvtdq2ps   ymm0,ymmword ptr [rdx]  
                //00007FFD873454A2  vmovups     ymmword ptr [rbp-1F10h],ymm0  
#else
                return ConvertToSingle_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> ConvertToSingle(Vector256<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ConvertToSingle(value);
                // .NET8 on Avx512: No hardware accelerated.
                //00007FFDE22AAE90  movups      xmm0,xmmword ptr [rdx]  
                //00007FFDE22AAE93  movaps      xmm1,xmm0  
                //00007FFDE22AAE96  psrld       xmm1,10h  
                //00007FFDE22AAE9B  cvtdq2ps    xmm1,xmm1  
                //00007FFDE22AAE9E  movups      xmm2,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E580h (07FFDE29D1C50h)]  
                //00007FFDE22AAEA5  mulps       xmm1,xmm2  
                //00007FFDE22AAEA8  movups      xmm3,xmmword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+044E590h (07FFDE29D1C60h)]  
                //00007FFDE22AAEAF  pand        xmm0,xmm3  
                //00007FFDE22AAEB3  cvtdq2ps    xmm0,xmm0  
                //00007FFDE22AAEB6  addps       xmm0,xmm1  
                //00007FFDE22AAEB9  movups      xmm1,xmmword ptr [rdx+10h]  
                //00007FFDE22AAEBD  movaps      xmm4,xmm1  
                //00007FFDE22AAEC0  psrld       xmm4,10h  
                //00007FFDE22AAEC5  cvtdq2ps    xmm4,xmm4  
                //00007FFDE22AAEC8  mulps       xmm2,xmm4  
                //00007FFDE22AAECB  pand        xmm1,xmm3  
#else
                return ConvertToSingle_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> ConvertToSingle_Basic(Vector256<int> value) {
                UnsafeUtil.SkipInit(out Vector256<float> rt);
                ref float prt = ref Unsafe.As<Vector256<float>, float>(ref rt);
                ref int p = ref Unsafe.As<Vector256<int>, int>(ref value);
                prt = (Single)p;
                Unsafe.Add(ref prt, 1) = (Single)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Single)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Single)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (Single)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (Single)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (Single)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (Single)Unsafe.Add(ref p, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> ConvertToSingle_Basic(Vector256<uint> value) {
                UnsafeUtil.SkipInit(out Vector256<float> rt);
                ref float prt = ref Unsafe.As<Vector256<float>, float>(ref rt);
                ref uint p = ref Unsafe.As<Vector256<uint>, uint>(ref value);
                prt = (Single)p;
                Unsafe.Add(ref prt, 1) = (Single)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Single)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Single)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (Single)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (Single)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (Single)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (Single)Unsafe.Add(ref p, 7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ConvertToUInt32(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ConvertToUInt32(value);
                // .NET8 on Avx512: No hardware accelerated.
                //   275: 		return Create(Vector128.ConvertToUInt32(vector._lower), Vector128.ConvertToUInt32(vector._upper));
                //00007FFDE22AAEE0  sub         rsp,88h  
                //00007FFDE22AAEE7  movups      xmm0,xmmword ptr [rdx]  
                //00007FFDE22AAEEA  movaps      xmmword ptr [rsp+70h],xmm0  
                //00007FFDE22AAEEF  mov         rax,qword ptr [rsp+70h]  
                //00007FFDE22AAEF4  mov         qword ptr [rsp+60h],rax  
                //00007FFDE22AAEF9  cvttss2si   rax,dword ptr [rsp+60h]  
                //00007FFDE22AAF00  mov         dword ptr [rsp+68h],eax  
                //00007FFDE22AAF04  cvttss2si   rax,dword ptr [rsp+64h]  
                //00007FFDE22AAF0B  mov         dword ptr [rsp+6Ch],eax  
                //00007FFDE22AAF0F  mov         rax,qword ptr [rsp+68h]  
                //00007FFDE22AAF14  mov         r8,qword ptr [rsp+78h]  
                //00007FFDE22AAF19  mov         qword ptr [rsp+50h],r8  
                //00007FFDE22AAF1E  cvttss2si   r8,dword ptr [rsp+50h]  
                //00007FFDE22AAF25  mov         dword ptr [rsp+58h],r8d  
                //00007FFDE22AAF2A  cvttss2si   r8,dword ptr [rsp+54h]  
                //00007FFDE22AAF31  mov         dword ptr [rsp+5Ch],r8d  
#else
                return ConvertToUInt32_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ConvertToUInt32_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
                ref uint prt = ref Unsafe.As<Vector256<uint>, uint>(ref rt);
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref value);
                prt = (UInt32)p;
                Unsafe.Add(ref prt, 1) = (UInt32)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (UInt32)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (UInt32)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (UInt32)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (UInt32)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (UInt32)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (UInt32)Unsafe.Add(ref p, 7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ConvertToUInt64(value);
                // .NET8 on Avx512: No hardware accelerated.
                //   283: 		return Create(Vector128.ConvertToUInt64(vector._lower), Vector128.ConvertToUInt64(vector._upper));
                //00007FFDE22AAFC0  push        rdi  
                //00007FFDE22AAFC1  push        rsi  
                //00007FFDE22AAFC2  push        rbx  
                //00007FFDE22AAFC3  sub         rsp,0B0h  
                //00007FFDE22AAFCA  movaps      xmmword ptr [rsp+0A0h],xmm6  
                //00007FFDE22AAFD2  mov         rsi,rcx  
                //00007FFDE22AAFD5  mov         rbx,rdx  
                //00007FFDE22AAFD8  movups      xmm0,xmmword ptr [rbx]  
                //00007FFDE22AAFDB  movaps      xmmword ptr [rsp+90h],xmm0  
                //00007FFDE22AAFE3  mov         rax,qword ptr [rsp+90h]  
                //00007FFDE22AAFEB  mov         qword ptr [rsp+80h],rax  
                //00007FFDE22AAFF3  movsd       xmm0,mmword ptr [rsp+80h]  
                //00007FFDE22AAFFC  call        qword ptr [System.Diagnostics.Tracing.Statics.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)+05AE748h (07FFDE2B31E18h)]  
                //00007FFDE22AB002  mov         qword ptr [rsp+88h],rax  
                //00007FFDE22AB00A  mov         rdi,qword ptr [rsp+88h]  
                //00007FFDE22AB012  mov         rax,qword ptr [rsp+98h]  
#else
                return ConvertToUInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt);
                ref double p = ref Unsafe.As<Vector256<double>, double>(ref value);
                prt = (UInt64)p;
                Unsafe.Add(ref prt, 1) = (UInt64)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (UInt64)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (UInt64)Unsafe.Add(ref p, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_Range52(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64_Range52(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (VectorEnvironment.ProcessIsX86Family && Vector<byte>.Count < BitOfByte.Bit512) {
                    return ConvertToUInt64_Range52_Impl(value);
                } else {
                    return Vector256.ConvertToUInt64(value);
                }
#elif VECTOR_HAS_METHOD
                return ConvertToUInt64_Range52_Impl(value);
#else
                return ConvertToUInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_Range52(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64_Range52_Impl(Vector256<double> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits256Avx2.ConvertToUInt64_Range52_Impl
                value = YRoundToZero(value); // Truncate.
                return ConvertToUInt64_Range52RoundToEven(value);
#else
                return ConvertToUInt64_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_Range52RoundToEven(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64_Range52RoundToEven(Vector256<double> value) {
#if VECTOR_HAS_METHOD
                // See more: WVector256Traits256Avx2.ConvertToUInt64_Range52RoundToEven
                Vector256<ulong> magicNumber = Vector256.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                Vector256<double> x = Vector256.Add(value, magicNumber.AsDouble());
                Vector256<ulong> result = Vector256.Xor(x.AsUInt64(), magicNumber);
                return result;
#else
                return ConvertToUInt64_Basic(value);
#endif // VECTOR_HAS_METHOD
            }


            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<float> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<double> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<sbyte> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<byte> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<short> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<ushort> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<int> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<uint> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<long> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<ulong> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<float> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<double> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<sbyte> vector) {
                return Statics.ExtractMostSignificantBits_Basic(vector.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<byte> vector) {
                ref byte p = ref Unsafe.As<Vector256<byte>, byte>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 2)) << 2)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 3)) << 3)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 4)) << 4)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 5)) << 5)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 6)) << 6)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 7)) << 7)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 8)) << 8)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 9)) << 9)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 10)) << 10)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 11)) << 11)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 12)) << 12)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 13)) << 13)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 14)) << 14)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 15)) << 15)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 16)) << 16)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 17)) << 17)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 18)) << 18)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 19)) << 19)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 20)) << 20)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 21)) << 21)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 22)) << 22)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 23)) << 23)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 24)) << 24)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 25)) << 25)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 26)) << 26)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 27)) << 27)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 28)) << 28)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 29)) << 29)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 30)) << 30)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 31)) << 31)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<short> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<ushort> vector) {
                ref ushort p = ref Unsafe.As<Vector256<ushort>, ushort>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 2)) << 2)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 3)) << 3)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 4)) << 4)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 5)) << 5)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 6)) << 6)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 7)) << 7)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 8)) << 8)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 9)) << 9)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 10)) << 10)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 11)) << 11)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 12)) << 12)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 13)) << 13)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 14)) << 14)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 15)) << 15)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<int> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<uint> vector) {
                ref uint p = ref Unsafe.As<Vector256<uint>, uint>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 2)) << 2)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 3)) << 3)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 4)) << 4)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 5)) << 5)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 6)) << 6)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 7)) << 7)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<long> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Basic(Vector256<ulong> vector) {
                ref ulong p = ref Unsafe.As<Vector256<ulong>, ulong>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 2)) << 2)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 3)) << 3)
                ;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Floor(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Floor(value);
#else
                return Floor_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Floor(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Floor(value);
#else
                return Floor_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Floor_Basic(Vector256<float> value) {
                Vector256<float> rt = value;
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref rt);
                p = MathF.Floor(p);
                Unsafe.Add(ref p, 1) = MathF.Floor(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Floor(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Floor(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = MathF.Floor(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = MathF.Floor(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = MathF.Floor(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = MathF.Floor(Unsafe.Add(ref p, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Floor_Basic(Vector256<double> value) {
                Vector256<double> rt = value;
                ref double p = ref Unsafe.As<Vector256<double>, double>(ref rt);
                p = Math.Floor(p);
                Unsafe.Add(ref p, 1) = Math.Floor(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Floor(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Floor(Unsafe.Add(ref p, 3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{double}, Vector256{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Narrow(Vector256<double> lower, Vector256<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Narrow(lower, upper);
                // .NET7~8 on Avx2~Avx512: It has hardware-accelerated.
                //00007FFD8734ECBC  mov         rdx,2018012EB20h  
                //00007FFD8734ECC6  vcvtpd2ps   xmm0,ymmword ptr [rdx]  
                //00007FFD8734ECCA  mov         rdx,2018012EAF0h  
                //00007FFD8734ECD4  vcvtpd2ps   xmm1,ymmword ptr [rdx]  
                //00007FFD8734ECD8  vinsertf128 ymm0,ymm0,xmm1,1  
                //00007FFD8734ECDE  vmovups     ymmword ptr [rbp-5710h],ymm0  
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{short}, Vector256{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Narrow(Vector256<short> lower, Vector256<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Narrow(lower, upper);
                // .NET7~8 on Avx2~Avx512: It has hardware-accelerated.
                //00007FFD8734ED8B  mov         rdx,20180131538h  
                //00007FFD8734ED95  vmovups     ymm0,ymmword ptr [rdx]  
                //00007FFD8734ED99  vpmovwb     xmm0,ymm0  
                //00007FFD8734ED9F  mov         rdx,20180131508h  
                //00007FFD8734EDA9  vmovups     ymm1,ymmword ptr [rdx]  
                //00007FFD8734EDAD  vpmovwb     xmm1,ymm1  
                //00007FFD8734EDB3  vinserti128 ymm0,ymm0,xmm1,1  
                //00007FFD8734EDB9  vmovups     ymmword ptr [rbp-5770h],ymm0  
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ushort}, Vector256{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Narrow(Vector256<ushort> lower, Vector256<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{int}, Vector256{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Narrow(Vector256<int> lower, Vector256<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{uint}, Vector256{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Narrow(Vector256<uint> lower, Vector256<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{long}, Vector256{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Narrow(Vector256<long> lower, Vector256<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Narrow(lower, upper);
                // .NET8 on Avx512: Poor performance!
                // .NET7~8 on Avx2(Not use Avx512): It has hardware-accelerated.
                //00007FFD8734EF41  mov         rdx,20180134D58h  
                //00007FFD8734EF4B  vmovups     ymm0,ymmword ptr [rdx]  
                //00007FFD8734EF4F  vpmovqd     xmm0,ymm0  
                //00007FFD8734EF55  mov         rdx,20180134D28h  
                //00007FFD8734EF5F  vmovups     ymm1,ymmword ptr [rdx]  
                //00007FFD8734EF63  vpmovqd     xmm1,ymm1  
                //00007FFD8734EF69  vinserti128 ymm0,ymm0,xmm1,1  
                //00007FFD8734EF6F  vmovups     ymmword ptr [rbp-5830h],ymm0  
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ulong}, Vector256{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Narrow(Vector256<ulong> lower, Vector256<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Narrow(lower, upper);
                // .NET7~8 on Avx2(Not use Avx512): It has hardware-accelerated.
                //00007FFD8734F1D2  mov         rdx,20180135B60h  
                //00007FFD8734F1DC  vmovups     ymm0,ymmword ptr [rdx]  
                //00007FFD8734F1E0  vpmovqd     xmm0,ymm0  
                //00007FFD8734F1E6  mov         rdx,20180135B30h  
                //00007FFD8734F1F0  vmovups     ymm1,ymmword ptr [rdx]  
                //00007FFD8734F1F4  vpmovqd     xmm1,ymm1  
                //00007FFD8734F1FA  vinserti128 ymm0,ymm0,xmm1,1  
                //00007FFD8734F200  vmovups     ymmword ptr [rbp-5950h],ymm0  

#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{double}, Vector256{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Narrow_Basic(Vector256<double> lower, Vector256<double> upper) {
                nint cnt = Vector256<double>.Count;
                UnsafeUtil.SkipInit(out Vector256<float> rt);
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
            public static Vector256<sbyte> Narrow_Basic(Vector256<short> lower, Vector256<short> upper) {
                nint cnt = Vector256<short>.Count;
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
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
            public static Vector256<byte> Narrow_Basic(Vector256<ushort> lower, Vector256<ushort> upper) {
                nint cnt = Vector256<ushort>.Count;
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
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
            public static Vector256<short> Narrow_Basic(Vector256<int> lower, Vector256<int> upper) {
                nint cnt = Vector256<int>.Count;
                UnsafeUtil.SkipInit(out Vector256<short> rt);
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
            public static Vector256<ushort> Narrow_Basic(Vector256<uint> lower, Vector256<uint> upper) {
                nint cnt = Vector256<uint>.Count;
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
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
            public static Vector256<int> Narrow_Basic(Vector256<long> lower, Vector256<long> upper) {
                nint cnt = Vector256<long>.Count;
                UnsafeUtil.SkipInit(out Vector256<int> rt);
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
            public static Vector256<uint> Narrow_Basic(Vector256<ulong> lower, Vector256<ulong> upper) {
                nint cnt = Vector256<ulong>.Count;
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Basic(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Basic(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Basic(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Basic(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Basic(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Basic(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Basic(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Basic(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{byte}, int, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Args(Vector256<byte> dummy, int shiftAmount, out Vector256<byte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{short}, int, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{ushort}, int, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Args(Vector256<ushort> dummy, int shiftAmount, out Vector256<ushort> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{int}, int, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{uint}, int, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Args(Vector256<uint> dummy, int shiftAmount, out Vector256<uint> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{long}, int, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{ulong}, int, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Args(Vector256<ulong> dummy, int shiftAmount, out Vector256<ulong> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Core(Vector256<byte> value, int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Core(Vector256<ushort> value, int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Core(Vector256<uint> value, int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Core(Vector256<ulong> value, int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Const(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Const(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Const(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Const(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_ConstCore(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_ConstCore(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_ConstCore(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_ConstCore(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Fast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Fast(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Fast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Fast(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Fast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Fast(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Fast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Fast(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Fast_Basic(Vector256<sbyte> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Fast_Basic(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector256<byte>, byte>(ref rt);
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
                Unsafe.Add(ref p, 16) <<= shiftAmount;
                Unsafe.Add(ref p, 17) <<= shiftAmount;
                Unsafe.Add(ref p, 18) <<= shiftAmount;
                Unsafe.Add(ref p, 19) <<= shiftAmount;
                Unsafe.Add(ref p, 20) <<= shiftAmount;
                Unsafe.Add(ref p, 21) <<= shiftAmount;
                Unsafe.Add(ref p, 22) <<= shiftAmount;
                Unsafe.Add(ref p, 23) <<= shiftAmount;
                Unsafe.Add(ref p, 24) <<= shiftAmount;
                Unsafe.Add(ref p, 25) <<= shiftAmount;
                Unsafe.Add(ref p, 26) <<= shiftAmount;
                Unsafe.Add(ref p, 27) <<= shiftAmount;
                Unsafe.Add(ref p, 28) <<= shiftAmount;
                Unsafe.Add(ref p, 29) <<= shiftAmount;
                Unsafe.Add(ref p, 30) <<= shiftAmount;
                Unsafe.Add(ref p, 31) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Fast_Basic(Vector256<short> value, int shiftAmount) {
                Vector256<short> rt = value;
                ref short p = ref Unsafe.As<Vector256<short>, short>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Fast_Basic(Vector256<ushort> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Fast_Basic(Vector256<int> value, int shiftAmount) {
                Vector256<int> rt = value;
                ref int p = ref Unsafe.As<Vector256<int>, int>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Fast_Basic(Vector256<uint> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsInt32(), shiftAmount).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Fast_Basic(Vector256<long> value, int shiftAmount) {
                Vector256<long> rt = value;
                ref long p = ref Unsafe.As<Vector256<long>, long>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                Unsafe.Add(ref p, 2) <<= shiftAmount;
                Unsafe.Add(ref p, 3) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Fast_Basic(Vector256<ulong> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsInt64(), shiftAmount).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFD87350CCC  mov         edx,dword ptr [rbp-4]  
                //00007FFD87350CCF  and         edx,3Fh  
                //00007FFD87350CD2  vmovd       xmm1,edx  
                //00007FFD87350CD6  vpsraq      ymm0,ymm0,xmm1  
                //00007FFD87350CDC  vmovups     ymmword ptr [rbp-6630h],ymm0  
#else
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Basic(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Basic(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Basic(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Basic(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{short}, int, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{int}, int, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{long}, int, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Fast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Fast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Fast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Fast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Fast_Basic(Vector256<sbyte> value, int shiftAmount) {
                Vector256<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref rt);
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
                Unsafe.Add(ref p, 16) >>= shiftAmount;
                Unsafe.Add(ref p, 17) >>= shiftAmount;
                Unsafe.Add(ref p, 18) >>= shiftAmount;
                Unsafe.Add(ref p, 19) >>= shiftAmount;
                Unsafe.Add(ref p, 20) >>= shiftAmount;
                Unsafe.Add(ref p, 21) >>= shiftAmount;
                Unsafe.Add(ref p, 22) >>= shiftAmount;
                Unsafe.Add(ref p, 23) >>= shiftAmount;
                Unsafe.Add(ref p, 24) >>= shiftAmount;
                Unsafe.Add(ref p, 25) >>= shiftAmount;
                Unsafe.Add(ref p, 26) >>= shiftAmount;
                Unsafe.Add(ref p, 27) >>= shiftAmount;
                Unsafe.Add(ref p, 28) >>= shiftAmount;
                Unsafe.Add(ref p, 29) >>= shiftAmount;
                Unsafe.Add(ref p, 30) >>= shiftAmount;
                Unsafe.Add(ref p, 31) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Fast_Basic(Vector256<short> value, int shiftAmount) {
                Vector256<short> rt = value;
                ref short p = ref Unsafe.As<Vector256<short>, short>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Fast_Basic(Vector256<int> value, int shiftAmount) {
                Vector256<int> rt = value;
                ref int p = ref Unsafe.As<Vector256<int>, int>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Fast_Basic(Vector256<long> value, int shiftAmount) {
                Vector256<long> rt = value;
                ref long p = ref Unsafe.As<Vector256<long>, long>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Basic(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Basic(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Basic(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Basic(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Basic(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Basic(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Basic(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Basic(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{byte}, int, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Args(Vector256<byte> dummy, int shiftAmount, out Vector256<byte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{short}, int, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{ushort}, int, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Args(Vector256<ushort> dummy, int shiftAmount, out Vector256<ushort> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{int}, int, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{uint}, int, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Args(Vector256<uint> dummy, int shiftAmount, out Vector256<uint> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{long}, int, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{ulong}, int, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Args(Vector256<ulong> dummy, int shiftAmount, out Vector256<ulong> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Core(Vector256<byte> value, int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Core(Vector256<ushort> value, int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Core(Vector256<uint> value, int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Core(Vector256<ulong> value, int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Const(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Const(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Const(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Const(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_ConstCore(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_ConstCore(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_ConstCore(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_ConstCore(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Fast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Fast(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Fast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Fast(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Fast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Fast(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Fast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Fast(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Fast_Basic(Vector256<sbyte> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Fast_Basic(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector256<byte>, byte>(ref rt);
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
                Unsafe.Add(ref p, 16) >>= shiftAmount;
                Unsafe.Add(ref p, 17) >>= shiftAmount;
                Unsafe.Add(ref p, 18) >>= shiftAmount;
                Unsafe.Add(ref p, 19) >>= shiftAmount;
                Unsafe.Add(ref p, 20) >>= shiftAmount;
                Unsafe.Add(ref p, 21) >>= shiftAmount;
                Unsafe.Add(ref p, 22) >>= shiftAmount;
                Unsafe.Add(ref p, 23) >>= shiftAmount;
                Unsafe.Add(ref p, 24) >>= shiftAmount;
                Unsafe.Add(ref p, 25) >>= shiftAmount;
                Unsafe.Add(ref p, 26) >>= shiftAmount;
                Unsafe.Add(ref p, 27) >>= shiftAmount;
                Unsafe.Add(ref p, 28) >>= shiftAmount;
                Unsafe.Add(ref p, 29) >>= shiftAmount;
                Unsafe.Add(ref p, 30) >>= shiftAmount;
                Unsafe.Add(ref p, 31) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Fast_Basic(Vector256<short> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Fast_Basic(Vector256<ushort> value, int shiftAmount) {
                Vector256<ushort> rt = value;
                ref ushort p = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Fast_Basic(Vector256<int> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Fast_Basic(Vector256<uint> value, int shiftAmount) {
                Vector256<uint> rt = value;
                ref uint p = ref Unsafe.As<Vector256<uint>, uint>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Fast_Basic(Vector256<long> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsUInt64(), shiftAmount).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Fast_Basic(Vector256<ulong> value, int shiftAmount) {
                Vector256<ulong> rt = value;
                ref ulong p = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.None; // `.NET 7.0` doesn't have hardware acceleration yet .
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Shuffle(Vector256<float> vector, Vector256<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
                // .NET8 on Avx512: No hardware accelerated.
                //  1475: 		Unsafe.SkipInit<Vector256<float>>(out var value);
                //00007FFDE22ACBE0  sub         rsp,28h  
                //  1476: 		for (int i = 0; i < Vector256<float>.Count; i++)
                //00007FFDE22ACBE4  xor         eax,eax  
                //  1477: 		{
                //  1478: 			uint elementUnsafe = (uint)GetElementUnsafe(in indices, i);
                //00007FFDE22ACBE6  movsxd      r10,eax  
                //00007FFDE22ACBE9  mov         r9d,dword ptr [r8+r10*4]  
                //  1479: 			float value2 = 0f;
                //00007FFDE22ACBED  xorps       xmm0,xmm0  
                //  1480: 			if (elementUnsafe < Vector256<float>.Count)
                //00007FFDE22ACBF0  cmp         r9d,8  
                //00007FFDE22ACBF4  jae         System.Runtime.Intrinsics.Vector256.Shuffle(System.Runtime.Intrinsics.Vector256`1<Single>, System.Runtime.Intrinsics.Vector256`1<Int32>)+01Fh (07FFDE22ACBFFh)  
                //  1481: 			{
                //  1482: 				value2 = GetElementUnsafe(in vector, (int)elementUnsafe);
                //00007FFDE22ACBF6  movsxd      r9,r9d  
                //00007FFDE22ACBF9  movss       xmm0,dword ptr [rdx+r9*4]  
                //  1483: 			}
                //  1484: 			value.SetElementUnsafe(i, value2);
                //00007FFDE22ACBFF  lea         r9,[rsp+8]  
                //00007FFDE22ACC04  movss       dword ptr [r9+r10*4],xmm0  
                //  1476: 		for (int i = 0; i < Vector256<float>.Count; i++)
                //00007FFDE22ACC0A  inc         eax  
                //00007FFDE22ACC0C  cmp         eax,8  
                //00007FFDE22ACC0F  jl          System.Runtime.Intrinsics.Vector256.Shuffle(System.Runtime.Intrinsics.Vector256`1<Single>, System.Runtime.Intrinsics.Vector256`1<Int32>)+06h (07FFDE22ACBE6h)  
                //  1485: 		}
                //  1486: 		return value;
                //00007FFDE22ACC11  movups      xmm0,xmmword ptr [rsp+8]  
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Shuffle(Vector256<double> vector, Vector256<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Shuffle(Vector256<sbyte> vector, Vector256<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
                // .NET8 on Avx512: No hardware accelerated.
                //  1388: 		Unsafe.SkipInit<Vector256<sbyte>>(out var value);
                //00007FFDE22ACA50  sub         rsp,28h  
                //  1389: 		for (int i = 0; i < Vector256<sbyte>.Count; i++)
                //00007FFDE22ACA54  xor         eax,eax  
                //  1390: 		{
                //  1391: 			byte b = (byte)GetElementUnsafe(in indices, i);
                //00007FFDE22ACA56  movsxd      r10,eax  
                //00007FFDE22ACA59  movzx       r9d,byte ptr [r8+r10]  
                //  1392: 			sbyte value2 = 0;
                //00007FFDE22ACA5E  xor         r11d,r11d  
                //  1393: 			if (b < Vector256<sbyte>.Count)
                //00007FFDE22ACA61  cmp         r9d,20h  
                //00007FFDE22ACA65  jge         System.Runtime.Intrinsics.Vector256.Shuffle(System.Runtime.Intrinsics.Vector256`1<SByte>, System.Runtime.Intrinsics.Vector256`1<SByte>)+01Fh (07FFDE22ACA6Fh)  
                //  1394: 			{
                //  1395: 				value2 = GetElementUnsafe(in vector, b);
                //00007FFDE22ACA67  mov         r11d,r9d  
                //00007FFDE22ACA6A  movsx       r11,byte ptr [rdx+r11]  
                //  1396: 			}
                //  1397: 			value.SetElementUnsafe(i, value2);
                //00007FFDE22ACA6F  lea         r9,[rsp+8]  
                //00007FFDE22ACA74  mov         byte ptr [r9+r10],r11b  
                //  1389: 		for (int i = 0; i < Vector256<sbyte>.Count; i++)
                //00007FFDE22ACA78  inc         eax  
                //00007FFDE22ACA7A  cmp         eax,20h  
                //00007FFDE22ACA7D  jl          System.Runtime.Intrinsics.Vector256.Shuffle(System.Runtime.Intrinsics.Vector256`1<SByte>, System.Runtime.Intrinsics.Vector256`1<SByte>)+06h (07FFDE22ACA56h)  
                //  1398: 		}
                //  1399: 		return value;
                //00007FFDE22ACA7F  movups      xmm0,xmmword ptr [rsp+8]  
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Shuffle(Vector256<byte> vector, Vector256<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Shuffle(Vector256<short> vector, Vector256<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Shuffle(Vector256<ushort> vector, Vector256<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Shuffle(Vector256<int> vector, Vector256<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Shuffle(Vector256<uint> vector, Vector256<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Shuffle(Vector256<long> vector, Vector256<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Shuffle(Vector256<ulong> vector, Vector256<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Shuffle_Basic(Vector256<float> vector, Vector256<int> indices) {
                return Shuffle_Basic(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Shuffle_Basic(Vector256<double> vector, Vector256<long> indices) {
                return Shuffle_Basic(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Shuffle_Basic(Vector256<sbyte> vector, Vector256<sbyte> indices) {
                return Shuffle_Basic(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Shuffle_Basic(Vector256<byte> vector, Vector256<byte> indices) {
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
                byte cnt = (byte)Vector256<byte>.Count;
                ref byte q = ref Unsafe.As<Vector256<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector256<byte>, byte>(ref vector);
                ref byte pindices = ref Unsafe.As<Vector256<byte>, byte>(ref indices);
                for (nint i = 0; i < Vector256<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Shuffle_Basic(Vector256<short> vector, Vector256<short> indices) {
                return Shuffle_Basic(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Shuffle_Basic(Vector256<ushort> vector, Vector256<ushort> indices) {
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
                ushort cnt = (ushort)Vector256<ushort>.Count;
                ref ushort q = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector256<ushort>, ushort>(ref vector);
                ref ushort pindices = ref Unsafe.As<Vector256<ushort>, ushort>(ref indices);
                for (nint i = 0; i < Vector256<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Shuffle_Basic(Vector256<int> vector, Vector256<int> indices) {
                return Shuffle_Basic(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Shuffle_Basic(Vector256<uint> vector, Vector256<uint> indices) {
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
                uint cnt = (uint)Vector256<uint>.Count;
                ref uint q = ref Unsafe.As<Vector256<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector256<uint>, uint>(ref vector);
                ref uint pindices = ref Unsafe.As<Vector256<uint>, uint>(ref indices);
                for (nint i = 0; i < Vector256<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Shuffle_Basic(Vector256<long> vector, Vector256<long> indices) {
                return Shuffle_Basic(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Shuffle_Basic(Vector256<ulong> vector, Vector256<ulong> indices) {
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ulong cnt = (ulong)Vector256<ulong>.Count;
                ref ulong q = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector256<ulong>, ulong>(ref vector);
                ref ulong pindices = ref Unsafe.As<Vector256<ulong>, ulong>(ref indices);
                for (nint i = 0; i < Vector256<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1) {
                args0 = indices;
                args1 = default;
            }


            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Shuffle_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Shuffle_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Shuffle_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Shuffle_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Shuffle_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Shuffle_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Shuffle_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Shuffle_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Shuffle_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Shuffle_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }


            /// <inheritdoc cref="IWVectorTraits256.Sum_AcceleratedTypes"/>
            public static TypeCodeFlags Sum_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
                // .NET7~8 on Avx2(Not use Avx512): It has hardware-accelerated.
                //00007FFD87352FB2  mov         rcx,2018012DCC0h  
                //00007FFD87352FBC  vmovups     ymm0,ymmword ptr [rcx]  
                //00007FFD87352FC0  vmovups     ymmword ptr [rbp-75D0h],ymm0  
                //00007FFD87352FC8  vmovups     ymm0,ymmword ptr [rbp-75D0h]  
                //00007FFD87352FD0  vhaddps     ymm0,ymm0,ymmword ptr [rbp-75D0h]  
                //00007FFD87352FD8  vmovups     ymmword ptr [rbp-75F0h],ymm0  
                //00007FFD87352FE0  vmovups     ymm0,ymmword ptr [rbp-75F0h]  
                //00007FFD87352FE8  vhaddps     ymm0,ymm0,ymmword ptr [rbp-75F0h]  
                //00007FFD87352FF0  vmovups     ymmword ptr [rbp-7610h],ymm0  
                //00007FFD87352FF8  vmovups     ymm0,ymmword ptr [rbp-7610h]  
                //00007FFD87353000  vextractf128 xmm0,ymm0,1  
                //00007FFD87353006  vmovups     xmm1,xmmword ptr [rbp-7610h]  
                //00007FFD8735300E  vaddps      xmm0,xmm0,xmm1  
                //00007FFD87353012  vmovss      dword ptr [rbp-7618h],xmm0  
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
                // .NET8 on Avx512: Poor performance!
                //  1606: 		T left = Vector128.Sum(vector._lower);
                //00007FFD875A8780  push        rbp  
                //00007FFD875A8781  sub         rsp,60h  
                //00007FFD875A8785  vzeroupper  
                //00007FFD875A8788  lea         rbp,[rsp+60h]  
                //00007FFD875A878D  mov         qword ptr [rbp+10h],rcx  
                //00007FFD875A8791  mov         rcx,qword ptr [rbp+10h]  
                //00007FFD875A8795  vmovups     xmm0,xmmword ptr [rcx]  
                //00007FFD875A8799  vmovaps     xmmword ptr [rbp-20h],xmm0  
                //00007FFD875A879E  lea         rcx,[rbp-20h]  
                //00007FFD875A87A2  call        qword ptr [CLRStub[MethodDescPrestub]@00007FFD873F7F00 (07FFD873F7F00h)]  
                //00007FFD875A87A8  mov         dword ptr [rbp-4],eax  
                //  1607: 		return Scalar<T>.Add(left, Vector128.Sum(vector._upper));
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector256<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector256<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector256<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector256<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector256.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum_Basic(Vector256<float> value) {
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref value);
                float rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum_Basic(Vector256<double> value) {
                ref double p = ref Unsafe.As<Vector256<double>, double>(ref value);
                double rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum_Basic(Vector256<sbyte> value) {
                ref sbyte p = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref value);
                sbyte rt = (sbyte)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                    + Unsafe.Add(ref p, 16)
                    + Unsafe.Add(ref p, 17)
                    + Unsafe.Add(ref p, 18)
                    + Unsafe.Add(ref p, 19)
                    + Unsafe.Add(ref p, 20)
                    + Unsafe.Add(ref p, 21)
                    + Unsafe.Add(ref p, 22)
                    + Unsafe.Add(ref p, 23)
                    + Unsafe.Add(ref p, 24)
                    + Unsafe.Add(ref p, 25)
                    + Unsafe.Add(ref p, 26)
                    + Unsafe.Add(ref p, 27)
                    + Unsafe.Add(ref p, 28)
                    + Unsafe.Add(ref p, 29)
                    + Unsafe.Add(ref p, 30)
                    + Unsafe.Add(ref p, 31)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum_Basic(Vector256<byte> value) {
                ref byte p = ref Unsafe.As<Vector256<byte>, byte>(ref value);
                byte rt = (byte)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                    + Unsafe.Add(ref p, 16)
                    + Unsafe.Add(ref p, 17)
                    + Unsafe.Add(ref p, 18)
                    + Unsafe.Add(ref p, 19)
                    + Unsafe.Add(ref p, 20)
                    + Unsafe.Add(ref p, 21)
                    + Unsafe.Add(ref p, 22)
                    + Unsafe.Add(ref p, 23)
                    + Unsafe.Add(ref p, 24)
                    + Unsafe.Add(ref p, 25)
                    + Unsafe.Add(ref p, 26)
                    + Unsafe.Add(ref p, 27)
                    + Unsafe.Add(ref p, 28)
                    + Unsafe.Add(ref p, 29)
                    + Unsafe.Add(ref p, 30)
                    + Unsafe.Add(ref p, 31)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum_Basic(Vector256<short> value) {
                ref short p = ref Unsafe.As<Vector256<short>, short>(ref value);
                short rt = (short)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum_Basic(Vector256<ushort> value) {
                ref ushort p = ref Unsafe.As<Vector256<ushort>, ushort>(ref value);
                ushort rt = (ushort)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum_Basic(Vector256<int> value) {
                ref int p = ref Unsafe.As<Vector256<int>, int>(ref value);
                int rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum_Basic(Vector256<uint> value) {
                ref uint p = ref Unsafe.As<Vector256<uint>, uint>(ref value);
                uint rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum_Basic(Vector256<long> value) {
                ref long p = ref Unsafe.As<Vector256<long>, long>(ref value);
                long rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum_Basic(Vector256<ulong> value) {
                ref ulong p = ref Unsafe.As<Vector256<ulong>, ulong>(ref value);
                ulong rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                ;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector256.Widen(source);
                // .NET8 on Avx512: Poor performance!
                //  2374:                     (var low, var high) = Vector256.Widen(Vector256s<Single>.Demo);
                //00007FFD87354139  mov         rdx,2018012DCC0h  
                //00007FFD87354143  vmovups     ymm0,ymmword ptr [rdx]  
                //00007FFD87354147  vmovups     ymmword ptr [rbzzzzzzzp-0A2F0h],ymm0  
                //00007FFD8735414F  lea         rdx,[rbp-0A2F0h]  
                //00007FFD87354156  lea         rcx,[rbp-7BE0h]  
                //00007FFD8735415D  call        qword ptr [CLRStub[MethodDescPrestub]@00007FFD86F055F0 (07FFD86F055F0h)]  
                //00007FFD87354163  vmovups     ymm0,ymmword ptr [rbp-7BE0h]  
                //00007FFD8735416B  vmovups     ymmword ptr [rbp-30h],ymm0  
                //00007FFD87354170  vmovups     ymm0,ymmword ptr [rbp-7BC0h]  
                //00007FFD87354178  vmovups     ymmword ptr [rbp-50h],ymm0  
                //  2375:                     WriteLine(writer, indent, "Widen(Vector256s<Single>.Demo):\t{0}, {1}", low, high);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector256.Widen(source);
                // .NET8 on Avx512: Poor performance!
                //#if  1670: 		return (WidenLower(source), WidenUpper(source));
                //00007FFDE22ACE80  movups      xmm0,xmmword ptr [rdx]  
                //00007FFDE22ACE83  pmovsxbw    xmm1,xmm0  
                //00007FFDE22ACE88  psrldq      xmm0,8  
                //00007FFDE22ACE8D  pmovsxbw    xmm0,xmm0  
                //00007FFDE22ACE92  movups      xmm2,xmmword ptr [rdx+10h]  
                //00007FFDE22ACE96  pmovsxbw    xmm3,xmm2  
                //00007FFDE22ACE9B  psrldq      xmm2,8  
                //00007FFDE22ACEA0  pmovsxbw    xmm2,xmm2  
                //00007FFDE22ACEA5  movups      xmmword ptr [rcx],xmm1  
                //00007FFDE22ACEA8  movups      xmmword ptr [rcx+10h],xmm0  
                //00007FFDE22ACEAC  movups      xmmword ptr [rcx+20h],xmm3  
                //00007FFDE22ACEB0  movups      xmmword ptr [rcx+30h],xmm2  
                //00007FFDE22ACEB4  mov         rax,rcx  
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector256.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper) {
                nint cnt = Vector256<double>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
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
            public static void Widen_Basic(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
                nint cnt = Vector256<short>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
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
            public static void Widen_Basic(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
                nint cnt = Vector256<ushort>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
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
            public static void Widen_Basic(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
                nint cnt = Vector256<int>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
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
            public static void Widen_Basic(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
                nint cnt = Vector256<uint>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
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
            public static void Widen_Basic(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
                nint cnt = Vector256<long>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
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
            public static void Widen_Basic(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
                nint cnt = Vector256<ulong>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
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


            /// <inheritdoc cref="IWVectorTraits256.WidenLower_AcceleratedTypes"/>
            public static TypeCodeFlags WidenLower_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> WidenLower(Vector256<float> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenLower(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (var rt, _) = Vector256.Widen(source);
                return rt;
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> WidenLower(Vector256<sbyte> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenLower(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (var rt, _) = Vector256.Widen(source);
                return rt;
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> WidenLower(Vector256<byte> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenLower(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (var rt, _) = Vector256.Widen(source);
                return rt;
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> WidenLower(Vector256<short> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenLower(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (var rt, _) = Vector256.Widen(source);
                return rt;
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> WidenLower(Vector256<ushort> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenLower(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (var rt, _) = Vector256.Widen(source);
                return rt;
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> WidenLower(Vector256<int> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenLower(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (var rt, _) = Vector256.Widen(source);
                return rt;
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> WidenLower(Vector256<uint> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenLower(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (var rt, _) = Vector256.Widen(source);
                return rt;
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> WidenLower_Basic(Vector256<float> source) {
                UnsafeUtil.SkipInit(out Vector256<double> rt);
                ref FixedArray4<double> p = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref rt);
                ref FixedArray8<float> psource = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> WidenLower_Basic(Vector256<sbyte> source) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                ref FixedArray32<sbyte> psource = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> WidenLower_Basic(Vector256<byte> source) {
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
                ref FixedArray16<ushort> p = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref rt);
                ref FixedArray32<byte> psource = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> WidenLower_Basic(Vector256<short> source) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                ref FixedArray16<short> psource = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> WidenLower_Basic(Vector256<ushort> source) {
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
                ref FixedArray8<uint> p = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref rt);
                ref FixedArray16<ushort> psource = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> WidenLower_Basic(Vector256<int> source) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                ref FixedArray8<int> psource = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenLower(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> WidenLower_Basic(Vector256<uint> source) {
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ref FixedArray4<ulong> p = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref rt);
                ref FixedArray8<uint> psource = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.WidenUpper_AcceleratedTypes"/>
            public static TypeCodeFlags WidenUpper_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> WidenUpper(Vector256<float> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenUpper(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (_, var rt) = Vector256.Widen(source);
                return rt;
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> WidenUpper(Vector256<sbyte> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenUpper(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (_, var rt) = Vector256.Widen(source);
                return rt;
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> WidenUpper(Vector256<byte> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenUpper(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (_, var rt) = Vector256.Widen(source);
                return rt;
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> WidenUpper(Vector256<short> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenUpper(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (_, var rt) = Vector256.Widen(source);
                return rt;
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> WidenUpper(Vector256<ushort> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenUpper(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (_, var rt) = Vector256.Widen(source);
                return rt;
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> WidenUpper(Vector256<int> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenUpper(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (_, var rt) = Vector256.Widen(source);
                return rt;
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> WidenUpper(Vector256<uint> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD && NET8_0_OR_GREATER
                return Vector256.WidenUpper(source);
#elif BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (_, var rt) = Vector256.Widen(source);
                return rt;
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> WidenUpper_Basic(Vector256<float> source) {
                UnsafeUtil.SkipInit(out Vector256<double> rt);
                ref FixedArray4<double> p = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref rt);
                ref FixedArray8<float> psource = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref Unsafe.AddByteOffset(ref source, new IntPtr(Vector256<byte>.Count / 2)));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> WidenUpper_Basic(Vector256<sbyte> source) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                ref FixedArray32<sbyte> psource = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref Unsafe.AddByteOffset(ref source, new IntPtr(Vector256<byte>.Count / 2)));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> WidenUpper_Basic(Vector256<byte> source) {
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
                ref FixedArray16<ushort> p = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref rt);
                ref FixedArray32<byte> psource = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref Unsafe.AddByteOffset(ref source, new IntPtr(Vector256<byte>.Count / 2)));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> WidenUpper_Basic(Vector256<short> source) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                ref FixedArray16<short> psource = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref Unsafe.AddByteOffset(ref source, new IntPtr(Vector256<byte>.Count / 2)));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> WidenUpper_Basic(Vector256<ushort> source) {
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
                ref FixedArray8<uint> p = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref rt);
                ref FixedArray16<ushort> psource = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref Unsafe.AddByteOffset(ref source, new IntPtr(Vector256<byte>.Count / 2)));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> WidenUpper_Basic(Vector256<int> source) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                ref FixedArray8<int> psource = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref Unsafe.AddByteOffset(ref source, new IntPtr(Vector256<byte>.Count / 2)));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.WidenUpper(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> WidenUpper_Basic(Vector256<uint> source) {
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ref FixedArray4<ulong> p = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref rt);
                ref FixedArray8<uint> psource = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref Unsafe.AddByteOffset(ref source, new IntPtr(Vector256<byte>.Count / 2)));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                return rt;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
