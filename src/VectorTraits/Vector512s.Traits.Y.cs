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
using Zyl.VectorTraits.Impl.AVector512;

namespace Zyl.VectorTraits {
    using BaseStatics = WVectorTraits512Base.Statics;

    partial class Vector512s {
#if NET8_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits512.YBitToByte_IsAccelerated"/>
        public static bool YBitToByte_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToByte_IsAccelerated;
#else
                return _instance.YBitToByte_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YBitToByte"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YBitToByte(ulong value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToByte(value);
#else
            return _instance.YBitToByte(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YBitToInt16_IsAccelerated"/>
        public static bool YBitToInt16_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToInt16_IsAccelerated;
#else
                return _instance.YBitToInt16_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YBitToInt16"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YBitToInt16(ulong value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToInt16(value);
#else
            return _instance.YBitToInt16(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YBitToInt32_IsAccelerated"/>
        public static bool YBitToInt32_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToInt32_IsAccelerated;
#else
                return _instance.YBitToInt32_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YBitToInt32"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YBitToInt32(ulong value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToInt32(value);
#else
            return _instance.YBitToInt32(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YBitToInt64_IsAccelerated"/>
        public static bool YBitToInt64_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToInt64_IsAccelerated;
#else
                return _instance.YBitToInt64_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YBitToInt64"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YBitToInt64(ulong value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToInt64(value);
#else
            return _instance.YBitToInt64(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YClamp_AcceleratedTypes"/>
        public static TypeCodeFlags YClamp_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YClamp_AcceleratedTypes;
#else
                return _instance.YClamp_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YClamp(Vector512<float> value, Vector512<float> amin, Vector512<float> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{double}, Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YClamp(Vector512<double> value, Vector512<double> amin, Vector512<double> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YClamp(Vector512<sbyte> value, Vector512<sbyte> amin, Vector512<sbyte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YClamp(Vector512<byte> value, Vector512<byte> amin, Vector512<byte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YClamp(Vector512<short> value, Vector512<short> amin, Vector512<short> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YClamp(Vector512<ushort> value, Vector512<ushort> amin, Vector512<ushort> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YClamp(Vector512<int> value, Vector512<int> amin, Vector512<int> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YClamp(Vector512<uint> value, Vector512<uint> amin, Vector512<uint> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YClamp(Vector512<long> value, Vector512<long> amin, Vector512<long> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YClamp(Vector512<ulong> value, Vector512<ulong> amin, Vector512<ulong> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YCopySign_AcceleratedTypes"/>
        public static TypeCodeFlags YCopySign_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YCopySign_AcceleratedTypes;
#else
                return _instance.YCopySign_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YCopySign(Vector512<float> value, Vector512<float> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YCopySign(Vector512<double> value, Vector512<double> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YCopySign(Vector512<sbyte> value, Vector512<sbyte> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YCopySign(Vector512<short> value, Vector512<short> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YCopySign(Vector512<int> value, Vector512<int> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YCopySign(Vector512<long> value, Vector512<long> sign) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2Unzip_AcceleratedTypes;
#else
                return _instance.YGroup2Unzip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup2Unzip(Vector512<float> data0, Vector512<float> data1, out Vector512<float> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup2Unzip(Vector512<double> data0, Vector512<double> data1, out Vector512<double> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup2Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, out Vector512<sbyte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup2Unzip(Vector512<byte> data0, Vector512<byte> data1, out Vector512<byte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup2Unzip(Vector512<short> data0, Vector512<short> data1, out Vector512<short> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup2Unzip(Vector512<ushort> data0, Vector512<ushort> data1, out Vector512<ushort> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup2Unzip(Vector512<int> data0, Vector512<int> data1, out Vector512<int> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup2Unzip(Vector512<uint> data0, Vector512<uint> data1, out Vector512<uint> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup2Unzip(Vector512<long> data0, Vector512<long> data1, out Vector512<long> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup2Unzip(Vector512<ulong> data0, Vector512<ulong> data1, out Vector512<ulong> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> YGroup2Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, out Vector512<ExInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> YGroup2Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, out Vector512<ExUInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YGroup2Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, out Vector512<T> y) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip_Bit128(data0, data1, out y);
#elif SHORT_CIRCUIT_GENERIC
            if (Avx512BW.IsSupported && Avx512DQ.IsSupported & Avx512F.IsSupported && Avx512Vbmi.IsSupported) {
                return WVectorTraits512Avx512.Statics.YGroup2Unzip_Bit128(data0, data1, out y);
            } else {
                return BaseStatics.YGroup2Unzip_Bit128(data0, data1, out y);
            }
#else
            return _instance.YGroup2Unzip_Bit128(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2UnzipEven_AcceleratedTypes;
#else
                return _instance.YGroup2UnzipEven_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup2UnzipEven(Vector512<float> data0, Vector512<float> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup2UnzipEven(Vector512<double> data0, Vector512<double> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup2UnzipEven(Vector512<sbyte> data0, Vector512<sbyte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup2UnzipEven(Vector512<byte> data0, Vector512<byte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup2UnzipEven(Vector512<short> data0, Vector512<short> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup2UnzipEven(Vector512<ushort> data0, Vector512<ushort> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup2UnzipEven(Vector512<int> data0, Vector512<int> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup2UnzipEven(Vector512<uint> data0, Vector512<uint> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup2UnzipEven(Vector512<long> data0, Vector512<long> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup2UnzipEven(Vector512<ulong> data0, Vector512<ulong> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> YGroup2UnzipEven(Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> YGroup2UnzipEven(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2UnzipOdd_AcceleratedTypes;
#else
                return _instance.YGroup2UnzipOdd_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup2UnzipOdd(Vector512<float> data0, Vector512<float> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup2UnzipOdd(Vector512<double> data0, Vector512<double> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup2UnzipOdd(Vector512<sbyte> data0, Vector512<sbyte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup2UnzipOdd(Vector512<byte> data0, Vector512<byte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup2UnzipOdd(Vector512<short> data0, Vector512<short> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup2UnzipOdd(Vector512<ushort> data0, Vector512<ushort> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup2UnzipOdd(Vector512<int> data0, Vector512<int> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup2UnzipOdd(Vector512<uint> data0, Vector512<uint> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup2UnzipOdd(Vector512<long> data0, Vector512<long> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup2UnzipOdd(Vector512<ulong> data0, Vector512<ulong> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> YGroup2UnzipOdd(Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> YGroup2UnzipOdd(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2Zip_AcceleratedTypes;
#else
                return _instance.YGroup2Zip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup2Zip(Vector512<float> x, Vector512<float> y, out Vector512<float> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup2Zip(Vector512<double> x, Vector512<double> y, out Vector512<double> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup2Zip(Vector512<sbyte> x, Vector512<sbyte> y, out Vector512<sbyte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup2Zip(Vector512<byte> x, Vector512<byte> y, out Vector512<byte> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup2Zip(Vector512<short> x, Vector512<short> y, out Vector512<short> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup2Zip(Vector512<ushort> x, Vector512<ushort> y, out Vector512<ushort> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup2Zip(Vector512<int> x, Vector512<int> y, out Vector512<int> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup2Zip(Vector512<uint> x, Vector512<uint> y, out Vector512<uint> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup2Zip(Vector512<long> x, Vector512<long> y, out Vector512<long> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup2Zip(Vector512<ulong> x, Vector512<ulong> y, out Vector512<ulong> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> YGroup2Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, out Vector512<ExInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> YGroup2Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, out Vector512<ExUInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YGroup2Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, out Vector512<T> data1) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip_Bit128(x, y, out data1);
#elif SHORT_CIRCUIT_GENERIC
            if (Avx512BW.IsSupported && Avx512DQ.IsSupported & Avx512F.IsSupported && Avx512Vbmi.IsSupported) {
                return WVectorTraits512Avx512.Statics.YGroup2Zip_Bit128(x, y, out data1);
            } else {
                return BaseStatics.YGroup2Zip_Bit128(x, y, out data1);
            }
#else
            return _instance.YGroup2Zip_Bit128(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2ZipHigh_AcceleratedTypes;
#else
                return _instance.YGroup2ZipHigh_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup2ZipHigh(Vector512<float> x, Vector512<float> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup2ZipHigh(Vector512<double> x, Vector512<double> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup2ZipHigh(Vector512<sbyte> x, Vector512<sbyte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup2ZipHigh(Vector512<byte> x, Vector512<byte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup2ZipHigh(Vector512<short> x, Vector512<short> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup2ZipHigh(Vector512<ushort> x, Vector512<ushort> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup2ZipHigh(Vector512<int> x, Vector512<int> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup2ZipHigh(Vector512<uint> x, Vector512<uint> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup2ZipHigh(Vector512<long> x, Vector512<long> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup2ZipHigh(Vector512<ulong> x, Vector512<ulong> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> YGroup2ZipHigh(Vector512<ExInt128> x, Vector512<ExInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> YGroup2ZipHigh(Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2ZipLow_AcceleratedTypes;
#else
                return _instance.YGroup2ZipLow_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup2ZipLow(Vector512<float> x, Vector512<float> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup2ZipLow(Vector512<double> x, Vector512<double> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup2ZipLow(Vector512<sbyte> x, Vector512<sbyte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup2ZipLow(Vector512<byte> x, Vector512<byte> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup2ZipLow(Vector512<short> x, Vector512<short> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup2ZipLow(Vector512<ushort> x, Vector512<ushort> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup2ZipLow(Vector512<int> x, Vector512<int> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup2ZipLow(Vector512<uint> x, Vector512<uint> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup2ZipLow(Vector512<long> x, Vector512<long> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup2ZipLow(Vector512<ulong> x, Vector512<ulong> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> YGroup2ZipLow(Vector512<ExInt128> x, Vector512<ExInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> YGroup2ZipLow(Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup3Unzip_AcceleratedTypes;
#else
                return _instance.YGroup3Unzip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup3Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, out Vector512<float> y, out Vector512<float> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup3Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, out Vector512<double> y, out Vector512<double> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup3Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> y, out Vector512<sbyte> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup3Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> y, out Vector512<byte> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup3Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> y, out Vector512<short> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup3Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> y, out Vector512<ushort> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup3Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> y, out Vector512<int> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup3Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> y, out Vector512<uint> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup3Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, out Vector512<long> y, out Vector512<long> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup3Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, out Vector512<ulong> y, out Vector512<ulong> z) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YGroup3Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, out Vector512<T> y, out Vector512<T> z) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup3UnzipX2_AcceleratedTypes;
#else
                return _instance.YGroup3UnzipX2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup3UnzipX2(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, Vector512<float> data4, Vector512<float> data5, out Vector512<float> xB, out Vector512<float> y, out Vector512<float> yB, out Vector512<float> z, out Vector512<float> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup3UnzipX2(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, Vector512<double> data4, Vector512<double> data5, out Vector512<double> xB, out Vector512<double> y, out Vector512<double> yB, out Vector512<double> z, out Vector512<double> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup3UnzipX2(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, Vector512<sbyte> data4, Vector512<sbyte> data5, out Vector512<sbyte> xB, out Vector512<sbyte> y, out Vector512<sbyte> yB, out Vector512<sbyte> z, out Vector512<sbyte> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup3UnzipX2(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, Vector512<byte> data4, Vector512<byte> data5, out Vector512<byte> xB, out Vector512<byte> y, out Vector512<byte> yB, out Vector512<byte> z, out Vector512<byte> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup3UnzipX2(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, Vector512<short> data4, Vector512<short> data5, out Vector512<short> xB, out Vector512<short> y, out Vector512<short> yB, out Vector512<short> z, out Vector512<short> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup3UnzipX2(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, Vector512<ushort> data4, Vector512<ushort> data5, out Vector512<ushort> xB, out Vector512<ushort> y, out Vector512<ushort> yB, out Vector512<ushort> z, out Vector512<ushort> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup3UnzipX2(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, Vector512<int> data4, Vector512<int> data5, out Vector512<int> xB, out Vector512<int> y, out Vector512<int> yB, out Vector512<int> z, out Vector512<int> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup3UnzipX2(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, Vector512<uint> data4, Vector512<uint> data5, out Vector512<uint> xB, out Vector512<uint> y, out Vector512<uint> yB, out Vector512<uint> z, out Vector512<uint> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup3UnzipX2(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, Vector512<long> data4, Vector512<long> data5, out Vector512<long> xB, out Vector512<long> y, out Vector512<long> yB, out Vector512<long> z, out Vector512<long> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup3UnzipX2(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, Vector512<ulong> data4, Vector512<ulong> data5, out Vector512<ulong> xB, out Vector512<ulong> y, out Vector512<ulong> yB, out Vector512<ulong> z, out Vector512<ulong> zB) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YGroup3UnzipX2_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, Vector512<T> data4, Vector512<T> data5, out Vector512<T> xB, out Vector512<T> y, out Vector512<T> yB, out Vector512<T> z, out Vector512<T> zB) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup4Unzip_AcceleratedTypes;
#else
                return _instance.YGroup4Unzip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup4Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, out Vector512<float> y, out Vector512<float> z, out Vector512<float> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup4Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, out Vector512<double> y, out Vector512<double> z, out Vector512<double> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup4Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> y, out Vector512<sbyte> z, out Vector512<sbyte> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup4Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup4Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup4Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup4Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> y, out Vector512<int> z, out Vector512<int> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup4Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> y, out Vector512<uint> z, out Vector512<uint> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup4Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> y, out Vector512<long> z, out Vector512<long> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup4Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> y, out Vector512<ulong> z, out Vector512<ulong> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> YGroup4Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, Vector512<ExInt128> data2, Vector512<ExInt128> data3, out Vector512<ExInt128> y, out Vector512<ExInt128> z, out Vector512<ExInt128> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> YGroup4Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, Vector512<ExUInt128> data2, Vector512<ExUInt128> data3, out Vector512<ExUInt128> y, out Vector512<ExUInt128> z, out Vector512<ExUInt128> w) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YGroup4Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, out Vector512<T> y, out Vector512<T> z, out Vector512<T> w) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
#elif SHORT_CIRCUIT_GENERIC
            if (Avx512BW.IsSupported && Avx512DQ.IsSupported & Avx512F.IsSupported && Avx512Vbmi.IsSupported) {
                return WVectorTraits512Avx512.Statics.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
            } else {
                return BaseStatics.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
            }
#else
            return _instance.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup4Zip_AcceleratedTypes;
#else
                return _instance.YGroup4Zip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }
        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YGroup4Zip(Vector512<float> x, Vector512<float> y, Vector512<float> z, Vector512<float> w, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YGroup4Zip(Vector512<double> x, Vector512<double> y, Vector512<double> z, Vector512<double> w, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YGroup4Zip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YGroup4Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YGroup4Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YGroup4Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YGroup4Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YGroup4Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YGroup4Zip(Vector512<long> x, Vector512<long> y, Vector512<long> z, Vector512<long> w, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YGroup4Zip(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, Vector512<ulong> w, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> YGroup4Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, Vector512<ExInt128> z, Vector512<ExInt128> w, out Vector512<ExInt128> data1, out Vector512<ExInt128> data2, out Vector512<ExInt128> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> YGroup4Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, Vector512<ExUInt128> z, Vector512<ExUInt128> w, out Vector512<ExUInt128> data1, out Vector512<ExUInt128> data2, out Vector512<ExUInt128> data3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YGroup4Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
#elif SHORT_CIRCUIT_GENERIC
            if (Avx512BW.IsSupported && Avx512DQ.IsSupported & Avx512F.IsSupported && Avx512Vbmi.IsSupported) {
                return WVectorTraits512Avx512.Statics.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
            } else {
                return BaseStatics.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
            }
#else
            return _instance.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup6Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YGroup6Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, Vector512<T> data4, Vector512<T> data5, out Vector512<T> y, out Vector512<T> z, out Vector512<T> w, out Vector512<T> u, out Vector512<T> v) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup6Unzip_Bit128(data0, data1, data2, data3, data4, data5, out y, out z, out w, out u, out v);
#else
            return _instance.YGroup6Unzip_Bit128(data0, data1, data2, data3, data4, data5, out y, out z, out w, out u, out v);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup6Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YGroup6Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w, Vector512<T> u, Vector512<T> v, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3, out Vector512<T> data4, out Vector512<T> data5) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup6Zip_Bit128(x, y, z, w, u, v, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup6Zip_Bit128(x, y, z, w, u, v, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsAllTrue_AcceleratedTypes"/>
        public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsAllTrue_AcceleratedTypes;
#else
                return _instance.YIsAllTrue_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsAllTrue{T}(Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool YIsAllTrue<T>(Vector512<T> value) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsAllTrue(value);
#else
            return _instance.YIsAllTrue(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsAnyTrue_AcceleratedTypes"/>
        public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsAnyTrue_AcceleratedTypes;
#else
                return _instance.YIsAnyTrue_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsAnyTrue{T}(Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool YIsAnyTrue<T>(Vector512<T> value) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsAnyTrue(value);
#else
            return _instance.YIsAnyTrue(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger_AcceleratedTypes"/>
        public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsEvenInteger_AcceleratedTypes;
#else
                return _instance.YIsEvenInteger_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsEvenInteger(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsEvenInteger(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YIsEvenInteger(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YIsEvenInteger(Vector512<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YIsEvenInteger(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YIsEvenInteger(Vector512<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsEvenInteger(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YIsEvenInteger(Vector512<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsEvenInteger(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YIsEvenInteger(Vector512<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsFinite_AcceleratedTypes"/>
        public static TypeCodeFlags YIsFinite_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsFinite_AcceleratedTypes;
#else
                return _instance.YIsFinite_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsFinite(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsFinite(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsFinite(value);
#else
            return _instance.YIsFinite(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsFinite(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsFinite(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsFinite(value);
#else
            return _instance.YIsFinite(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsInfinity_AcceleratedTypes"/>
        public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsInfinity_AcceleratedTypes;
#else
                return _instance.YIsInfinity_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInfinity(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsInfinity(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinity(value);
#else
            return _instance.YIsInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInfinity(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsInfinity(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinity(value);
#else
            return _instance.YIsInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsInfinityOrNaN_AcceleratedTypes"/>
        public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsInfinityOrNaN_AcceleratedTypes;
#else
                return _instance.YIsInfinityOrNaN_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInfinityOrNaN(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsInfinityOrNaN(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinityOrNaN(value);
#else
            return _instance.YIsInfinityOrNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInfinityOrNaN(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsInfinityOrNaN(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinityOrNaN(value);
#else
            return _instance.YIsInfinityOrNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsInteger_AcceleratedTypes"/>
        public static TypeCodeFlags YIsInteger_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsInteger_AcceleratedTypes;
#else
                return _instance.YIsInteger_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInteger(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsInteger(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInteger(value);
#else
            return _instance.YIsInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInteger(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsInteger(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInteger(value);
#else
            return _instance.YIsInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNaN_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNaN_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNaN_AcceleratedTypes;
#else
                return _instance.YIsNaN_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNaN(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsNaN(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNaN(value);
#else
            return _instance.YIsNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNaN(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsNaN(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNaN(value);
#else
            return _instance.YIsNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNegative_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNegative_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNegative_AcceleratedTypes;
#else
                return _instance.YIsNegative_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsNegative(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsNegative(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YIsNegative(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YIsNegative(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsNegative(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsNegative(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeInfinity_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNegativeInfinity_AcceleratedTypes;
#else
                return _instance.YIsNegativeInfinity_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeInfinity(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsNegativeInfinity(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeInfinity(value);
#else
            return _instance.YIsNegativeInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeInfinity(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsNegativeInfinity(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeInfinity(value);
#else
            return _instance.YIsNegativeInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeZero_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNegativeZero_AcceleratedTypes;
#else
                return _instance.YIsNegativeZero_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeZero(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsNegativeZero(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeZero(value);
#else
            return _instance.YIsNegativeZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeZero(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsNegativeZero(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeZero(value);
#else
            return _instance.YIsNegativeZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNormal_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNormal_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNormal_AcceleratedTypes;
#else
                return _instance.YIsNormal_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNormal(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsNormal(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNormal(value);
#else
            return _instance.YIsNormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNormal(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsNormal(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNormal(value);
#else
            return _instance.YIsNormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNotEquals_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNotEquals_AcceleratedTypes;
#else
                return _instance.YIsNotEquals_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YIsNotEquals(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YIsNotEquals(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YIsNotEquals(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YIsNotEquals(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YIsNotEquals(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YIsNotEquals(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsNotEquals(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YIsNotEquals(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsNotEquals(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YIsNotEquals(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNotNaN_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNotNaN_AcceleratedTypes;
#else
                return _instance.YIsNotNaN_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotNaN(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsNotNaN(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotNaN(value);
#else
            return _instance.YIsNotNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotNaN(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsNotNaN(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotNaN(value);
#else
            return _instance.YIsNotNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger_AcceleratedTypes"/>
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

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsOddInteger(Vector512<float> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsOddInteger(Vector512<double> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YIsOddInteger(Vector512<sbyte> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YIsOddInteger(Vector512<byte> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YIsOddInteger(Vector512<short> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YIsOddInteger(Vector512<ushort> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsOddInteger(Vector512<int> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YIsOddInteger(Vector512<uint> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsOddInteger(Vector512<long> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YIsOddInteger(Vector512<ulong> value)
        {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsPositive_AcceleratedTypes"/>
        public static TypeCodeFlags YIsPositive_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsPositive_AcceleratedTypes;
#else
                return _instance.YIsPositive_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsPositive(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsPositive(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YIsPositive(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YIsPositive(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsPositive(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsPositive(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsPositiveInfinity_AcceleratedTypes"/>
        public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsPositiveInfinity_AcceleratedTypes;
#else
                return _instance.YIsPositiveInfinity_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositiveInfinity(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsPositiveInfinity(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositiveInfinity(value);
#else
            return _instance.YIsPositiveInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositiveInfinity(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsPositiveInfinity(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositiveInfinity(value);
#else
            return _instance.YIsPositiveInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsSubnormal_AcceleratedTypes"/>
        public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsSubnormal_AcceleratedTypes;
#else
                return _instance.YIsSubnormal_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsSubnormal(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsSubnormal(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsSubnormal(value);
#else
            return _instance.YIsSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsSubnormal(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsSubnormal(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsSubnormal(value);
#else
            return _instance.YIsSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsZero_AcceleratedTypes"/>
        public static TypeCodeFlags YIsZero_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsZero_AcceleratedTypes;
#else
                return _instance.YIsZero_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsZero(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsZero(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YIsZero(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YIsZero(Vector512<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YIsZero(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YIsZero(Vector512<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsZero(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YIsZero(Vector512<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsZero(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YIsZero(Vector512<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsZeroOrSubnormal_AcceleratedTypes"/>
        public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsZeroOrSubnormal_AcceleratedTypes;
#else
                return _instance.YIsZeroOrSubnormal_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZeroOrSubnormal(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YIsZeroOrSubnormal(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZeroOrSubnormal(value);
#else
            return _instance.YIsZeroOrSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZeroOrSubnormal(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YIsZeroOrSubnormal(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZeroOrSubnormal(value);
#else
            return _instance.YIsZeroOrSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YMaxNumber_AcceleratedTypes"/>
        public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YMaxNumber_AcceleratedTypes;
#else
                return _instance.YMaxNumber_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YMaxNumber(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YMaxNumber(left, right);
#else
            return _instance.YMaxNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YMaxNumber(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YMaxNumber(left, right);
#else
            return _instance.YMaxNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YMinNumber_AcceleratedTypes"/>
        public static TypeCodeFlags YMinNumber_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YMinNumber_AcceleratedTypes;
#else
                return _instance.YMinNumber_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YMinNumber(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YMinNumber(left, right);
#else
            return _instance.YMinNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YMinNumber(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YMinNumber(left, right);
#else
            return _instance.YMinNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_AcceleratedTypes;
#else
                return _instance.YNarrowSaturate_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturate_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{short}, Vector512{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YNarrowSaturate(Vector512<short> lower, Vector512<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ushort}, Vector512{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YNarrowSaturate(Vector512<ushort> lower, Vector512<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{int}, Vector512{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YNarrowSaturate(Vector512<int> lower, Vector512<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{uint}, Vector512{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YNarrowSaturate(Vector512<uint> lower, Vector512<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{long}, Vector512{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YNarrowSaturate(Vector512<long> lower, Vector512<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ulong}, Vector512{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YNarrowSaturate(Vector512<ulong> lower, Vector512<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_AcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{short}, Vector512{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YNarrowSaturateUnsigned(Vector512<short> lower, Vector512<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{int}, Vector512{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YNarrowSaturateUnsigned(Vector512<int> lower, Vector512<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{long}, Vector512{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YNarrowSaturateUnsigned(Vector512<long> lower, Vector512<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YOrNot_AcceleratedTypes"/>
        public static TypeCodeFlags YOrNot_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YOrNot_AcceleratedTypes;
#else
                return _instance.YOrNot_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YOrNot{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YOrNot<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YOrNot(left, right);
#else
            return _instance.YOrNot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YRoundToZero_AcceleratedTypes"/>
        public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YRoundToZero_AcceleratedTypes;
#else
                return _instance.YRoundToZero_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YRoundToZero(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToZero(value);
#else
            return _instance.YRoundToZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YRoundToZero(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToZero(value);
#else
            return _instance.YRoundToZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleG2_AcceleratedTypes;
#else
                return _instance.YShuffleG2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleG2(Vector512<float> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleG2(Vector512<double> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleG2(Vector512<sbyte> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleG2(Vector512<byte> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleG2(Vector512<short> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleG2(Vector512<ushort> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleG2(Vector512<int> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleG2(Vector512<uint> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleG2(Vector512<long> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleG2(Vector512<ulong> source, ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleG2_Const(Vector512<float> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleG2_Const(Vector512<double> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleG2_Const(Vector512<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleG2_Const(Vector512<byte> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleG2_Const(Vector512<short> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleG2_Const(Vector512<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleG2_Const(Vector512<int> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleG2_Const(Vector512<uint> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleG2_Const(Vector512<long> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleG2_Const(Vector512<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleG4_AcceleratedTypes;
#else
                return _instance.YShuffleG4_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleG4(Vector512<float> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleG4(Vector512<double> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleG4(Vector512<sbyte> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleG4(Vector512<byte> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleG4(Vector512<short> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleG4(Vector512<ushort> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleG4(Vector512<int> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleG4(Vector512<uint> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleG4(Vector512<long> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleG4(Vector512<ulong> source, ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleG4_Const(Vector512<float> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleG4_Const(Vector512<double> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleG4_Const(Vector512<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleG4_Const(Vector512<byte> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleG4_Const(Vector512<short> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleG4_Const(Vector512<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleG4_Const(Vector512<int> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleG4_Const(Vector512<uint> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleG4_Const(Vector512<long> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleG4_Const(Vector512<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleG4X2_AcceleratedTypes;
#else
                return _instance.YShuffleG4X2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{float}, Vector512{float}, ShuffleControlG4, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleG4X2(Vector512<float> source0, Vector512<float> source1, ShuffleControlG4 control, out Vector512<float> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{double}, Vector512{double}, ShuffleControlG4, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleG4X2(Vector512<double> source0, Vector512<double> source1, ShuffleControlG4 control, out Vector512<double> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleG4X2(Vector512<sbyte> source0, Vector512<sbyte> source1, ShuffleControlG4 control, out Vector512<sbyte> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{byte}, Vector512{byte}, ShuffleControlG4, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleG4X2(Vector512<byte> source0, Vector512<byte> source1, ShuffleControlG4 control, out Vector512<byte> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{short}, Vector512{short}, ShuffleControlG4, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleG4X2(Vector512<short> source0, Vector512<short> source1, ShuffleControlG4 control, out Vector512<short> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleG4X2(Vector512<ushort> source0, Vector512<ushort> source1, ShuffleControlG4 control, out Vector512<ushort> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{int}, Vector512{int}, ShuffleControlG4, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleG4X2(Vector512<int> source0, Vector512<int> source1, ShuffleControlG4 control, out Vector512<int> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{uint}, Vector512{uint}, ShuffleControlG4, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleG4X2(Vector512<uint> source0, Vector512<uint> source1, ShuffleControlG4 control, out Vector512<uint> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{long}, Vector512{long}, ShuffleControlG4, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleG4X2(Vector512<long> source0, Vector512<long> source1, ShuffleControlG4 control, out Vector512<long> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleG4X2(Vector512<ulong> source0, Vector512<ulong> source1, ShuffleControlG4 control, out Vector512<ulong> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{float}, Vector512{float}, ShuffleControlG4, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleG4X2_Const(Vector512<float> source0, Vector512<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<float> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{double}, Vector512{double}, ShuffleControlG4, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleG4X2_Const(Vector512<double> source0, Vector512<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<double> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleG4X2_Const(Vector512<sbyte> source0, Vector512<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<sbyte> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{byte}, Vector512{byte}, ShuffleControlG4, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleG4X2_Const(Vector512<byte> source0, Vector512<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<byte> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{short}, Vector512{short}, ShuffleControlG4, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleG4X2_Const(Vector512<short> source0, Vector512<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<short> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleG4X2_Const(Vector512<ushort> source0, Vector512<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ushort> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{int}, Vector512{int}, ShuffleControlG4, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleG4X2_Const(Vector512<int> source0, Vector512<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<int> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{uint}, Vector512{uint}, ShuffleControlG4, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleG4X2_Const(Vector512<uint> source0, Vector512<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<uint> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{long}, Vector512{long}, ShuffleControlG4, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleG4X2_Const(Vector512<long> source0, Vector512<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<long> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleG4X2_Const(Vector512<ulong> source0, Vector512<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ulong> result1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleInsert_AcceleratedTypes;
#else
                return _instance.YShuffleInsert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleInsert(Vector512<float> back, Vector512<float> vector, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleInsert(Vector512<double> back, Vector512<double> vector, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleInsert(Vector512<sbyte> back, Vector512<sbyte> vector, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleInsert(Vector512<byte> back, Vector512<byte> vector, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleInsert(Vector512<short> back, Vector512<short> vector, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleInsert(Vector512<ushort> back, Vector512<ushort> vector, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleInsert(Vector512<int> back, Vector512<int> vector, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleInsert(Vector512<uint> back, Vector512<uint> vector, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleInsert(Vector512<long> back, Vector512<long> vector, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleInsert(Vector512<ulong> back, Vector512<ulong> vector, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleInsert_Core(Vector512<float> back, Vector512<float> vector, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleInsert_Core(Vector512<double> back, Vector512<double> vector, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleInsert_Core(Vector512<sbyte> back, Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleInsert_Core(Vector512<byte> back, Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleInsert_Core(Vector512<short> back, Vector512<short> vector, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleInsert_Core(Vector512<ushort> back, Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleInsert_Core(Vector512<int> back, Vector512<int> vector, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleInsert_Core(Vector512<uint> back, Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleInsert_Core(Vector512<long> back, Vector512<long> vector, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleInsert_Core(Vector512<ulong> back, Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleKernel_AcceleratedTypes;
#else
                return _instance.YShuffleKernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleKernel(Vector512<float> vector, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleKernel(Vector512<double> vector, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleKernel(Vector512<sbyte> vector, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleKernel(Vector512<byte> vector, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleKernel(Vector512<short> vector, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleKernel(Vector512<ushort> vector, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleKernel(Vector512<int> vector, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleKernel(Vector512<uint> vector, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleKernel(Vector512<long> vector, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleKernel(Vector512<ulong> vector, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleKernel_Core(Vector512<float> vector, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{double}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleKernel_Core(Vector512<double> vector, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleKernel_Core(Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleKernel_Core(Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleKernel_Core(Vector512<short> vector, Vector512<short> args0, Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleKernel_Core(Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleKernel_Core(Vector512<int> vector, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleKernel_Core(Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleKernel_Core(Vector512<long> vector, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleKernel_Core(Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX2_AcceleratedTypes;
#else
                return _instance.YShuffleX2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX2(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX2(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX2(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX2(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX2(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX2(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX2(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX2(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX2(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX2(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX2_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX2_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX2_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX2_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX2_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX2_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX2_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX2_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX2_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX2_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX2Insert_AcceleratedTypes;
#else
                return _instance.YShuffleX2Insert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX2Insert(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX2Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX2Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX2Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX2Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX2Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX2Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX2Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX2Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX2Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX2Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX2Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX2Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX2Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX2Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX2Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX2Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX2Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX2Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX2Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX2Kernel_AcceleratedTypes;
#else
                return _instance.YShuffleX2Kernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX2Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX2Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX2Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX2Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX2Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX2Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX2Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX2Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX2Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX2Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX2Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX2Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX2Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX2Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX2Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX2Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX2Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX2Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX2Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX2Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX3_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3_AcceleratedTypes;
#else
                return _instance.YShuffleX3_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX3(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX3(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX3(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX3(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX3(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX3(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX3(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX3(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX3(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX3(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX3_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX3_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX3_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX3_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX3_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX3_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX3_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX3_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX3_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX3_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3Insert_AcceleratedTypes;
#else
                return _instance.YShuffleX3Insert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX3Insert(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX3Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX3Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX3Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX3Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX3Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX3Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX3Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX3Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX3Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX3Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX3Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX3Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX3Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX3Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX3Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX3Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX3Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX3Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX3Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3Kernel_AcceleratedTypes;
#else
                return _instance.YShuffleX3Kernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX3Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX3Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX3Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX3Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX3Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX3Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX3Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX3Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX3Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX3Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX3Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX3Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX3Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX3Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX3Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX3Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX3Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX3Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX3Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX3Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX4_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX4_AcceleratedTypes;
#else
                return _instance.YShuffleX4_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX4(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX4(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX4(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX4(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX4(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX4(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX4(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX4(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX4(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX4(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX4_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX4_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX4_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX4_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX4_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX4_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX4_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX4_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX4_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX4_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX4Insert_AcceleratedTypes;
#else
                return _instance.YShuffleX4Insert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX4Insert(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX4Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX4Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX4Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX4Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX4Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX4Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX4Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX4Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX4Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX4Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX4Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX4Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX4Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX4Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX4Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX4Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX4Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX4Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX4Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX4Kernel_AcceleratedTypes;
#else
                return _instance.YShuffleX4Kernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX4Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX4Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX4Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX4Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX4Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX4Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX4Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX4Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX4Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX4Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX4Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX4Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX4Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX4Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX4Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX4Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX4Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX4Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX4Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX4Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YRoundToEven_AcceleratedTypes"/>
        public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YRoundToEven_AcceleratedTypes;
#else
                return _instance.YRoundToEven_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YRoundToEven(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToEven(value);
#else
            return _instance.YRoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YRoundToEven(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToEven(value);
#else
            return _instance.YRoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YSign_AcceleratedTypes"/>
        public static TypeCodeFlags YSign_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YSign_AcceleratedTypes;
#else
                return _instance.YSign_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YSign(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YSign(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YSign(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YSign(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YSign(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YSign(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.YSignFloat_AcceleratedTypes"/>
        public static TypeCodeFlags YSignFloat_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YSignFloat_AcceleratedTypes;
#else
                return _instance.YSignFloat_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YSignFloat(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSignFloat(value);
#else
            return _instance.YSignFloat(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YSignFloat(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSignFloat(value);
#else
            return _instance.YSignFloat(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


#endif
    }
}
