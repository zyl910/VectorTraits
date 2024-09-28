#if NETCOREAPP3_0_OR_GREATER
#define SHORT_CIRCUIT_GENERIC
#endif // NETCOREAPP3_0_OR_GREATER
#if NET8_0_OR_GREATER
#define SHORT_CIRCUIT_WASM
#endif // NET8_0_OR_GREATER

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
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits {
    using BaseStatics = WVectorTraits128Base.Statics;
    using WasmStatics = WVectorTraits128PackedSimd.Statics;

    partial class Vector128s {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.YBitToByte_IsAccelerated"/>
        public static bool YBitToByte_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToByte_IsAccelerated;
#else
                return _instance.YBitToByte_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YBitToByte"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YBitToByte(uint value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YBitToByte(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToByte(value);
#else
            return _instance.YBitToByte(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YBitToInt16_IsAccelerated"/>
        public static bool YBitToInt16_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToInt16_IsAccelerated;
#else
                return _instance.YBitToInt16_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YBitToInt16"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YBitToInt16(uint value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YBitToInt16(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToInt16(value);
#else
            return _instance.YBitToInt16(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YBitToInt32_IsAccelerated"/>
        public static bool YBitToInt32_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToInt32_IsAccelerated;
#else
                return _instance.YBitToInt32_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YBitToInt32"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YBitToInt32(uint value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YBitToInt32(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToInt32(value);
#else
            return _instance.YBitToInt32(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YBitToInt64_IsAccelerated"/>
        public static bool YBitToInt64_IsAccelerated {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YBitToInt64_IsAccelerated;
#else
                return _instance.YBitToInt64_IsAccelerated;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YBitToInt64"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YBitToInt64(uint value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YBitToInt64(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YBitToInt64(value);
#else
            return _instance.YBitToInt64(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
        public static TypeCodeFlags YClamp_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YClamp_AcceleratedTypes;
#else
                return _instance.YClamp_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YClamp(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YClamp(Vector128<sbyte> value, Vector128<sbyte> amin, Vector128<sbyte> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YClamp(Vector128<byte> value, Vector128<byte> amin, Vector128<byte> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YClamp(Vector128<short> value, Vector128<short> amin, Vector128<short> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YClamp(Vector128<ushort> value, Vector128<ushort> amin, Vector128<ushort> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YClamp(Vector128<int> value, Vector128<int> amin, Vector128<int> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YClamp(Vector128<uint> value, Vector128<uint> amin, Vector128<uint> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YClamp(value, amin, amax);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YCopySign_AcceleratedTypes"/>
        public static TypeCodeFlags YCopySign_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YCopySign_AcceleratedTypes;
#else
                return _instance.YCopySign_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YCopySign(Vector128<float> value, Vector128<float> sign) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YCopySign(value, sign);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YCopySign(Vector128<double> value, Vector128<double> sign) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YCopySign(value, sign);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YCopySign(Vector128<sbyte> value, Vector128<sbyte> sign) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YCopySign(value, sign);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YCopySign(Vector128<short> value, Vector128<short> sign) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YCopySign(value, sign);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YCopySign(Vector128<int> value, Vector128<int> sign) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YCopySign(value, sign);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YCopySign(Vector128<long> value, Vector128<long> sign) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YCopySign(value, sign);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YCopySign(value, sign);
#else
            return _instance.YCopySign(value, sign);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup1ToGroup3_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup1ToGroup3_AcceleratedTypes;
#else
                return _instance.YGroup1ToGroup3_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup1ToGroup3(Vector128<float> x, out Vector128<float> result1, out Vector128<float> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup1ToGroup3(Vector128<double> x, out Vector128<double> result1, out Vector128<double> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup1ToGroup3(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup1ToGroup3(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup1ToGroup3(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup1ToGroup3(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup1ToGroup3(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup1ToGroup3(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup1ToGroup3(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup1ToGroup3(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup3(x, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup3(x, out result1, out result2);
#else
            return _instance.YGroup1ToGroup3(x, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup1ToGroup4_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup1ToGroup4_AcceleratedTypes;
#else
                return _instance.YGroup1ToGroup4_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup1ToGroup4(Vector128<float> x, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup1ToGroup4(Vector128<double> x, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup1ToGroup4(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup1ToGroup4(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup1ToGroup4(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup1ToGroup4(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup1ToGroup4(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup1ToGroup4(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup1ToGroup4(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup1ToGroup4(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4(x, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4(x, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup1ToGroup4WithW_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup1ToGroup4WithW_AcceleratedTypes;
#else
                return _instance.YGroup1ToGroup4WithW_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup1ToGroup4WithW(Vector128<float> x, Vector128<float> w, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup1ToGroup4WithW(Vector128<double> x, Vector128<double> w, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup1ToGroup4WithW(Vector128<sbyte> x, Vector128<sbyte> w, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup1ToGroup4WithW(Vector128<byte> x, Vector128<byte> w, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup1ToGroup4WithW(Vector128<short> x, Vector128<short> w, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup1ToGroup4WithW(Vector128<ushort> x, Vector128<ushort> w, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup1ToGroup4WithW(Vector128<int> x, Vector128<int> w, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup1ToGroup4WithW(Vector128<uint> x, Vector128<uint> w, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup1ToGroup4WithW(Vector128<long> x, Vector128<long> w, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup1ToGroup4WithW(Vector128<ulong> x, Vector128<ulong> w, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#else
            return _instance.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2Transpose_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2Transpose_AcceleratedTypes;
#else
                return _instance.YGroup2Transpose_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup2Transpose(Vector128<float> data0, Vector128<float> data1, out Vector128<float> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{double}, Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup2Transpose(Vector128<double> data0, Vector128<double> data1, out Vector128<double> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup2Transpose(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup2Transpose(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{short}, Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup2Transpose(Vector128<short> data0, Vector128<short> data1, out Vector128<short> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup2Transpose(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{int}, Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup2Transpose(Vector128<int> data0, Vector128<int> data1, out Vector128<int> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup2Transpose(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{long}, Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup2Transpose(Vector128<long> data0, Vector128<long> data1, out Vector128<long> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup2Transpose(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Transpose(data0, data1, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Transpose(data0, data1, out result1);
#else
            return _instance.YGroup2Transpose(data0, data1, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2Unzip_AcceleratedTypes;
#else
                return _instance.YGroup2Unzip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup2Unzip(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup2Unzip(Vector128<double> data0, Vector128<double> data1, out Vector128<double> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup2Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup2Unzip(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup2Unzip(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup2Unzip(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup2Unzip(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup2Unzip(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup2Unzip(Vector128<long> data0, Vector128<long> data1, out Vector128<long> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup2Unzip(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Unzip(data0, data1, out y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> YGroup2Unzip(Vector128<ExInt128> data0, Vector128<ExInt128> data1, out Vector128<ExInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> YGroup2Unzip(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1, out Vector128<ExUInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2Unzip(data0, data1, out y);
#else
            return _instance.YGroup2Unzip(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup2Unzip_Bit128<T>(Vector128<T> data0, Vector128<T> data1, out Vector128<T> y) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2Unzip_Bit128(data0, data1, out y);
#else
            return _instance.YGroup2Unzip_Bit128(data0, data1, out y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2UnzipEven_AcceleratedTypes;
#else
                return _instance.YGroup2UnzipEven_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup2UnzipEven(Vector128<float> data0, Vector128<float> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup2UnzipEven(Vector128<double> data0, Vector128<double> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup2UnzipEven(Vector128<sbyte> data0, Vector128<sbyte> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup2UnzipEven(Vector128<byte> data0, Vector128<byte> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup2UnzipEven(Vector128<short> data0, Vector128<short> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup2UnzipEven(Vector128<ushort> data0, Vector128<ushort> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup2UnzipEven(Vector128<int> data0, Vector128<int> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup2UnzipEven(Vector128<uint> data0, Vector128<uint> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup2UnzipEven(Vector128<long> data0, Vector128<long> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup2UnzipEven(Vector128<ulong> data0, Vector128<ulong> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipEven(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> YGroup2UnzipEven(Vector128<ExInt128> data0, Vector128<ExInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> YGroup2UnzipEven(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2UnzipEven(data0, data1);
#else
            return _instance.YGroup2UnzipEven(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2UnzipOdd_AcceleratedTypes;
#else
                return _instance.YGroup2UnzipOdd_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup2UnzipOdd(Vector128<float> data0, Vector128<float> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup2UnzipOdd(Vector128<double> data0, Vector128<double> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup2UnzipOdd(Vector128<sbyte> data0, Vector128<sbyte> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup2UnzipOdd(Vector128<byte> data0, Vector128<byte> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup2UnzipOdd(Vector128<short> data0, Vector128<short> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup2UnzipOdd(Vector128<ushort> data0, Vector128<ushort> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup2UnzipOdd(Vector128<int> data0, Vector128<int> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup2UnzipOdd(Vector128<uint> data0, Vector128<uint> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup2UnzipOdd(Vector128<long> data0, Vector128<long> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup2UnzipOdd(Vector128<ulong> data0, Vector128<ulong> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2UnzipOdd(data0, data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> YGroup2UnzipOdd(Vector128<ExInt128> data0, Vector128<ExInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> YGroup2UnzipOdd(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2UnzipOdd(data0, data1);
#else
            return _instance.YGroup2UnzipOdd(data0, data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2Zip_AcceleratedTypes;
#else
                return _instance.YGroup2Zip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup2Zip(Vector128<float> x, Vector128<float> y, out Vector128<float> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup2Zip(Vector128<double> x, Vector128<double> y, out Vector128<double> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup2Zip(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<sbyte> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup2Zip(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup2Zip(Vector128<short> x, Vector128<short> y, out Vector128<short> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup2Zip(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup2Zip(Vector128<int> x, Vector128<int> y, out Vector128<int> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup2Zip(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup2Zip(Vector128<long> x, Vector128<long> y, out Vector128<long> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup2Zip(Vector128<ulong> x, Vector128<ulong> y, out Vector128<ulong> data1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2Zip(x, y, out data1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> YGroup2Zip(Vector128<ExInt128> x, Vector128<ExInt128> y, out Vector128<ExInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> YGroup2Zip(Vector128<ExUInt128> x, Vector128<ExUInt128> y, out Vector128<ExUInt128> data1) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2Zip(x, y, out data1);
#else
            return _instance.YGroup2Zip(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup2Zip_Bit128<T>(Vector128<T> x, Vector128<T> y, out Vector128<T> data1) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2Zip_Bit128(x, y, out data1);
#else
            return _instance.YGroup2Zip_Bit128(x, y, out data1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2ZipHigh_AcceleratedTypes;
#else
                return _instance.YGroup2ZipHigh_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup2ZipHigh(Vector128<float> x, Vector128<float> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup2ZipHigh(Vector128<double> x, Vector128<double> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup2ZipHigh(Vector128<sbyte> x, Vector128<sbyte> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup2ZipHigh(Vector128<byte> x, Vector128<byte> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup2ZipHigh(Vector128<short> x, Vector128<short> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup2ZipHigh(Vector128<ushort> x, Vector128<ushort> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup2ZipHigh(Vector128<int> x, Vector128<int> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup2ZipHigh(Vector128<uint> x, Vector128<uint> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup2ZipHigh(Vector128<long> x, Vector128<long> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup2ZipHigh(Vector128<ulong> x, Vector128<ulong> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipHigh(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> YGroup2ZipHigh(Vector128<ExInt128> x, Vector128<ExInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> YGroup2ZipHigh(Vector128<ExUInt128> x, Vector128<ExUInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2ZipHigh(x, y);
#else
            return _instance.YGroup2ZipHigh(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup2ZipLow_AcceleratedTypes;
#else
                return _instance.YGroup2ZipLow_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup2ZipLow(Vector128<float> x, Vector128<float> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup2ZipLow(Vector128<double> x, Vector128<double> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup2ZipLow(Vector128<sbyte> x, Vector128<sbyte> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup2ZipLow(Vector128<byte> x, Vector128<byte> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup2ZipLow(Vector128<short> x, Vector128<short> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup2ZipLow(Vector128<ushort> x, Vector128<ushort> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup2ZipLow(Vector128<int> x, Vector128<int> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup2ZipLow(Vector128<uint> x, Vector128<uint> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup2ZipLow(Vector128<long> x, Vector128<long> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup2ZipLow(Vector128<ulong> x, Vector128<ulong> y) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup2ZipLow(x, y);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> YGroup2ZipLow(Vector128<ExInt128> x, Vector128<ExInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> YGroup2ZipLow(Vector128<ExUInt128> x, Vector128<ExUInt128> y) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup2ZipLow(x, y);
#else
            return _instance.YGroup2ZipLow(x, y);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup3ToGroup4_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup3ToGroup4_AcceleratedTypes;
#else
                return _instance.YGroup3ToGroup4_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup3ToGroup4(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup3ToGroup4(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup3ToGroup4(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup3ToGroup4(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup3ToGroup4(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup3ToGroup4(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup3ToGroup4(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup3ToGroup4(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup3ToGroup4(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup3ToGroup4(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#else
            return _instance.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup3Unzip_AcceleratedTypes;
#else
                return _instance.YGroup3Unzip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup3Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> y, out Vector128<float> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup3Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> y, out Vector128<double> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup3Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> y, out Vector128<sbyte> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup3Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> y, out Vector128<byte> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup3Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> y, out Vector128<short> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup3Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> y, out Vector128<ushort> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup3Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> y, out Vector128<int> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup3Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> y, out Vector128<uint> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup3Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> y, out Vector128<long> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup3Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> y, out Vector128<ulong> z) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup3Unzip_Bit128<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, out Vector128<T> y, out Vector128<T> z) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
#else
            return _instance.YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup3UnzipX2_AcceleratedTypes;
#else
                return _instance.YGroup3UnzipX2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup3UnzipX2(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, Vector128<float> data4, Vector128<float> data5, out Vector128<float> xB, out Vector128<float> y, out Vector128<float> yB, out Vector128<float> z, out Vector128<float> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup3UnzipX2(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, Vector128<double> data4, Vector128<double> data5, out Vector128<double> xB, out Vector128<double> y, out Vector128<double> yB, out Vector128<double> z, out Vector128<double> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup3UnzipX2(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, Vector128<sbyte> data4, Vector128<sbyte> data5, out Vector128<sbyte> xB, out Vector128<sbyte> y, out Vector128<sbyte> yB, out Vector128<sbyte> z, out Vector128<sbyte> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup3UnzipX2(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, Vector128<byte> data4, Vector128<byte> data5, out Vector128<byte> xB, out Vector128<byte> y, out Vector128<byte> yB, out Vector128<byte> z, out Vector128<byte> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup3UnzipX2(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, Vector128<short> data4, Vector128<short> data5, out Vector128<short> xB, out Vector128<short> y, out Vector128<short> yB, out Vector128<short> z, out Vector128<short> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup3UnzipX2(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, Vector128<ushort> data4, Vector128<ushort> data5, out Vector128<ushort> xB, out Vector128<ushort> y, out Vector128<ushort> yB, out Vector128<ushort> z, out Vector128<ushort> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup3UnzipX2(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, Vector128<int> data4, Vector128<int> data5, out Vector128<int> xB, out Vector128<int> y, out Vector128<int> yB, out Vector128<int> z, out Vector128<int> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup3UnzipX2(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, Vector128<uint> data4, Vector128<uint> data5, out Vector128<uint> xB, out Vector128<uint> y, out Vector128<uint> yB, out Vector128<uint> z, out Vector128<uint> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup3UnzipX2(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, Vector128<long> data4, Vector128<long> data5, out Vector128<long> xB, out Vector128<long> y, out Vector128<long> yB, out Vector128<long> z, out Vector128<long> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup3UnzipX2(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, Vector128<ulong> data4, Vector128<ulong> data5, out Vector128<ulong> xB, out Vector128<ulong> y, out Vector128<ulong> yB, out Vector128<ulong> z, out Vector128<ulong> zB) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup3UnzipX2_Bit128<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3, Vector128<T> data4, Vector128<T> data5, out Vector128<T> xB, out Vector128<T> y, out Vector128<T> yB, out Vector128<T> z, out Vector128<T> zB) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
            return _instance.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup3Zip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup3Zip_AcceleratedTypes;
#else
                return _instance.YGroup3Zip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup3Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, out Vector128<float> data1, out Vector128<float> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup3Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, out Vector128<double> data1, out Vector128<double> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup3Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, out Vector128<sbyte> data1, out Vector128<sbyte> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup3Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, out Vector128<byte> data1, out Vector128<byte> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup3Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, out Vector128<short> data1, out Vector128<short> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup3Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, out Vector128<ushort> data1, out Vector128<ushort> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup3Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, out Vector128<int> data1, out Vector128<int> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup3Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, out Vector128<uint> data1, out Vector128<uint> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup3Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, out Vector128<long> data1, out Vector128<long> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup3Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, out Vector128<ulong> data1, out Vector128<ulong> data2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3Zip(x, y, z, out data1, out data2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3Zip(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup3Zip_Bit128<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z, out Vector128<T> data1, out Vector128<T> data2) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup3Zip_Bit128(x, y, z, out data1, out data2);
#else
            return _instance.YGroup3Zip_Bit128(x, y, z, out data1, out data2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup3ZipX2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup3ZipX2_AcceleratedTypes;
#else
                return _instance.YGroup3ZipX2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup3ZipX2(Vector128<float> x, Vector128<float> xB, Vector128<float> y, Vector128<float> yB, Vector128<float> z, Vector128<float> zB, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3, out Vector128<float> data4, out Vector128<float> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup3ZipX2(Vector128<double> x, Vector128<double> xB, Vector128<double> y, Vector128<double> yB, Vector128<double> z, Vector128<double> zB, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3, out Vector128<double> data4, out Vector128<double> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup3ZipX2(Vector128<sbyte> x, Vector128<sbyte> xB, Vector128<sbyte> y, Vector128<sbyte> yB, Vector128<sbyte> z, Vector128<sbyte> zB, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3, out Vector128<sbyte> data4, out Vector128<sbyte> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup3ZipX2(Vector128<byte> x, Vector128<byte> xB, Vector128<byte> y, Vector128<byte> yB, Vector128<byte> z, Vector128<byte> zB, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3, out Vector128<byte> data4, out Vector128<byte> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup3ZipX2(Vector128<short> x, Vector128<short> xB, Vector128<short> y, Vector128<short> yB, Vector128<short> z, Vector128<short> zB, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3, out Vector128<short> data4, out Vector128<short> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup3ZipX2(Vector128<ushort> x, Vector128<ushort> xB, Vector128<ushort> y, Vector128<ushort> yB, Vector128<ushort> z, Vector128<ushort> zB, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3, out Vector128<ushort> data4, out Vector128<ushort> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup3ZipX2(Vector128<int> x, Vector128<int> xB, Vector128<int> y, Vector128<int> yB, Vector128<int> z, Vector128<int> zB, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3, out Vector128<int> data4, out Vector128<int> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup3ZipX2(Vector128<uint> x, Vector128<uint> xB, Vector128<uint> y, Vector128<uint> yB, Vector128<uint> z, Vector128<uint> zB, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3, out Vector128<uint> data4, out Vector128<uint> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup3ZipX2(Vector128<long> x, Vector128<long> xB, Vector128<long> y, Vector128<long> yB, Vector128<long> z, Vector128<long> zB, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3, out Vector128<long> data4, out Vector128<long> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup3ZipX2(Vector128<ulong> x, Vector128<ulong> xB, Vector128<ulong> y, Vector128<ulong> yB, Vector128<ulong> z, Vector128<ulong> zB, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3, out Vector128<ulong> data4, out Vector128<ulong> data5) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup3ZipX2_Bit128<T>(Vector128<T> x, Vector128<T> xB, Vector128<T> y, Vector128<T> yB, Vector128<T> z, Vector128<T> zB, out Vector128<T> data1, out Vector128<T> data2, out Vector128<T> data3, out Vector128<T> data4, out Vector128<T> data5) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup3ZipX2_Bit128(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup3ZipX2_Bit128(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup4ToGroup3_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup4ToGroup3_AcceleratedTypes;
#else
                return _instance.YGroup4ToGroup3_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup4ToGroup3(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> result1, out Vector128<float> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup4ToGroup3(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> result1, out Vector128<double> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup4ToGroup3(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup4ToGroup3(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> result1, out Vector128<byte> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup4ToGroup3(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> result1, out Vector128<short> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup4ToGroup3(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> result1, out Vector128<ushort> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup4ToGroup3(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> result1, out Vector128<int> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup4ToGroup3(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> result1, out Vector128<uint> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup4ToGroup3(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> result1, out Vector128<long> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup4ToGroup3(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> result1, out Vector128<ulong> result2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#else
            return _instance.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup4Unzip_AcceleratedTypes;
#else
                return _instance.YGroup4Unzip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup4Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> y, out Vector128<float> z, out Vector128<float> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup4Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> y, out Vector128<double> z, out Vector128<double> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup4Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup4Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup4Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup4Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup4Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> y, out Vector128<int> z, out Vector128<int> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup4Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> y, out Vector128<uint> z, out Vector128<uint> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup4Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> y, out Vector128<long> z, out Vector128<long> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup4Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> y, out Vector128<ulong> z, out Vector128<ulong> w) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> YGroup4Unzip(Vector128<ExInt128> data0, Vector128<ExInt128> data1, Vector128<ExInt128> data2, Vector128<ExInt128> data3, out Vector128<ExInt128> y, out Vector128<ExInt128> z, out Vector128<ExInt128> w) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> YGroup4Unzip(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1, Vector128<ExUInt128> data2, Vector128<ExUInt128> data3, out Vector128<ExUInt128> y, out Vector128<ExUInt128> z, out Vector128<ExUInt128> w) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup4Unzip_Bit128<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3, out Vector128<T> y, out Vector128<T> z, out Vector128<T> w) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
#else
            return _instance.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip_AcceleratedTypes"/>
        public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YGroup4Zip_AcceleratedTypes;
#else
                return _instance.YGroup4Zip_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }
        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YGroup4Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YGroup4Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YGroup4Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YGroup4Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YGroup4Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YGroup4Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YGroup4Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YGroup4Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YGroup4Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YGroup4Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> YGroup4Zip(Vector128<ExInt128> x, Vector128<ExInt128> y, Vector128<ExInt128> z, Vector128<ExInt128> w, out Vector128<ExInt128> data1, out Vector128<ExInt128> data2, out Vector128<ExInt128> data3) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> YGroup4Zip(Vector128<ExUInt128> x, Vector128<ExUInt128> y, Vector128<ExUInt128> z, Vector128<ExUInt128> w, out Vector128<ExUInt128> data1, out Vector128<ExUInt128> data2, out Vector128<ExUInt128> data3) {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup4Zip_Bit128<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w, out Vector128<T> data1, out Vector128<T> data2, out Vector128<T> data3) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
#else
            return _instance.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup6Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup6Unzip_Bit128<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3, Vector128<T> data4, Vector128<T> data5, out Vector128<T> y, out Vector128<T> z, out Vector128<T> w, out Vector128<T> u, out Vector128<T> v) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup6Unzip_Bit128(data0, data1, data2, data3, data4, data5, out y, out z, out w, out u, out v);
#else
            return _instance.YGroup6Unzip_Bit128(data0, data1, data2, data3, data4, data5, out y, out z, out w, out u, out v);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup6Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YGroup6Zip_Bit128<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w, Vector128<T> u, Vector128<T> v, out Vector128<T> data1, out Vector128<T> data2, out Vector128<T> data3, out Vector128<T> data4, out Vector128<T> data5) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || SHORT_CIRCUIT_GENERIC
            return BaseStatics.YGroup6Zip_Bit128(x, y, z, w, u, v, out data1, out data2, out data3, out data4, out data5);
#else
            return _instance.YGroup6Zip_Bit128(x, y, z, w, u, v, out data1, out data2, out data3, out data4, out data5);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue_AcceleratedTypes"/>
        public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsAllTrue_AcceleratedTypes;
#else
                return _instance.YIsAllTrue_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool YIsAllTrue<T>(Vector128<T> value) where T : struct {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsAllTrue(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsAllTrue(value);
#else
            return _instance.YIsAllTrue(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue_AcceleratedTypes"/>
        public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsAnyTrue_AcceleratedTypes;
#else
                return _instance.YIsAnyTrue_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool YIsAnyTrue<T>(Vector128<T> value) where T : struct {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsAnyTrue(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsAnyTrue(value);
#else
            return _instance.YIsAnyTrue(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger_AcceleratedTypes"/>
        public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsEvenInteger_AcceleratedTypes;
#else
                return _instance.YIsEvenInteger_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsEvenInteger(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsEvenInteger(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YIsEvenInteger(Vector128<sbyte> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YIsEvenInteger(Vector128<byte> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YIsEvenInteger(Vector128<short> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YIsEvenInteger(Vector128<ushort> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsEvenInteger(Vector128<int> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YIsEvenInteger(Vector128<uint> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsEvenInteger(Vector128<long> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YIsEvenInteger(Vector128<ulong> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsEvenInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsEvenInteger(value);
#else
            return _instance.YIsEvenInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsFinite_AcceleratedTypes"/>
        public static TypeCodeFlags YIsFinite_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsFinite_AcceleratedTypes;
#else
                return _instance.YIsFinite_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsFinite(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsFinite(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsFinite(value);
#else
            return _instance.YIsFinite(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsFinite(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsFinite(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsFinite(value);
#else
            return _instance.YIsFinite(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsInfinity_AcceleratedTypes"/>
        public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsInfinity_AcceleratedTypes;
#else
                return _instance.YIsInfinity_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsInfinity(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsInfinity(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinity(value);
#else
            return _instance.YIsInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsInfinity(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsInfinity(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinity(value);
#else
            return _instance.YIsInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN_AcceleratedTypes"/>
        public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsInfinityOrNaN_AcceleratedTypes;
#else
                return _instance.YIsInfinityOrNaN_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsInfinityOrNaN(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsInfinityOrNaN(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinityOrNaN(value);
#else
            return _instance.YIsInfinityOrNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsInfinityOrNaN(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsInfinityOrNaN(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInfinityOrNaN(value);
#else
            return _instance.YIsInfinityOrNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsInteger_AcceleratedTypes"/>
        public static TypeCodeFlags YIsInteger_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsInteger_AcceleratedTypes;
#else
                return _instance.YIsInteger_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsInteger(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInteger(value);
#else
            return _instance.YIsInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsInteger(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsInteger(value);
#else
            return _instance.YIsInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNaN_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNaN_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNaN_AcceleratedTypes;
#else
                return _instance.YIsNaN_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsNaN(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNaN(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNaN(value);
#else
            return _instance.YIsNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsNaN(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNaN(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNaN(value);
#else
            return _instance.YIsNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNegative_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNegative_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNegative_AcceleratedTypes;
#else
                return _instance.YIsNegative_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsNegative(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegative(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsNegative(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegative(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YIsNegative(Vector128<sbyte> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegative(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YIsNegative(Vector128<short> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegative(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsNegative(Vector128<int> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegative(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsNegative(Vector128<long> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegative(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegative(value);
#else
            return _instance.YIsNegative(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNegativeInfinity_AcceleratedTypes;
#else
                return _instance.YIsNegativeInfinity_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsNegativeInfinity(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegativeInfinity(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeInfinity(value);
#else
            return _instance.YIsNegativeInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsNegativeInfinity(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegativeInfinity(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeInfinity(value);
#else
            return _instance.YIsNegativeInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNegativeZero_AcceleratedTypes;
#else
                return _instance.YIsNegativeZero_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsNegativeZero(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegativeZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeZero(value);
#else
            return _instance.YIsNegativeZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsNegativeZero(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNegativeZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNegativeZero(value);
#else
            return _instance.YIsNegativeZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNormal_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNormal_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNormal_AcceleratedTypes;
#else
                return _instance.YIsNormal_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsNormal(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNormal(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNormal(value);
#else
            return _instance.YIsNormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsNormal(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNormal(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNormal(value);
#else
            return _instance.YIsNormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNotEquals_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNotEquals_AcceleratedTypes;
#else
                return _instance.YIsNotEquals_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YIsNotEquals(Vector128<float> left, Vector128<float> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YIsNotEquals(Vector128<double> left, Vector128<double> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YIsNotEquals(Vector128<sbyte> left, Vector128<sbyte> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YIsNotEquals(Vector128<byte> left, Vector128<byte> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YIsNotEquals(Vector128<short> left, Vector128<short> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YIsNotEquals(Vector128<ushort> left, Vector128<ushort> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsNotEquals(Vector128<int> left, Vector128<int> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YIsNotEquals(Vector128<uint> left, Vector128<uint> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsNotEquals(Vector128<long> left, Vector128<long> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YIsNotEquals(Vector128<ulong> left, Vector128<ulong> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotEquals(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotEquals(left, right);
#else
            return _instance.YIsNotEquals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN_AcceleratedTypes"/>
        public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsNotNaN_AcceleratedTypes;
#else
                return _instance.YIsNotNaN_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsNotNaN(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotNaN(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotNaN(value);
#else
            return _instance.YIsNotNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsNotNaN(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsNotNaN(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsNotNaN(value);
#else
            return _instance.YIsNotNaN(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger_AcceleratedTypes"/>
        public static TypeCodeFlags YIsOddInteger_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsOddInteger_AcceleratedTypes;
#else
                return _instance.YIsOddInteger_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsOddInteger(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsOddInteger(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YIsOddInteger(Vector128<sbyte> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YIsOddInteger(Vector128<byte> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YIsOddInteger(Vector128<short> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YIsOddInteger(Vector128<ushort> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsOddInteger(Vector128<int> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YIsOddInteger(Vector128<uint> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsOddInteger(Vector128<long> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YIsOddInteger(Vector128<ulong> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsOddInteger(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsOddInteger(value);
#else
            return _instance.YIsOddInteger(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsPositive_AcceleratedTypes"/>
        public static TypeCodeFlags YIsPositive_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsPositive_AcceleratedTypes;
#else
                return _instance.YIsPositive_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsPositive(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsPositive(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsPositive(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsPositive(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YIsPositive(Vector128<sbyte> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsPositive(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YIsPositive(Vector128<short> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsPositive(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsPositive(Vector128<int> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsPositive(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsPositive(Vector128<long> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsPositive(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositive(value);
#else
            return _instance.YIsPositive(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity_AcceleratedTypes"/>
        public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsPositiveInfinity_AcceleratedTypes;
#else
                return _instance.YIsPositiveInfinity_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsPositiveInfinity(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsPositiveInfinity(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositiveInfinity(value);
#else
            return _instance.YIsPositiveInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsPositiveInfinity(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsPositiveInfinity(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsPositiveInfinity(value);
#else
            return _instance.YIsPositiveInfinity(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal_AcceleratedTypes"/>
        public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsSubnormal_AcceleratedTypes;
#else
                return _instance.YIsSubnormal_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsSubnormal(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsSubnormal(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsSubnormal(value);
#else
            return _instance.YIsSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsSubnormal(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsSubnormal(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsSubnormal(value);
#else
            return _instance.YIsSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsZero_AcceleratedTypes"/>
        public static TypeCodeFlags YIsZero_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsZero_AcceleratedTypes;
#else
                return _instance.YIsZero_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsZero(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsZero(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YIsZero(Vector128<sbyte> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YIsZero(Vector128<byte> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YIsZero(Vector128<short> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YIsZero(Vector128<ushort> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsZero(Vector128<int> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YIsZero(Vector128<uint> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsZero(Vector128<long> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YIsZero(Vector128<ulong> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZero(value);
#else
            return _instance.YIsZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal_AcceleratedTypes"/>
        public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YIsZeroOrSubnormal_AcceleratedTypes;
#else
                return _instance.YIsZeroOrSubnormal_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YIsZeroOrSubnormal(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZeroOrSubnormal(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZeroOrSubnormal(value);
#else
            return _instance.YIsZeroOrSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YIsZeroOrSubnormal(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YIsZeroOrSubnormal(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YIsZeroOrSubnormal(value);
#else
            return _instance.YIsZeroOrSubnormal(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YMaxNumber_AcceleratedTypes"/>
        public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YMaxNumber_AcceleratedTypes;
#else
                return _instance.YMaxNumber_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YMaxNumber(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YMaxNumber(Vector128<float> left, Vector128<float> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YMaxNumber(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YMaxNumber(left, right);
#else
            return _instance.YMaxNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YMaxNumber(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YMaxNumber(Vector128<double> left, Vector128<double> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YMaxNumber(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YMaxNumber(left, right);
#else
            return _instance.YMaxNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YMinNumber_AcceleratedTypes"/>
        public static TypeCodeFlags YMinNumber_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YMinNumber_AcceleratedTypes;
#else
                return _instance.YMinNumber_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YMinNumber(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YMinNumber(Vector128<float> left, Vector128<float> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YMinNumber(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YMinNumber(left, right);
#else
            return _instance.YMinNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YMinNumber(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YMinNumber(Vector128<double> left, Vector128<double> right) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YMinNumber(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YMinNumber(left, right);
#else
            return _instance.YMinNumber(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_AcceleratedTypes;
#else
                return _instance.YNarrowSaturate_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturate_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{short}, Vector128{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YNarrowSaturate(lower, upper);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ushort}, Vector128{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YNarrowSaturate(lower, upper);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{int}, Vector128{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YNarrowSaturate(lower, upper);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{uint}, Vector128{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YNarrowSaturate(lower, upper);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{long}, Vector128{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YNarrowSaturate(lower, upper);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ulong}, Vector128{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YNarrowSaturate(lower, upper);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_AcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YNarrowSaturateUnsigned(lower, upper);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{int}, Vector128{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YNarrowSaturateUnsigned(lower, upper);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{long}, Vector128{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YNarrowSaturateUnsigned(lower, upper);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YOrNot_AcceleratedTypes"/>
        public static TypeCodeFlags YOrNot_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YOrNot_AcceleratedTypes;
#else
                return _instance.YOrNot_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YOrNot{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YOrNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YOrNot(left, right);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.YOrNot(left, right);
#else
            return _instance.YOrNot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YRoundToEven_AcceleratedTypes"/>
        public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YRoundToEven_AcceleratedTypes;
#else
                return _instance.YRoundToEven_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YRoundToEven(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YRoundToEven(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToEven(value);
#else
            return _instance.YRoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YRoundToEven(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YRoundToEven(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToEven(value);
#else
            return _instance.YRoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YRoundToZero_AcceleratedTypes"/>
        public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YRoundToZero_AcceleratedTypes;
#else
                return _instance.YRoundToZero_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YRoundToZero(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YRoundToZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToZero(value);
#else
            return _instance.YRoundToZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YRoundToZero(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YRoundToZero(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YRoundToZero(value);
#else
            return _instance.YRoundToZero(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleG2_AcceleratedTypes;
#else
                return _instance.YShuffleG2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleG2(Vector128<float> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleG2(Vector128<double> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleG2(Vector128<sbyte> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleG2(Vector128<byte> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleG2(Vector128<short> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleG2(Vector128<ushort> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleG2(Vector128<int> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleG2(Vector128<uint> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleG2(Vector128<long> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleG2(Vector128<ulong> source, ShuffleControlG2 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG2(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2(source, control);
#else
            return _instance.YShuffleG2(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleG2_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleG2_Const(Vector128<double> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleG2_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleG2_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleG2_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleG2_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleG2_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleG2_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleG2_Const(Vector128<long> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleG2_Const(Vector128<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG2_Const(source, control);
#else
            return _instance.YShuffleG2_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleG4_AcceleratedTypes;
#else
                return _instance.YShuffleG4_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleG4(Vector128<float> source, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleG4(Vector128<sbyte> source, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleG4(Vector128<byte> source, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleG4(Vector128<short> source, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleG4(Vector128<ushort> source, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleG4(Vector128<int> source, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleG4(Vector128<uint> source, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4(source, control);
#else
            return _instance.YShuffleG4(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleG4_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4_Const(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleG4_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4_Const(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleG4_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4_Const(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleG4_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4_Const(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleG4_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4_Const(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleG4_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4_Const(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleG4_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4_Const(source, control);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4_Const(source, control);
#else
            return _instance.YShuffleG4_Const(source, control);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleG4X2_AcceleratedTypes;
#else
                return _instance.YShuffleG4X2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control, out Vector128<float> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control, out Vector128<double> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control, out Vector128<sbyte> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control, out Vector128<byte> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control, out Vector128<short> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control, out Vector128<ushort> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control, out Vector128<int> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control, out Vector128<uint> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control, out Vector128<long> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control, out Vector128<ulong> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<float> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<double> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<sbyte> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<byte> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<short> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ushort> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<int> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<uint> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<long> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ulong> result1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleG4X2_Const(source0, source1, control, out result1);
#else
            return _instance.YShuffleG4X2_Const(source0, source1, control, out result1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleInsert_AcceleratedTypes;
#else
                return _instance.YShuffleInsert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert(back, vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleKernel_AcceleratedTypes;
#else
                return _instance.YShuffleKernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel(vector, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleKernel_Args(indices, out args0, out args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleKernel_Args(indices, out args0, out args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleKernel_Args(indices, out args0, out args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleKernel_Args(indices, out args0, out args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleKernel_Args(indices, out args0, out args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleKernel_Args(indices, out args0, out args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleKernel_Args(indices, out args0, out args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleKernel_Args(indices, out args0, out args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleKernel_Core(vector, args0, args1);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX2_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX2_AcceleratedTypes;
#else
                return _instance.YShuffleX2_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2(vector0, vector1, indices);
#else
            return _instance.YShuffleX2(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX2Insert_AcceleratedTypes;
#else
                return _instance.YShuffleX2Insert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert(back, vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert(back, vector0, vector1, indices);
#else
            return _instance.YShuffleX2Insert(back, vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX2Kernel_AcceleratedTypes;
#else
                return _instance.YShuffleX2Kernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel(vector0, vector1, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel(vector0, vector1, indices);
#else
            return _instance.YShuffleX2Kernel(vector0, vector1, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX2Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#else
            return _instance.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX3_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3_AcceleratedTypes;
#else
                return _instance.YShuffleX3_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3Insert_AcceleratedTypes;
#else
                return _instance.YShuffleX3Insert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX3Kernel_AcceleratedTypes;
#else
                return _instance.YShuffleX3Kernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#else
            return _instance.YShuffleX3Kernel(vector0, vector1, vector2, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX3Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#else
            return _instance.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX4_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX4_AcceleratedTypes;
#else
                return _instance.YShuffleX4_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX4Insert_AcceleratedTypes;
#else
                return _instance.YShuffleX4Insert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#else
            _instance.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#else
            return _instance.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleX4Kernel_AcceleratedTypes;
#else
                return _instance.YShuffleX4Kernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#else
            return _instance.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleX4Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                WasmStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#else
            _instance.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#else
            return _instance.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YSign_AcceleratedTypes"/>
        public static TypeCodeFlags YSign_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YSign_AcceleratedTypes;
#else
                return _instance.YSign_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YSign(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YSign(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YSign(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YSign(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YSign(Vector128<sbyte> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YSign(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YSign(Vector128<short> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YSign(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YSign(Vector128<int> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YSign(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YSign(Vector128<long> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YSign(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSign(value);
#else
            return _instance.YSign(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YSignFloat_AcceleratedTypes"/>
        public static TypeCodeFlags YSignFloat_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YSignFloat_AcceleratedTypes;
#else
                return _instance.YSignFloat_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YSignFloat(Vector128<float> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YSignFloat(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSignFloat(value);
#else
            return _instance.YSignFloat(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YSignFloat(Vector128<double> value) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YSignFloat(value);
            }
#endif // SHORT_CIRCUIT_WASM
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YSignFloat(value);
#else
            return _instance.YSignFloat(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


#endif
    }
}
