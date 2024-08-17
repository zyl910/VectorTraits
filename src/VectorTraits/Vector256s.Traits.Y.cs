#if NETCOREAPP3_0_OR_GREATER
#define SHORT_CIRCUIT_GENERIC
#endif // NETCOREAPP3_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits {
    using BaseStatics = WVectorTraits256Base.Statics;

    partial class Vector256s {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits256.YBitToByte_IsAccelerated"/>
        public static bool YBitToByte_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToByte_IsAccelerated;
#else
                return _instance.YBitToByte_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YBitToByte"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YBitToByte(uint value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToByte(value);
#else
            return _instance.YBitToByte(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YBitToInt16_IsAccelerated"/>
        public static bool YBitToInt16_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToInt16_IsAccelerated;
#else
                return _instance.YBitToInt16_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YBitToInt16"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YBitToInt16(uint value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToInt16(value);
#else
            return _instance.YBitToInt16(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YBitToInt32_IsAccelerated"/>
        public static bool YBitToInt32_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToInt32_IsAccelerated;
#else
                return _instance.YBitToInt32_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YBitToInt32"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YBitToInt32(uint value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToInt32(value);
#else
            return _instance.YBitToInt32(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YBitToInt64_IsAccelerated"/>
        public static bool YBitToInt64_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToInt64_IsAccelerated;
#else
                return _instance.YBitToInt64_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YBitToInt64"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YBitToInt64(uint value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToInt64(value);
#else
            return _instance.YBitToInt64(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YClamp_AcceleratedTypes"/>
        public static TypeCodeFlags YClamp_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YClamp_AcceleratedTypes;
#else
                return _instance.YClamp_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{float}, Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YClamp(Vector256<float> value, Vector256<float> amin, Vector256<float> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{double}, Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YClamp(Vector256<double> value, Vector256<double> amin, Vector256<double> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YClamp(Vector256<sbyte> value, Vector256<sbyte> amin, Vector256<sbyte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YClamp(Vector256<byte> value, Vector256<byte> amin, Vector256<byte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YClamp(Vector256<short> value, Vector256<short> amin, Vector256<short> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YClamp(Vector256<ushort> value, Vector256<ushort> amin, Vector256<ushort> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YClamp(Vector256<int> value, Vector256<int> amin, Vector256<int> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YClamp(Vector256<uint> value, Vector256<uint> amin, Vector256<uint> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YClamp(Vector256<long> value, Vector256<long> amin, Vector256<long> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YClamp(Vector256<ulong> value, Vector256<ulong> amin, Vector256<ulong> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YCopySign_AcceleratedTypes"/>
        public static TypeCodeFlags YCopySign_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YCopySign_AcceleratedTypes;
#else
                return _instance.YCopySign_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YCopySign(Vector256<float> value, Vector256<float> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YCopySign(Vector256<double> value, Vector256<double> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YCopySign(Vector256<sbyte> value, Vector256<sbyte> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YCopySign(Vector256<short> value, Vector256<short> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YCopySign(Vector256<int> value, Vector256<int> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YCopySign(Vector256<long> value, Vector256<long> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2Unzip_AcceleratedTypes;
#else
                return _instance.YGroup2Unzip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup2Unzip(Vector256<float> data0, Vector256<float> data1, out Vector256<float> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup2Unzip(Vector256<double> data0, Vector256<double> data1, out Vector256<double> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup2Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup2Unzip(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup2Unzip(Vector256<short> data0, Vector256<short> data1, out Vector256<short> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup2Unzip(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup2Unzip(Vector256<int> data0, Vector256<int> data1, out Vector256<int> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup2Unzip(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup2Unzip(Vector256<long> data0, Vector256<long> data1, out Vector256<long> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup2Unzip(Vector256<ulong> data0, Vector256<ulong> data1, out Vector256<ulong> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> YGroup2Unzip(Vector256<ExInt128> data0, Vector256<ExInt128> data1, out Vector256<ExInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> YGroup2Unzip(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, out Vector256<ExUInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YGroup2Unzip_Bit128<T>(Vector256<T> data0, Vector256<T> data1, out Vector256<T> y) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip_Bit128(data0, data1, out y);
#elif SHORT_CIRCUIT_GENERIC
            if (Avx.IsSupported && Avx2.IsSupported) {
                return WVectorTraits256Avx2.Statics.YGroup2Unzip_Bit128(data0, data1, out y);
            } else {
                return BaseStatics.YGroup2Unzip_Bit128(data0, data1, out y);
            }
#else
            return _instance.YGroup2Unzip_Bit128(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2UnzipEven_AcceleratedTypes;
#else
                return _instance.YGroup2UnzipEven_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup2UnzipEven(Vector256<float> data0, Vector256<float> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup2UnzipEven(Vector256<double> data0, Vector256<double> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup2UnzipEven(Vector256<sbyte> data0, Vector256<sbyte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup2UnzipEven(Vector256<byte> data0, Vector256<byte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup2UnzipEven(Vector256<short> data0, Vector256<short> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup2UnzipEven(Vector256<ushort> data0, Vector256<ushort> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup2UnzipEven(Vector256<int> data0, Vector256<int> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup2UnzipEven(Vector256<uint> data0, Vector256<uint> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup2UnzipEven(Vector256<long> data0, Vector256<long> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup2UnzipEven(Vector256<ulong> data0, Vector256<ulong> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> YGroup2UnzipEven(Vector256<ExInt128> data0, Vector256<ExInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> YGroup2UnzipEven(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2UnzipOdd_AcceleratedTypes;
#else
                return _instance.YGroup2UnzipOdd_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup2UnzipOdd(Vector256<float> data0, Vector256<float> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup2UnzipOdd(Vector256<double> data0, Vector256<double> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup2UnzipOdd(Vector256<sbyte> data0, Vector256<sbyte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup2UnzipOdd(Vector256<byte> data0, Vector256<byte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup2UnzipOdd(Vector256<short> data0, Vector256<short> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup2UnzipOdd(Vector256<ushort> data0, Vector256<ushort> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup2UnzipOdd(Vector256<int> data0, Vector256<int> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup2UnzipOdd(Vector256<uint> data0, Vector256<uint> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup2UnzipOdd(Vector256<long> data0, Vector256<long> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup2UnzipOdd(Vector256<ulong> data0, Vector256<ulong> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> YGroup2UnzipOdd(Vector256<ExInt128> data0, Vector256<ExInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> YGroup2UnzipOdd(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2Zip_AcceleratedTypes;
#else
                return _instance.YGroup2Zip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup2Zip(Vector256<float> x, Vector256<float> y, out Vector256<float> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup2Zip(Vector256<double> x, Vector256<double> y, out Vector256<double> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup2Zip(Vector256<sbyte> x, Vector256<sbyte> y, out Vector256<sbyte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup2Zip(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup2Zip(Vector256<short> x, Vector256<short> y, out Vector256<short> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup2Zip(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup2Zip(Vector256<int> x, Vector256<int> y, out Vector256<int> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup2Zip(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup2Zip(Vector256<long> x, Vector256<long> y, out Vector256<long> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup2Zip(Vector256<ulong> x, Vector256<ulong> y, out Vector256<ulong> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> YGroup2Zip(Vector256<ExInt128> x, Vector256<ExInt128> y, out Vector256<ExInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> YGroup2Zip(Vector256<ExUInt128> x, Vector256<ExUInt128> y, out Vector256<ExUInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YGroup2Zip_Bit128<T>(Vector256<T> x, Vector256<T> y, out Vector256<T> data1) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip_Bit128(x, y, out data1);
#elif SHORT_CIRCUIT_GENERIC
            if (Avx.IsSupported && Avx2.IsSupported) {
                return WVectorTraits256Avx2.Statics.YGroup2Zip_Bit128(x, y, out data1);
            } else {
                return BaseStatics.YGroup2Zip_Bit128(x, y, out data1);
            }
#else
            return _instance.YGroup2Zip_Bit128(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2ZipHigh_AcceleratedTypes;
#else
                return _instance.YGroup2ZipHigh_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup2ZipHigh(Vector256<float> x, Vector256<float> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup2ZipHigh(Vector256<double> x, Vector256<double> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup2ZipHigh(Vector256<sbyte> x, Vector256<sbyte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup2ZipHigh(Vector256<byte> x, Vector256<byte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup2ZipHigh(Vector256<short> x, Vector256<short> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup2ZipHigh(Vector256<ushort> x, Vector256<ushort> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup2ZipHigh(Vector256<int> x, Vector256<int> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup2ZipHigh(Vector256<uint> x, Vector256<uint> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup2ZipHigh(Vector256<long> x, Vector256<long> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup2ZipHigh(Vector256<ulong> x, Vector256<ulong> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> YGroup2ZipHigh(Vector256<ExInt128> x, Vector256<ExInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> YGroup2ZipHigh(Vector256<ExUInt128> x, Vector256<ExUInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2ZipLow_AcceleratedTypes;
#else
                return _instance.YGroup2ZipLow_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup2ZipLow(Vector256<float> x, Vector256<float> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup2ZipLow(Vector256<double> x, Vector256<double> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup2ZipLow(Vector256<sbyte> x, Vector256<sbyte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup2ZipLow(Vector256<byte> x, Vector256<byte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup2ZipLow(Vector256<short> x, Vector256<short> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup2ZipLow(Vector256<ushort> x, Vector256<ushort> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup2ZipLow(Vector256<int> x, Vector256<int> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup2ZipLow(Vector256<uint> x, Vector256<uint> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup2ZipLow(Vector256<long> x, Vector256<long> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup2ZipLow(Vector256<ulong> x, Vector256<ulong> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> YGroup2ZipLow(Vector256<ExInt128> x, Vector256<ExInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> YGroup2ZipLow(Vector256<ExUInt128> x, Vector256<ExUInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup3Unzip_AcceleratedTypes;
#else
                return _instance.YGroup3Unzip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup3Unzip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, out Vector256<float> y, out Vector256<float> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup3Unzip(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, out Vector256<double> y, out Vector256<double> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup3Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> y, out Vector256<sbyte> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup3Unzip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> y, out Vector256<byte> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup3Unzip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> y, out Vector256<short> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup3Unzip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> y, out Vector256<ushort> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup3Unzip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> y, out Vector256<int> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup3Unzip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> y, out Vector256<uint> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup3Unzip(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, out Vector256<long> y, out Vector256<long> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup3Unzip(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, out Vector256<ulong> y, out Vector256<ulong> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YGroup3Unzip_Bit128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, out Vector256<T> y, out Vector256<T> z) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup3UnzipX2_AcceleratedTypes;
#else
                return _instance.YGroup3UnzipX2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup3UnzipX2(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, Vector256<float> data4, Vector256<float> data5, out Vector256<float> xB, out Vector256<float> y, out Vector256<float> yB, out Vector256<float> z, out Vector256<float> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup3UnzipX2(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, Vector256<double> data4, Vector256<double> data5, out Vector256<double> xB, out Vector256<double> y, out Vector256<double> yB, out Vector256<double> z, out Vector256<double> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup3UnzipX2(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, Vector256<sbyte> data4, Vector256<sbyte> data5, out Vector256<sbyte> xB, out Vector256<sbyte> y, out Vector256<sbyte> yB, out Vector256<sbyte> z, out Vector256<sbyte> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup3UnzipX2(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, Vector256<byte> data4, Vector256<byte> data5, out Vector256<byte> xB, out Vector256<byte> y, out Vector256<byte> yB, out Vector256<byte> z, out Vector256<byte> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup3UnzipX2(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, Vector256<short> data4, Vector256<short> data5, out Vector256<short> xB, out Vector256<short> y, out Vector256<short> yB, out Vector256<short> z, out Vector256<short> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup3UnzipX2(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, Vector256<ushort> data4, Vector256<ushort> data5, out Vector256<ushort> xB, out Vector256<ushort> y, out Vector256<ushort> yB, out Vector256<ushort> z, out Vector256<ushort> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup3UnzipX2(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, Vector256<int> data4, Vector256<int> data5, out Vector256<int> xB, out Vector256<int> y, out Vector256<int> yB, out Vector256<int> z, out Vector256<int> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup3UnzipX2(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, Vector256<uint> data4, Vector256<uint> data5, out Vector256<uint> xB, out Vector256<uint> y, out Vector256<uint> yB, out Vector256<uint> z, out Vector256<uint> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup3UnzipX2(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, Vector256<long> data4, Vector256<long> data5, out Vector256<long> xB, out Vector256<long> y, out Vector256<long> yB, out Vector256<long> z, out Vector256<long> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup3UnzipX2(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, Vector256<ulong> data4, Vector256<ulong> data5, out Vector256<ulong> xB, out Vector256<ulong> y, out Vector256<ulong> yB, out Vector256<ulong> z, out Vector256<ulong> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YGroup3UnzipX2_Bit128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3, Vector256<T> data4, Vector256<T> data5, out Vector256<T> xB, out Vector256<T> y, out Vector256<T> yB, out Vector256<T> z, out Vector256<T> zB) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup4Unzip_AcceleratedTypes;
#else
                return _instance.YGroup4Unzip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup4Unzip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, out Vector256<float> y, out Vector256<float> z, out Vector256<float> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup4Unzip(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, out Vector256<double> y, out Vector256<double> z, out Vector256<double> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup4Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> y, out Vector256<sbyte> z, out Vector256<sbyte> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup4Unzip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> y, out Vector256<byte> z, out Vector256<byte> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup4Unzip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> y, out Vector256<short> z, out Vector256<short> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup4Unzip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> y, out Vector256<ushort> z, out Vector256<ushort> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup4Unzip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> y, out Vector256<int> z, out Vector256<int> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup4Unzip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> y, out Vector256<uint> z, out Vector256<uint> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup4Unzip(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> y, out Vector256<long> z, out Vector256<long> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup4Unzip(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> y, out Vector256<ulong> z, out Vector256<ulong> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> YGroup4Unzip(Vector256<ExInt128> data0, Vector256<ExInt128> data1, Vector256<ExInt128> data2, Vector256<ExInt128> data3, out Vector256<ExInt128> y, out Vector256<ExInt128> z, out Vector256<ExInt128> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> YGroup4Unzip(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, Vector256<ExUInt128> data2, Vector256<ExUInt128> data3, out Vector256<ExUInt128> y, out Vector256<ExUInt128> z, out Vector256<ExUInt128> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YGroup4Unzip_Bit128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3, out Vector256<T> y, out Vector256<T> z, out Vector256<T> w) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
#elif SHORT_CIRCUIT_GENERIC
            if (Avx.IsSupported && Avx2.IsSupported) {
                return WVectorTraits256Avx2.Statics.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
            } else {
                return BaseStatics.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
            }
#else
            return _instance.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup4Zip_AcceleratedTypes;
#else
                return _instance.YGroup4Zip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }
        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YGroup4Zip(Vector256<float> x, Vector256<float> y, Vector256<float> z, Vector256<float> w, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YGroup4Zip(Vector256<double> x, Vector256<double> y, Vector256<double> z, Vector256<double> w, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YGroup4Zip(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, Vector256<sbyte> w, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YGroup4Zip(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, Vector256<byte> w, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YGroup4Zip(Vector256<short> x, Vector256<short> y, Vector256<short> z, Vector256<short> w, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YGroup4Zip(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, Vector256<ushort> w, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YGroup4Zip(Vector256<int> x, Vector256<int> y, Vector256<int> z, Vector256<int> w, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YGroup4Zip(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, Vector256<uint> w, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YGroup4Zip(Vector256<long> x, Vector256<long> y, Vector256<long> z, Vector256<long> w, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YGroup4Zip(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, Vector256<ulong> w, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> YGroup4Zip(Vector256<ExInt128> x, Vector256<ExInt128> y, Vector256<ExInt128> z, Vector256<ExInt128> w, out Vector256<ExInt128> data1, out Vector256<ExInt128> data2, out Vector256<ExInt128> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> YGroup4Zip(Vector256<ExUInt128> x, Vector256<ExUInt128> y, Vector256<ExUInt128> z, Vector256<ExUInt128> w, out Vector256<ExUInt128> data1, out Vector256<ExUInt128> data2, out Vector256<ExUInt128> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YGroup4Zip_Bit128<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w, out Vector256<T> data1, out Vector256<T> data2, out Vector256<T> data3) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
#elif SHORT_CIRCUIT_GENERIC
            if (Avx.IsSupported && Avx2.IsSupported) {
                return WVectorTraits256Avx2.Statics.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
            } else {
                return BaseStatics.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
            }
#else
            return _instance.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup6Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YGroup6Unzip_Bit128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3, Vector256<T> data4, Vector256<T> data5, out Vector256<T> y, out Vector256<T> z, out Vector256<T> w, out Vector256<T> u, out Vector256<T> v) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup6Unzip_Bit128(data0, data1, data2, data3, data4, data5, out y, out z, out w, out u, out v);
#else
            return _instance.YGroup6Unzip_Bit128(data0, data1, data2, data3, data4, data5, out y, out z, out w, out u, out v);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YGroup6Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YGroup6Zip_Bit128<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w, Vector256<T> u, Vector256<T> v, out Vector256<T> data1, out Vector256<T> data2, out Vector256<T> data3, out Vector256<T> data4, out Vector256<T> data5) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup6Zip_Bit128(x, y, z, w, u, v, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup6Zip_Bit128(x, y, z, w, u, v, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue_AcceleratedTypes"/>
        public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsAllTrue_AcceleratedTypes;
#else
                return _instance.YIsAllTrue_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool YIsAllTrue<T>(Vector256<T> value) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsAllTrue(value);
#else
            return _instance.YIsAllTrue(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
        public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsAnyTrue_AcceleratedTypes;
#else
                return _instance.YIsAnyTrue_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsAnyTrue(value);
#else
            return _instance.YIsAnyTrue(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger_AcceleratedTypes"/>
        public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsEvenInteger_AcceleratedTypes;
#else
                return _instance.YIsEvenInteger_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsEvenInteger(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsEvenInteger(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YIsEvenInteger(Vector256<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YIsEvenInteger(Vector256<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YIsEvenInteger(Vector256<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YIsEvenInteger(Vector256<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsEvenInteger(Vector256<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YIsEvenInteger(Vector256<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsEvenInteger(Vector256<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YIsEvenInteger(Vector256<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsFinite_AcceleratedTypes"/>
        public static TypeCodeFlags YIsFinite_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsFinite_AcceleratedTypes;
#else
                return _instance.YIsFinite_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsFinite(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsFinite(value);
#else
            return _instance.YIsFinite(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsFinite(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsFinite(value);
#else
            return _instance.YIsFinite(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsInfinity_AcceleratedTypes"/>
        public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsInfinity_AcceleratedTypes;
#else
                return _instance.YIsInfinity_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsInfinity(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinity(value);
#else
            return _instance.YIsInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsInfinity(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinity(value);
#else
            return _instance.YIsInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN_AcceleratedTypes"/>
        public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsInfinityOrNaN_AcceleratedTypes;
#else
                return _instance.YIsInfinityOrNaN_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsInfinityOrNaN(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinityOrNaN(value);
#else
            return _instance.YIsInfinityOrNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsInfinityOrNaN(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinityOrNaN(value);
#else
            return _instance.YIsInfinityOrNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsInteger_AcceleratedTypes"/>
        public static TypeCodeFlags YIsInteger_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsInteger_AcceleratedTypes;
#else
                return _instance.YIsInteger_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsInteger(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInteger(value);
#else
            return _instance.YIsInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsInteger(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInteger(value);
#else
            return _instance.YIsInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNaN_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNaN_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNaN_AcceleratedTypes;
#else
                return _instance.YIsNaN_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsNaN(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNaN(value);
#else
            return _instance.YIsNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsNaN(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNaN(value);
#else
            return _instance.YIsNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNegative_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNegative_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNegative_AcceleratedTypes;
#else
                return _instance.YIsNegative_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsNegative(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsNegative(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YIsNegative(Vector256<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YIsNegative(Vector256<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsNegative(Vector256<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsNegative(Vector256<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNegativeInfinity_AcceleratedTypes;
#else
                return _instance.YIsNegativeInfinity_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsNegativeInfinity(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeInfinity(value);
#else
            return _instance.YIsNegativeInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsNegativeInfinity(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeInfinity(value);
#else
            return _instance.YIsNegativeInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNegativeZero_AcceleratedTypes;
#else
                return _instance.YIsNegativeZero_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsNegativeZero(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeZero(value);
#else
            return _instance.YIsNegativeZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsNegativeZero(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeZero(value);
#else
            return _instance.YIsNegativeZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNormal_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNormal_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNormal_AcceleratedTypes;
#else
                return _instance.YIsNormal_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsNormal(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNormal(value);
#else
            return _instance.YIsNormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsNormal(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNormal(value);
#else
            return _instance.YIsNormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNotEquals_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNotEquals_AcceleratedTypes;
#else
                return _instance.YIsNotEquals_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YIsNotEquals(Vector256<float> left, Vector256<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YIsNotEquals(Vector256<double> left, Vector256<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YIsNotEquals(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YIsNotEquals(Vector256<byte> left, Vector256<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YIsNotEquals(Vector256<short> left, Vector256<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YIsNotEquals(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsNotEquals(Vector256<int> left, Vector256<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YIsNotEquals(Vector256<uint> left, Vector256<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsNotEquals(Vector256<long> left, Vector256<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YIsNotEquals(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNotNaN_AcceleratedTypes;
#else
                return _instance.YIsNotNaN_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsNotNaN(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotNaN(value);
#else
            return _instance.YIsNotNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsNotNaN(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotNaN(value);
#else
            return _instance.YIsNotNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger_AcceleratedTypes"/>
        public static TypeCodeFlags YIsOddInteger_AcceleratedTypes
        {
            get
            {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsOddInteger_AcceleratedTypes;
#else
                return _instance.YIsOddInteger_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsOddInteger(Vector256<float> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsOddInteger(Vector256<double> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YIsOddInteger(Vector256<sbyte> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YIsOddInteger(Vector256<byte> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YIsOddInteger(Vector256<short> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YIsOddInteger(Vector256<ushort> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsOddInteger(Vector256<int> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YIsOddInteger(Vector256<uint> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsOddInteger(Vector256<long> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YIsOddInteger(Vector256<ulong> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsPositive_AcceleratedTypes"/>
        public static TypeCodeFlags YIsPositive_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsPositive_AcceleratedTypes;
#else
                return _instance.YIsPositive_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsPositive(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsPositive(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YIsPositive(Vector256<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YIsPositive(Vector256<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsPositive(Vector256<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsPositive(Vector256<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity_AcceleratedTypes"/>
        public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsPositiveInfinity_AcceleratedTypes;
#else
                return _instance.YIsPositiveInfinity_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsPositiveInfinity(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositiveInfinity(value);
#else
            return _instance.YIsPositiveInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsPositiveInfinity(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositiveInfinity(value);
#else
            return _instance.YIsPositiveInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal_AcceleratedTypes"/>
        public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsSubnormal_AcceleratedTypes;
#else
                return _instance.YIsSubnormal_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsSubnormal(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsSubnormal(value);
#else
            return _instance.YIsSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsSubnormal(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsSubnormal(value);
#else
            return _instance.YIsSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsZero_AcceleratedTypes"/>
        public static TypeCodeFlags YIsZero_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsZero_AcceleratedTypes;
#else
                return _instance.YIsZero_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsZero(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsZero(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YIsZero(Vector256<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YIsZero(Vector256<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YIsZero(Vector256<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YIsZero(Vector256<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsZero(Vector256<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YIsZero(Vector256<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsZero(Vector256<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YIsZero(Vector256<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal_AcceleratedTypes"/>
        public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsZeroOrSubnormal_AcceleratedTypes;
#else
                return _instance.YIsZeroOrSubnormal_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YIsZeroOrSubnormal(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZeroOrSubnormal(value);
#else
            return _instance.YIsZeroOrSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YIsZeroOrSubnormal(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZeroOrSubnormal(value);
#else
            return _instance.YIsZeroOrSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YMaxNumber_AcceleratedTypes"/>
        public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YMaxNumber_AcceleratedTypes;
#else
                return _instance.YMaxNumber_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YMaxNumber(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YMaxNumber(Vector256<float> left, Vector256<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YMaxNumber(left, right);
#else
            return _instance.YMaxNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YMaxNumber(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YMaxNumber(Vector256<double> left, Vector256<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YMaxNumber(left, right);
#else
            return _instance.YMaxNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YMinNumber_AcceleratedTypes"/>
        public static TypeCodeFlags YMinNumber_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YMinNumber_AcceleratedTypes;
#else
                return _instance.YMinNumber_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YMinNumber(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YMinNumber(Vector256<float> left, Vector256<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YMinNumber(left, right);
#else
            return _instance.YMinNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YMinNumber(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YMinNumber(Vector256<double> left, Vector256<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YMinNumber(left, right);
#else
            return _instance.YMinNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_AcceleratedTypes;
#else
                return _instance.YNarrowSaturate_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturate_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{short}, Vector256{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YNarrowSaturate(Vector256<short> lower, Vector256<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ushort}, Vector256{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YNarrowSaturate(Vector256<ushort> lower, Vector256<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{int}, Vector256{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YNarrowSaturate(Vector256<int> lower, Vector256<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{uint}, Vector256{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YNarrowSaturate(Vector256<uint> lower, Vector256<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{long}, Vector256{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YNarrowSaturate(Vector256<long> lower, Vector256<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ulong}, Vector256{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YNarrowSaturate(Vector256<ulong> lower, Vector256<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_AcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{short}, Vector256{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YNarrowSaturateUnsigned(Vector256<short> lower, Vector256<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{int}, Vector256{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YNarrowSaturateUnsigned(Vector256<int> lower, Vector256<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{long}, Vector256{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YNarrowSaturateUnsigned(Vector256<long> lower, Vector256<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YOrNot_AcceleratedTypes"/>
        public static TypeCodeFlags YOrNot_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YOrNot_AcceleratedTypes;
#else
                return _instance.YOrNot_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YOrNot{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YOrNot<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YOrNot(left, right);
#else
            return _instance.YOrNot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YRoundToEven_AcceleratedTypes"/>
        public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YRoundToEven_AcceleratedTypes;
#else
                return _instance.YRoundToEven_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YRoundToEven(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToEven(value);
#else
            return _instance.YRoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YRoundToEven(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToEven(value);
#else
            return _instance.YRoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YRoundToZero_AcceleratedTypes"/>
        public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YRoundToZero_AcceleratedTypes;
#else
                return _instance.YRoundToZero_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YRoundToZero(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToZero(value);
#else
            return _instance.YRoundToZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YRoundToZero(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToZero(value);
#else
            return _instance.YRoundToZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleG2_AcceleratedTypes;
#else
                return _instance.YShuffleG2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleG2(Vector256<float> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleG2(Vector256<double> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleG2(Vector256<sbyte> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleG2(Vector256<byte> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleG2(Vector256<short> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleG2(Vector256<ushort> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleG2(Vector256<int> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleG2(Vector256<uint> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleG2(Vector256<long> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleG2(Vector256<ulong> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleG2_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleG2_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleG2_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleG2_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleG2_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleG2_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleG2_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleG2_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleG2_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleG2_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleG4_AcceleratedTypes;
#else
                return _instance.YShuffleG4_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleG4(Vector256<float> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleG4(Vector256<double> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleG4(Vector256<sbyte> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleG4(Vector256<byte> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleG4(Vector256<short> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleG4(Vector256<ushort> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleG4(Vector256<int> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleG4(Vector256<uint> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleG4(Vector256<long> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleG4(Vector256<ulong> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleG4_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleG4_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleG4_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleG4_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleG4_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleG4_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleG4_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleG4_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleG4_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleG4_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleG4X2_AcceleratedTypes;
#else
                return _instance.YShuffleG4X2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{float}, Vector256{float}, ShuffleControlG4, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleG4X2(Vector256<float> source0, Vector256<float> source1, ShuffleControlG4 control, out Vector256<float> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{double}, Vector256{double}, ShuffleControlG4, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleG4X2(Vector256<double> source0, Vector256<double> source1, ShuffleControlG4 control, out Vector256<double> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleG4X2(Vector256<sbyte> source0, Vector256<sbyte> source1, ShuffleControlG4 control, out Vector256<sbyte> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleG4X2(Vector256<byte> source0, Vector256<byte> source1, ShuffleControlG4 control, out Vector256<byte> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{short}, Vector256{short}, ShuffleControlG4, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleG4X2(Vector256<short> source0, Vector256<short> source1, ShuffleControlG4 control, out Vector256<short> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleG4X2(Vector256<ushort> source0, Vector256<ushort> source1, ShuffleControlG4 control, out Vector256<ushort> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{int}, Vector256{int}, ShuffleControlG4, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleG4X2(Vector256<int> source0, Vector256<int> source1, ShuffleControlG4 control, out Vector256<int> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{uint}, Vector256{uint}, ShuffleControlG4, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleG4X2(Vector256<uint> source0, Vector256<uint> source1, ShuffleControlG4 control, out Vector256<uint> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{long}, Vector256{long}, ShuffleControlG4, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleG4X2(Vector256<long> source0, Vector256<long> source1, ShuffleControlG4 control, out Vector256<long> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleG4X2(Vector256<ulong> source0, Vector256<ulong> source1, ShuffleControlG4 control, out Vector256<ulong> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{float}, Vector256{float}, ShuffleControlG4, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleG4X2_Const(Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<float> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{double}, Vector256{double}, ShuffleControlG4, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleG4X2_Const(Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<double> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleG4X2_Const(Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<sbyte> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleG4X2_Const(Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<byte> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{short}, Vector256{short}, ShuffleControlG4, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleG4X2_Const(Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<short> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleG4X2_Const(Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ushort> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{int}, Vector256{int}, ShuffleControlG4, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleG4X2_Const(Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<int> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{uint}, Vector256{uint}, ShuffleControlG4, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleG4X2_Const(Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<uint> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{long}, Vector256{long}, ShuffleControlG4, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleG4X2_Const(Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<long> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleG4X2_Const(Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ulong> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleInsert_AcceleratedTypes;
#else
                return _instance.YShuffleInsert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleInsert(Vector256<float> back, Vector256<float> vector, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleInsert(Vector256<double> back, Vector256<double> vector, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleInsert(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleInsert(Vector256<short> back, Vector256<short> vector, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleInsert(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleInsert(Vector256<int> back, Vector256<int> vector, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleInsert(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleInsert(Vector256<long> back, Vector256<long> vector, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleInsert(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleInsert_Core(Vector256<float> back, Vector256<float> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleInsert_Core(Vector256<double> back, Vector256<double> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleInsert_Core(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert_Core(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleInsert_Core(Vector256<short> back, Vector256<short> vector, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleInsert_Core(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleInsert_Core(Vector256<int> back, Vector256<int> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleInsert_Core(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleInsert_Core(Vector256<long> back, Vector256<long> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleInsert_Core(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleKernel_AcceleratedTypes;
#else
                return _instance.YShuffleKernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleKernel(Vector256<float> vector, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleKernel(Vector256<double> vector, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleKernel(Vector256<sbyte> vector, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel(Vector256<byte> vector, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleKernel(Vector256<short> vector, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleKernel(Vector256<ushort> vector, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleKernel(Vector256<int> vector, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleKernel(Vector256<uint> vector, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleKernel(Vector256<long> vector, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleKernel(Vector256<ulong> vector, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleKernel_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleKernel_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleKernel_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleKernel_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleKernel_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleKernel_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleKernel_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleKernel_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleKernel_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX2_AcceleratedTypes;
#else
                return _instance.YShuffleX2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX2Insert_AcceleratedTypes;
#else
                return _instance.YShuffleX2Insert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX2Kernel_AcceleratedTypes;
#else
                return _instance.YShuffleX2Kernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX3_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3_AcceleratedTypes;
#else
                return _instance.YShuffleX3_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3Insert_AcceleratedTypes;
#else
                return _instance.YShuffleX3Insert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3Kernel_AcceleratedTypes;
#else
                return _instance.YShuffleX3Kernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX4_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX4_AcceleratedTypes;
#else
                return _instance.YShuffleX4_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX4Insert_AcceleratedTypes;
#else
                return _instance.YShuffleX4Insert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX4Kernel_AcceleratedTypes;
#else
                return _instance.YShuffleX4Kernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YSign_AcceleratedTypes"/>
        public static TypeCodeFlags YSign_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YSign_AcceleratedTypes;
#else
                return _instance.YSign_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YSign(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YSign(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YSign(Vector256<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YSign(Vector256<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YSign(Vector256<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YSign(Vector256<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.YSignFloat_AcceleratedTypes"/>
        public static TypeCodeFlags YSignFloat_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YSignFloat_AcceleratedTypes;
#else
                return _instance.YSignFloat_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YSignFloat(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YSignFloat(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSignFloat(value);
#else
            return _instance.YSignFloat(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.YSignFloat(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YSignFloat(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSignFloat(value);
#else
            return _instance.YSignFloat(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


#endif
    }
}
