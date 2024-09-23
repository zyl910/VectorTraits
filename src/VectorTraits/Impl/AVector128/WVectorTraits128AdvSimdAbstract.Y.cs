using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Impl.AVector128 {
    using Statics = WVectorTraits128AdvSimd.Statics;

    partial class WVectorTraits128AdvSimdAbstract {
#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.YBitToByte_IsAccelerated"/>
        public override bool YBitToByte_IsAccelerated {
            get {
                return Statics.YBitToByte_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YBitToByte"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YBitToByte(uint value) {
            return Statics.YBitToByte(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YBitToInt16_IsAccelerated"/>
        public override bool YBitToInt16_IsAccelerated {
            get {
                return Statics.YBitToInt16_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YBitToInt16"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YBitToInt16(uint value) {
            return Statics.YBitToInt16(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YBitToInt32_IsAccelerated"/>
        public override bool YBitToInt32_IsAccelerated {
            get {
                return Statics.YBitToInt32_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YBitToInt32"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YBitToInt32(uint value) {
            return Statics.YBitToInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YBitToInt64_IsAccelerated"/>
        public override bool YBitToInt64_IsAccelerated {
            get {
                return Statics.YBitToInt64_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YBitToInt64"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YBitToInt64(uint value) {
            return Statics.YBitToInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
        public override TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YClamp(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YClamp(Vector128<sbyte> value, Vector128<sbyte> amin, Vector128<sbyte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YClamp(Vector128<byte> value, Vector128<byte> amin, Vector128<byte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YClamp(Vector128<short> value, Vector128<short> amin, Vector128<short> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YClamp(Vector128<ushort> value, Vector128<ushort> amin, Vector128<ushort> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YClamp(Vector128<int> value, Vector128<int> amin, Vector128<int> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YClamp(Vector128<uint> value, Vector128<uint> amin, Vector128<uint> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IWVectorTraits128.YCopySign_AcceleratedTypes"/>
        public override TypeCodeFlags YCopySign_AcceleratedTypes {
            get {
                return Statics.YCopySign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YCopySign(Vector128<float> value, Vector128<float> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YCopySign(Vector128<double> value, Vector128<double> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YCopySign(Vector128<sbyte> value, Vector128<sbyte> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YCopySign(Vector128<short> value, Vector128<short> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YCopySign(Vector128<int> value, Vector128<int> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YCopySign(Vector128<long> value, Vector128<long> sign) {
            return Statics.YCopySign(value, sign);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup1ToGroup3_AcceleratedTypes {
            get {
                return Statics.YGroup1ToGroup3_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup1ToGroup3(Vector128<float> x, out Vector128<float> result1, out Vector128<float> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup1ToGroup3(Vector128<double> x, out Vector128<double> result1, out Vector128<double> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup1ToGroup3(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup1ToGroup3(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup1ToGroup3(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup1ToGroup3(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup1ToGroup3(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup1ToGroup3(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup1ToGroup3(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup1ToGroup3(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2) {
            return Statics.YGroup1ToGroup3(x, out result1, out result2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup1ToGroup4_AcceleratedTypes {
            get {
                return Statics.YGroup1ToGroup4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup1ToGroup4(Vector128<float> x, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup1ToGroup4(Vector128<double> x, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup1ToGroup4(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup1ToGroup4(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup1ToGroup4(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup1ToGroup4(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup1ToGroup4(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup1ToGroup4(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup1ToGroup4(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup1ToGroup4(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
            return Statics.YGroup1ToGroup4(x, out result1, out result2, out result3);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup1ToGroup4WithW_AcceleratedTypes {
            get {
                return Statics.YGroup1ToGroup4WithW_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup1ToGroup4WithW(Vector128<float> x, Vector128<float> w, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup1ToGroup4WithW(Vector128<double> x, Vector128<double> w, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup1ToGroup4WithW(Vector128<sbyte> x, Vector128<sbyte> w, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup1ToGroup4WithW(Vector128<byte> x, Vector128<byte> w, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup1ToGroup4WithW(Vector128<short> x, Vector128<short> w, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup1ToGroup4WithW(Vector128<ushort> x, Vector128<ushort> w, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup1ToGroup4WithW(Vector128<int> x, Vector128<int> w, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup1ToGroup4WithW(Vector128<uint> x, Vector128<uint> w, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup1ToGroup4WithW(Vector128<long> x, Vector128<long> w, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup1ToGroup4WithW(Vector128<ulong> x, Vector128<ulong> w, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
            return Statics.YGroup1ToGroup4WithW(x, w, out result1, out result2, out result3);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
            get {
                return Statics.YGroup2Unzip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup2Unzip(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup2Unzip(Vector128<double> data0, Vector128<double> data1, out Vector128<double> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup2Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup2Unzip(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup2Unzip(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup2Unzip(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup2Unzip(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup2Unzip(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup2Unzip(Vector128<long> data0, Vector128<long> data1, out Vector128<long> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup2Unzip(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
            get {
                return Statics.YGroup2UnzipEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup2UnzipEven(Vector128<float> data0, Vector128<float> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup2UnzipEven(Vector128<double> data0, Vector128<double> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup2UnzipEven(Vector128<sbyte> data0, Vector128<sbyte> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup2UnzipEven(Vector128<byte> data0, Vector128<byte> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup2UnzipEven(Vector128<short> data0, Vector128<short> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup2UnzipEven(Vector128<ushort> data0, Vector128<ushort> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup2UnzipEven(Vector128<int> data0, Vector128<int> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup2UnzipEven(Vector128<uint> data0, Vector128<uint> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup2UnzipEven(Vector128<long> data0, Vector128<long> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup2UnzipEven(Vector128<ulong> data0, Vector128<ulong> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
            get {
                return Statics.YGroup2UnzipOdd_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup2UnzipOdd(Vector128<float> data0, Vector128<float> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup2UnzipOdd(Vector128<double> data0, Vector128<double> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup2UnzipOdd(Vector128<sbyte> data0, Vector128<sbyte> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup2UnzipOdd(Vector128<byte> data0, Vector128<byte> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup2UnzipOdd(Vector128<short> data0, Vector128<short> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup2UnzipOdd(Vector128<ushort> data0, Vector128<ushort> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup2UnzipOdd(Vector128<int> data0, Vector128<int> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup2UnzipOdd(Vector128<uint> data0, Vector128<uint> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup2UnzipOdd(Vector128<long> data0, Vector128<long> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup2UnzipOdd(Vector128<ulong> data0, Vector128<ulong> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2Zip_AcceleratedTypes {
            get {
                return Statics.YGroup2Zip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup2Zip(Vector128<float> x, Vector128<float> y, out Vector128<float> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup2Zip(Vector128<double> x, Vector128<double> y, out Vector128<double> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup2Zip(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<sbyte> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup2Zip(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup2Zip(Vector128<short> x, Vector128<short> y, out Vector128<short> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup2Zip(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup2Zip(Vector128<int> x, Vector128<int> y, out Vector128<int> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup2Zip(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup2Zip(Vector128<long> x, Vector128<long> y, out Vector128<long> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup2Zip(Vector128<ulong> x, Vector128<ulong> y, out Vector128<ulong> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
            get {
                return Statics.YGroup2ZipHigh_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup2ZipHigh(Vector128<float> x, Vector128<float> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup2ZipHigh(Vector128<double> x, Vector128<double> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup2ZipHigh(Vector128<sbyte> x, Vector128<sbyte> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup2ZipHigh(Vector128<byte> x, Vector128<byte> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup2ZipHigh(Vector128<short> x, Vector128<short> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup2ZipHigh(Vector128<ushort> x, Vector128<ushort> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup2ZipHigh(Vector128<int> x, Vector128<int> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup2ZipHigh(Vector128<uint> x, Vector128<uint> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup2ZipHigh(Vector128<long> x, Vector128<long> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup2ZipHigh(Vector128<ulong> x, Vector128<ulong> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
            get {
                return Statics.YGroup2ZipLow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup2ZipLow(Vector128<float> x, Vector128<float> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup2ZipLow(Vector128<double> x, Vector128<double> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup2ZipLow(Vector128<sbyte> x, Vector128<sbyte> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup2ZipLow(Vector128<byte> x, Vector128<byte> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup2ZipLow(Vector128<short> x, Vector128<short> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup2ZipLow(Vector128<ushort> x, Vector128<ushort> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup2ZipLow(Vector128<int> x, Vector128<int> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup2ZipLow(Vector128<uint> x, Vector128<uint> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup2ZipLow(Vector128<long> x, Vector128<long> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup2ZipLow(Vector128<ulong> x, Vector128<ulong> y) {
            return Statics.YGroup2ZipLow(x, y);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup3ToGroup4_AcceleratedTypes {
            get {
                return Statics.YGroup3ToGroup4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup3ToGroup4(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup3ToGroup4(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup3ToGroup4(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup3ToGroup4(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup3ToGroup4(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup3ToGroup4(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup3ToGroup4(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup3ToGroup4(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup3ToGroup4(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup3ToGroup4(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
            return Statics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
            get {
                return Statics.YGroup3Unzip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup3Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> y, out Vector128<float> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup3Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> y, out Vector128<double> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup3Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> y, out Vector128<sbyte> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup3Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> y, out Vector128<byte> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup3Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> y, out Vector128<short> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup3Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> y, out Vector128<ushort> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup3Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> y, out Vector128<int> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup3Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> y, out Vector128<uint> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup3Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> y, out Vector128<long> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup3Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> y, out Vector128<ulong> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
            get {
                return Statics.YGroup3UnzipX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup3UnzipX2(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, Vector128<float> data4, Vector128<float> data5, out Vector128<float> xB, out Vector128<float> y, out Vector128<float> yB, out Vector128<float> z, out Vector128<float> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup3UnzipX2(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, Vector128<double> data4, Vector128<double> data5, out Vector128<double> xB, out Vector128<double> y, out Vector128<double> yB, out Vector128<double> z, out Vector128<double> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup3UnzipX2(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, Vector128<sbyte> data4, Vector128<sbyte> data5, out Vector128<sbyte> xB, out Vector128<sbyte> y, out Vector128<sbyte> yB, out Vector128<sbyte> z, out Vector128<sbyte> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup3UnzipX2(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, Vector128<byte> data4, Vector128<byte> data5, out Vector128<byte> xB, out Vector128<byte> y, out Vector128<byte> yB, out Vector128<byte> z, out Vector128<byte> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup3UnzipX2(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, Vector128<short> data4, Vector128<short> data5, out Vector128<short> xB, out Vector128<short> y, out Vector128<short> yB, out Vector128<short> z, out Vector128<short> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup3UnzipX2(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, Vector128<ushort> data4, Vector128<ushort> data5, out Vector128<ushort> xB, out Vector128<ushort> y, out Vector128<ushort> yB, out Vector128<ushort> z, out Vector128<ushort> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup3UnzipX2(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, Vector128<int> data4, Vector128<int> data5, out Vector128<int> xB, out Vector128<int> y, out Vector128<int> yB, out Vector128<int> z, out Vector128<int> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup3UnzipX2(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, Vector128<uint> data4, Vector128<uint> data5, out Vector128<uint> xB, out Vector128<uint> y, out Vector128<uint> yB, out Vector128<uint> z, out Vector128<uint> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup3UnzipX2(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, Vector128<long> data4, Vector128<long> data5, out Vector128<long> xB, out Vector128<long> y, out Vector128<long> yB, out Vector128<long> z, out Vector128<long> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup3UnzipX2(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, Vector128<ulong> data4, Vector128<ulong> data5, out Vector128<ulong> xB, out Vector128<ulong> y, out Vector128<ulong> yB, out Vector128<ulong> z, out Vector128<ulong> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup3Zip_AcceleratedTypes {
            get {
                return Statics.YGroup3Zip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup3Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, out Vector128<float> data1, out Vector128<float> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup3Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, out Vector128<double> data1, out Vector128<double> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup3Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, out Vector128<sbyte> data1, out Vector128<sbyte> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup3Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, out Vector128<byte> data1, out Vector128<byte> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup3Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, out Vector128<short> data1, out Vector128<short> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup3Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, out Vector128<ushort> data1, out Vector128<ushort> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup3Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, out Vector128<int> data1, out Vector128<int> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup3Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, out Vector128<uint> data1, out Vector128<uint> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup3Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, out Vector128<long> data1, out Vector128<long> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup3Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, out Vector128<ulong> data1, out Vector128<ulong> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup3ZipX2_AcceleratedTypes {
            get {
                return Statics.YGroup3ZipX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup3ZipX2(Vector128<float> x, Vector128<float> xB, Vector128<float> y, Vector128<float> yB, Vector128<float> z, Vector128<float> zB, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3, out Vector128<float> data4, out Vector128<float> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup3ZipX2(Vector128<double> x, Vector128<double> xB, Vector128<double> y, Vector128<double> yB, Vector128<double> z, Vector128<double> zB, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3, out Vector128<double> data4, out Vector128<double> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup3ZipX2(Vector128<sbyte> x, Vector128<sbyte> xB, Vector128<sbyte> y, Vector128<sbyte> yB, Vector128<sbyte> z, Vector128<sbyte> zB, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3, out Vector128<sbyte> data4, out Vector128<sbyte> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup3ZipX2(Vector128<byte> x, Vector128<byte> xB, Vector128<byte> y, Vector128<byte> yB, Vector128<byte> z, Vector128<byte> zB, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3, out Vector128<byte> data4, out Vector128<byte> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup3ZipX2(Vector128<short> x, Vector128<short> xB, Vector128<short> y, Vector128<short> yB, Vector128<short> z, Vector128<short> zB, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3, out Vector128<short> data4, out Vector128<short> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup3ZipX2(Vector128<ushort> x, Vector128<ushort> xB, Vector128<ushort> y, Vector128<ushort> yB, Vector128<ushort> z, Vector128<ushort> zB, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3, out Vector128<ushort> data4, out Vector128<ushort> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup3ZipX2(Vector128<int> x, Vector128<int> xB, Vector128<int> y, Vector128<int> yB, Vector128<int> z, Vector128<int> zB, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3, out Vector128<int> data4, out Vector128<int> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup3ZipX2(Vector128<uint> x, Vector128<uint> xB, Vector128<uint> y, Vector128<uint> yB, Vector128<uint> z, Vector128<uint> zB, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3, out Vector128<uint> data4, out Vector128<uint> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup3ZipX2(Vector128<long> x, Vector128<long> xB, Vector128<long> y, Vector128<long> yB, Vector128<long> z, Vector128<long> zB, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3, out Vector128<long> data4, out Vector128<long> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup3ZipX2(Vector128<ulong> x, Vector128<ulong> xB, Vector128<ulong> y, Vector128<ulong> yB, Vector128<ulong> z, Vector128<ulong> zB, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3, out Vector128<ulong> data4, out Vector128<ulong> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup4ToGroup3_AcceleratedTypes {
            get {
                return Statics.YGroup4ToGroup3_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup4ToGroup3(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> result1, out Vector128<float> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup4ToGroup3(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> result1, out Vector128<double> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup4ToGroup3(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup4ToGroup3(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> result1, out Vector128<byte> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup4ToGroup3(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> result1, out Vector128<short> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup4ToGroup3(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> result1, out Vector128<ushort> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup4ToGroup3(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> result1, out Vector128<int> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup4ToGroup3(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> result1, out Vector128<uint> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup4ToGroup3(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> result1, out Vector128<long> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup4ToGroup3(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> result1, out Vector128<ulong> result2) {
            return Statics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
            get {
                return Statics.YGroup4Unzip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup4Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> y, out Vector128<float> z, out Vector128<float> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup4Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> y, out Vector128<double> z, out Vector128<double> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup4Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup4Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup4Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup4Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup4Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> y, out Vector128<int> z, out Vector128<int> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup4Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> y, out Vector128<uint> z, out Vector128<uint> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup4Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> y, out Vector128<long> z, out Vector128<long> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup4Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> y, out Vector128<ulong> z, out Vector128<ulong> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }


        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup4Zip_AcceleratedTypes {
            get {
                return Statics.YGroup4Zip_AcceleratedTypes;
            }
        }
        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YGroup4Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YGroup4Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YGroup4Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YGroup4Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YGroup4Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YGroup4Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YGroup4Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YGroup4Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YGroup4Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YGroup4Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue_AcceleratedTypes"/>
        public override TypeCodeFlags YIsAllTrue_AcceleratedTypes {
            get {
                return Statics.YIsAllTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool YIsAllTrue<T>(Vector128<T> value) where T : struct {
            return Statics.YIsAllTrue(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue_AcceleratedTypes"/>
        public override TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
            get {
                return Statics.YIsAnyTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool YIsAnyTrue<T>(Vector128<T> value) where T : struct {
            return Statics.YIsAnyTrue(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
            get {
                return Statics.YIsEvenInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsEvenInteger(Vector128<float> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsEvenInteger(Vector128<double> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YIsEvenInteger(Vector128<sbyte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YIsEvenInteger(Vector128<byte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YIsEvenInteger(Vector128<short> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YIsEvenInteger(Vector128<ushort> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsEvenInteger(Vector128<int> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YIsEvenInteger(Vector128<uint> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsEvenInteger(Vector128<long> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YIsEvenInteger(Vector128<ulong> value) {
            return Statics.YIsEvenInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsFinite_AcceleratedTypes"/>
        public override TypeCodeFlags YIsFinite_AcceleratedTypes {
            get {
                return Statics.YIsFinite_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsFinite(Vector128<float> value) {
            return Statics.YIsFinite(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsFinite(Vector128<double> value) {
            return Statics.YIsFinite(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInfinity_AcceleratedTypes {
            get {
                return Statics.YIsInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsInfinity(Vector128<float> value) {
            return Statics.YIsInfinity(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsInfinity(Vector128<double> value) {
            return Statics.YIsInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
            get {
                return Statics.YIsInfinityOrNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsInfinityOrNaN(Vector128<float> value) {
            return Statics.YIsInfinityOrNaN(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsInfinityOrNaN(Vector128<double> value) {
            return Statics.YIsInfinityOrNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInteger_AcceleratedTypes {
            get {
                return Statics.YIsInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsInteger(Vector128<float> value) {
            return Statics.YIsInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsInteger(Vector128<double> value) {
            return Statics.YIsInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNaN_AcceleratedTypes {
            get {
                return Statics.YIsNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsNaN(Vector128<float> value) {
            return Statics.YIsNaN(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNaN(Vector128<double> value) {
            return Statics.YIsNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNegative_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegative_AcceleratedTypes {
            get {
                return Statics.YIsNegative_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsNegative(Vector128<float> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNegative(Vector128<double> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YIsNegative(Vector128<sbyte> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YIsNegative(Vector128<short> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsNegative(Vector128<int> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNegative(Vector128<long> value) {
            return Statics.YIsNegative(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
            get {
                return Statics.YIsNegativeInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsNegativeInfinity(Vector128<float> value) {
            return Statics.YIsNegativeInfinity(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNegativeInfinity(Vector128<double> value) {
            return Statics.YIsNegativeInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
            get {
                return Statics.YIsNegativeZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsNegativeZero(Vector128<float> value) {
            return Statics.YIsNegativeZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNegativeZero(Vector128<double> value) {
            return Statics.YIsNegativeZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNormal_AcceleratedTypes {
            get {
                return Statics.YIsNormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsNormal(Vector128<float> value) {
            return Statics.YIsNormal(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNormal(Vector128<double> value) {
            return Statics.YIsNormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNotEquals_AcceleratedTypes {
            get {
                return Statics.YIsNotEquals_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YIsNotEquals(Vector128<float> left, Vector128<float> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YIsNotEquals(Vector128<double> left, Vector128<double> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YIsNotEquals(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YIsNotEquals(Vector128<byte> left, Vector128<byte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YIsNotEquals(Vector128<short> left, Vector128<short> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YIsNotEquals(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsNotEquals(Vector128<int> left, Vector128<int> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YIsNotEquals(Vector128<uint> left, Vector128<uint> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNotEquals(Vector128<long> left, Vector128<long> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YIsNotEquals(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.YIsNotEquals(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNotNaN_AcceleratedTypes {
            get {
                return Statics.YIsNotNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsNotNaN(Vector128<float> value) {
            return Statics.YIsNotNaN(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNotNaN(Vector128<double> value) {
            return Statics.YIsNotNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsOddInteger_AcceleratedTypes {
            get {
                return Statics.YIsOddInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsOddInteger(Vector128<float> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsOddInteger(Vector128<double> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YIsOddInteger(Vector128<sbyte> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YIsOddInteger(Vector128<byte> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YIsOddInteger(Vector128<short> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YIsOddInteger(Vector128<ushort> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsOddInteger(Vector128<int> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YIsOddInteger(Vector128<uint> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsOddInteger(Vector128<long> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YIsOddInteger(Vector128<ulong> value) {
            return Statics.YIsOddInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsPositive_AcceleratedTypes"/>
        public override TypeCodeFlags YIsPositive_AcceleratedTypes {
            get {
                return Statics.YIsPositive_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsPositive(Vector128<float> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsPositive(Vector128<double> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YIsPositive(Vector128<sbyte> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YIsPositive(Vector128<short> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsPositive(Vector128<int> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsPositive(Vector128<long> value) {
            return Statics.YIsPositive(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
            get {
                return Statics.YIsPositiveInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsPositiveInfinity(Vector128<float> value) {
            return Statics.YIsPositiveInfinity(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsPositiveInfinity(Vector128<double> value) {
            return Statics.YIsPositiveInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsSubnormal(Vector128<float> value) {
            return Statics.YIsSubnormal(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsSubnormal(Vector128<double> value) {
            return Statics.YIsSubnormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsZero_AcceleratedTypes"/>
        public override TypeCodeFlags YIsZero_AcceleratedTypes {
            get {
                return Statics.YIsZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsZero(Vector128<float> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsZero(Vector128<double> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YIsZero(Vector128<sbyte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YIsZero(Vector128<byte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YIsZero(Vector128<short> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YIsZero(Vector128<ushort> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsZero(Vector128<int> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YIsZero(Vector128<uint> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsZero(Vector128<long> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YIsZero(Vector128<ulong> value) {
            return Statics.YIsZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsZeroOrSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YIsZeroOrSubnormal(Vector128<float> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsZeroOrSubnormal(Vector128<double> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YMaxNumber_AcceleratedTypes"/>
        public override TypeCodeFlags YMaxNumber_AcceleratedTypes {
            get {
                return Statics.YMaxNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YMaxNumber(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YMaxNumber(Vector128<float> left, Vector128<float> right) {
            return Statics.YMaxNumber(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YMaxNumber(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YMaxNumber(Vector128<double> left, Vector128<double> right) {
            return Statics.YMaxNumber(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.YMinNumber_AcceleratedTypes"/>
        public override TypeCodeFlags YMinNumber_AcceleratedTypes {
            get {
                return Statics.YMinNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YMinNumber(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YMinNumber(Vector128<float> left, Vector128<float> right) {
            return Statics.YMinNumber(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.YMinNumber(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YMinNumber(Vector128<double> left, Vector128<double> right) {
            return Statics.YMinNumber(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{short}, Vector128{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ushort}, Vector128{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{int}, Vector128{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{uint}, Vector128{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{long}, Vector128{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ulong}, Vector128{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{int}, Vector128{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{long}, Vector128{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits128.YOrNot_AcceleratedTypes"/>
        public override TypeCodeFlags YOrNot_AcceleratedTypes {
            get {
                return Statics.YOrNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YOrNot{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<T> YOrNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.YOrNot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.YRoundToEven_AcceleratedTypes"/>
        public override TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
                return Statics.YRoundToEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YRoundToEven(Vector128<float> value) {
            return Statics.YRoundToEven(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YRoundToEven(Vector128<double> value) {
            return Statics.YRoundToEven(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YRoundToZero_AcceleratedTypes"/>
        public override TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
                return Statics.YRoundToZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YRoundToZero(Vector128<float> value) {
            return Statics.YRoundToZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YRoundToZero(Vector128<double> value) {
            return Statics.YRoundToZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
                return Statics.YShuffleG2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG2(Vector128<float> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG2(Vector128<double> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG2(Vector128<sbyte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG2(Vector128<byte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG2(Vector128<short> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG2(Vector128<ushort> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG2(Vector128<int> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG2(Vector128<uint> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG2(Vector128<long> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG2(Vector128<ulong> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG2_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG2_Const(Vector128<double> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG2_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG2_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG2_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG2_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG2_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG2_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG2_Const(Vector128<long> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG2_Const(Vector128<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
                return Statics.YShuffleG4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG4(Vector128<float> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG4(Vector128<sbyte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG4(Vector128<byte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG4(Vector128<short> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG4(Vector128<ushort> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG4(Vector128<int> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG4(Vector128<uint> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG4_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG4_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG4_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG4_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG4_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG4_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG4_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
                return Statics.YShuffleG4X2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control, out Vector128<float> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control, out Vector128<double> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control, out Vector128<sbyte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control, out Vector128<byte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control, out Vector128<short> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control, out Vector128<ushort> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control, out Vector128<int> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control, out Vector128<uint> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control, out Vector128<long> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control, out Vector128<ulong> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<float> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<double> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<sbyte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<byte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<short> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ushort> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<int> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<uint> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<long> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ulong> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX2_AcceleratedTypes {
            get {
                return Statics.YShuffleX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX2(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX2(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX2(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX2(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX2(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX2(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX2(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX2(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX2(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX2(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX2_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX2_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX2_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX2_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX2_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX2_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX2_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX2_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX2_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX2_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX2Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX2Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX2Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX2Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX2Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX2Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX2Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX2Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX2Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX2Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX2Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX2Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX2Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX2Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX2Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX2Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX2Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX2Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX2Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX2Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX2Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
            get {
                return Statics.YShuffleX2Kernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX2Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX2Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX2Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX2Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX2Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX2Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX2Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX2Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX2Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX2Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX2Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX2Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX2Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX2Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX2Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX2Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX2Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX2Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX2Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX2Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX3_AcceleratedTypes {
            get {
                return Statics.YShuffleX3_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX3(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX3(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX3(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX3(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX3(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX3(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX3(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX3(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX3(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX3(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX3_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX3_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX3_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX3_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX3_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX3_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX3_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX3_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX3_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX3_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX3Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX3Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX3Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX3Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX3Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX3Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX3Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX3Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX3Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX3Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX3Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX3Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX3Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX3Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX3Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX3Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX3Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX3Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX3Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX3Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX3Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
            get {
                return Statics.YShuffleX3Kernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX3Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX3Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX3Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX3Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX3Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX3Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX3Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX3Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX3Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX3Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX3Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX3Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX3Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX3Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX3Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX3Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX3Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX3Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX3Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX3Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX4_AcceleratedTypes {
            get {
                return Statics.YShuffleX4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX4(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX4(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX4(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX4(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX4(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX4(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX4(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX4(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX4(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX4(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX4_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX4_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX4_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX4_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX4_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX4_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX4_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX4_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX4_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX4_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX4Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX4Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX4Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX4Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX4Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX4Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX4Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX4Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX4Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX4Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX4Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX4Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX4Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX4Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX4Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX4Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX4Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX4Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX4Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX4Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX4Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
            get {
                return Statics.YSign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX4Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX4Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX4Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX4Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX4Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX4Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX4Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX4Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX4Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX4Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleX4Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleX4Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleX4Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleX4Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleX4Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleX4Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleX4Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleX4Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleX4Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleX4Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IWVectorTraits128.YSign_AcceleratedTypes"/>
        public override TypeCodeFlags YSign_AcceleratedTypes {
            get {
                return Statics.YSign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YSign(Vector128<float> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YSign(Vector128<double> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YSign(Vector128<sbyte> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YSign(Vector128<short> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YSign(Vector128<int> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YSign(Vector128<long> value) {
            return Statics.YSign(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YSignFloat_AcceleratedTypes"/>
        public override TypeCodeFlags YSignFloat_AcceleratedTypes {
            get {
                return Statics.YSignFloat_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YSignFloat(Vector128<float> value) {
            return Statics.YSignFloat(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YSignFloat(Vector128<double> value) {
            return Statics.YSignFloat(value);
        }

#endif
    }
}
