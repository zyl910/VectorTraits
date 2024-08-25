using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Impl.AVector {
    using Statics = VectorTraits512Avx512.Statics;

    partial class VectorTraits512Avx512Abstract {
#if NET8_0_OR_GREATER

        /// <inheritdoc cref="IVectorTraits.YBitToByte_IsAccelerated"/>
        public override bool YBitToByte_IsAccelerated {
            get {
                return Statics.YBitToByte_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YBitToByte"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YBitToByte(ulong value) {
            return Statics.YBitToByte(value);
        }


        /// <inheritdoc cref="IVectorTraits.YBitToInt16_IsAccelerated"/>
        public override bool YBitToInt16_IsAccelerated {
            get {
                return Statics.YBitToInt16_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YBitToInt16"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YBitToInt16(ulong value) {
            return Statics.YBitToInt16(value);
        }


        /// <inheritdoc cref="IVectorTraits.YBitToInt32_IsAccelerated"/>
        public override bool YBitToInt32_IsAccelerated {
            get {
                return Statics.YBitToInt32_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YBitToInt32"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YBitToInt32(ulong value) {
            return Statics.YBitToInt32(value);
        }


        /// <inheritdoc cref="IVectorTraits.YBitToInt64_IsAccelerated"/>
        public override bool YBitToInt64_IsAccelerated {
            get {
                return Statics.YBitToInt64_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YBitToInt64"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YBitToInt64(ulong value) {
            return Statics.YBitToInt64(value);
        }


        /// <inheritdoc cref="IVectorTraits.YClamp_AcceleratedTypes"/>
        public override TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YClamp(Vector<float> value, Vector<float> amin, Vector<float> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{double}, Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YClamp(Vector<double> value, Vector<double> amin, Vector<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YClamp(Vector<sbyte> value, Vector<sbyte> amin, Vector<sbyte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YClamp(Vector<byte> value, Vector<byte> amin, Vector<byte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YClamp(Vector<short> value, Vector<short> amin, Vector<short> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YClamp(Vector<ushort> value, Vector<ushort> amin, Vector<ushort> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YClamp(Vector<int> value, Vector<int> amin, Vector<int> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YClamp(Vector<uint> value, Vector<uint> amin, Vector<uint> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YClamp(Vector<long> value, Vector<long> amin, Vector<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YClamp(Vector<ulong> value, Vector<ulong> amin, Vector<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IVectorTraits.YCopySign_AcceleratedTypes"/>
        public override TypeCodeFlags YCopySign_AcceleratedTypes {
            get {
                return Statics.YCopySign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YCopySign(Vector<float> value, Vector<float> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YCopySign(Vector<double> value, Vector<double> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YCopySign(Vector<sbyte> value, Vector<sbyte> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YCopySign(Vector<short> value, Vector<short> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YCopySign(Vector<int> value, Vector<int> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YCopySign(Vector<long> value, Vector<long> sign) {
            return Statics.YCopySign(value, sign);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
            get {
                return Statics.YGroup2Unzip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup2Unzip(Vector<float> data0, Vector<float> data1, out Vector<float> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{double}, Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup2Unzip(Vector<double> data0, Vector<double> data1, out Vector<double> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup2Unzip(Vector<sbyte> data0, Vector<sbyte> data1, out Vector<sbyte> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup2Unzip(Vector<byte> data0, Vector<byte> data1, out Vector<byte> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{short}, Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup2Unzip(Vector<short> data0, Vector<short> data1, out Vector<short> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup2Unzip(Vector<ushort> data0, Vector<ushort> data1, out Vector<ushort> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{int}, Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup2Unzip(Vector<int> data0, Vector<int> data1, out Vector<int> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{uint}, Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup2Unzip(Vector<uint> data0, Vector<uint> data1, out Vector<uint> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{long}, Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup2Unzip(Vector<long> data0, Vector<long> data1, out Vector<long> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ulong}, Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup2Unzip(Vector<ulong> data0, Vector<ulong> data1, out Vector<ulong> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExInt128> YGroup2Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1, out Vector<ExInt128> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExUInt128> YGroup2Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1, out Vector<ExUInt128> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YGroup2Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, out Vector<T> y) where T : struct {
            return Statics.YGroup2Unzip_Bit128(data0, data1, out y);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
            get {
                return Statics.YGroup2UnzipEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup2UnzipEven(Vector<float> data0, Vector<float> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup2UnzipEven(Vector<double> data0, Vector<double> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup2UnzipEven(Vector<sbyte> data0, Vector<sbyte> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup2UnzipEven(Vector<byte> data0, Vector<byte> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup2UnzipEven(Vector<short> data0, Vector<short> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup2UnzipEven(Vector<ushort> data0, Vector<ushort> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup2UnzipEven(Vector<int> data0, Vector<int> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup2UnzipEven(Vector<uint> data0, Vector<uint> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup2UnzipEven(Vector<long> data0, Vector<long> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup2UnzipEven(Vector<ulong> data0, Vector<ulong> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ExInt128}, Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExInt128> YGroup2UnzipEven(Vector<ExInt128> data0, Vector<ExInt128> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExUInt128> YGroup2UnzipEven(Vector<ExUInt128> data0, Vector<ExUInt128> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
            get {
                return Statics.YGroup2UnzipOdd_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup2UnzipOdd(Vector<float> data0, Vector<float> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup2UnzipOdd(Vector<double> data0, Vector<double> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup2UnzipOdd(Vector<sbyte> data0, Vector<sbyte> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup2UnzipOdd(Vector<byte> data0, Vector<byte> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup2UnzipOdd(Vector<short> data0, Vector<short> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup2UnzipOdd(Vector<ushort> data0, Vector<ushort> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup2UnzipOdd(Vector<int> data0, Vector<int> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup2UnzipOdd(Vector<uint> data0, Vector<uint> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup2UnzipOdd(Vector<long> data0, Vector<long> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup2UnzipOdd(Vector<ulong> data0, Vector<ulong> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ExInt128}, Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExInt128> YGroup2UnzipOdd(Vector<ExInt128> data0, Vector<ExInt128> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExUInt128> YGroup2UnzipOdd(Vector<ExUInt128> data0, Vector<ExUInt128> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup2Zip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2Zip_AcceleratedTypes {
            get {
                return Statics.YGroup2Zip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup2Zip(Vector<float> x, Vector<float> y, out Vector<float> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{double}, Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup2Zip(Vector<double> x, Vector<double> y, out Vector<double> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup2Zip(Vector<sbyte> x, Vector<sbyte> y, out Vector<sbyte> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup2Zip(Vector<byte> x, Vector<byte> y, out Vector<byte> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{short}, Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup2Zip(Vector<short> x, Vector<short> y, out Vector<short> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup2Zip(Vector<ushort> x, Vector<ushort> y, out Vector<ushort> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{int}, Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup2Zip(Vector<int> x, Vector<int> y, out Vector<int> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{uint}, Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup2Zip(Vector<uint> x, Vector<uint> y, out Vector<uint> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{long}, Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup2Zip(Vector<long> x, Vector<long> y, out Vector<long> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ulong}, Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup2Zip(Vector<ulong> x, Vector<ulong> y, out Vector<ulong> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExInt128> YGroup2Zip(Vector<ExInt128> x, Vector<ExInt128> y, out Vector<ExInt128> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExUInt128> YGroup2Zip(Vector<ExUInt128> x, Vector<ExUInt128> y, out Vector<ExUInt128> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YGroup2Zip_Bit128<T>(Vector<T> x, Vector<T> y, out Vector<T> data1) where T : struct {
            return Statics.YGroup2Zip_Bit128(x, y, out data1);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
            get {
                return Statics.YGroup2ZipHigh_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup2ZipHigh(Vector<float> x, Vector<float> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup2ZipHigh(Vector<double> x, Vector<double> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup2ZipHigh(Vector<sbyte> x, Vector<sbyte> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup2ZipHigh(Vector<byte> x, Vector<byte> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup2ZipHigh(Vector<short> x, Vector<short> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup2ZipHigh(Vector<ushort> x, Vector<ushort> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup2ZipHigh(Vector<int> x, Vector<int> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup2ZipHigh(Vector<uint> x, Vector<uint> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup2ZipHigh(Vector<long> x, Vector<long> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup2ZipHigh(Vector<ulong> x, Vector<ulong> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ExInt128}, Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExInt128> YGroup2ZipHigh(Vector<ExInt128> x, Vector<ExInt128> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExUInt128> YGroup2ZipHigh(Vector<ExUInt128> x, Vector<ExUInt128> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
            get {
                return Statics.YGroup2ZipLow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup2ZipLow(Vector<float> x, Vector<float> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup2ZipLow(Vector<double> x, Vector<double> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup2ZipLow(Vector<sbyte> x, Vector<sbyte> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup2ZipLow(Vector<byte> x, Vector<byte> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup2ZipLow(Vector<short> x, Vector<short> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup2ZipLow(Vector<ushort> x, Vector<ushort> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup2ZipLow(Vector<int> x, Vector<int> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup2ZipLow(Vector<uint> x, Vector<uint> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup2ZipLow(Vector<long> x, Vector<long> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup2ZipLow(Vector<ulong> x, Vector<ulong> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ExInt128}, Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExInt128> YGroup2ZipLow(Vector<ExInt128> x, Vector<ExInt128> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExUInt128> YGroup2ZipLow(Vector<ExUInt128> x, Vector<ExUInt128> y) {
            return Statics.YGroup2ZipLow(x, y);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
            get {
                return Statics.YGroup3Unzip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup3Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2, out Vector<float> y, out Vector<float> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup3Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2, out Vector<double> y, out Vector<double> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup3Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> y, out Vector<sbyte> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup3Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> y, out Vector<byte> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup3Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> y, out Vector<short> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup3Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> y, out Vector<ushort> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup3Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> y, out Vector<int> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup3Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> y, out Vector<uint> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup3Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2, out Vector<long> y, out Vector<long> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup3Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, out Vector<ulong> y, out Vector<ulong> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YGroup3Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, out Vector<T> y, out Vector<T> z) where T : struct {
            return Statics.YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
            get {
                return Statics.YGroup3UnzipX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup3UnzipX2(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, Vector<float> data4, Vector<float> data5, out Vector<float> xB, out Vector<float> y, out Vector<float> yB, out Vector<float> z, out Vector<float> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup3UnzipX2(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, Vector<double> data4, Vector<double> data5, out Vector<double> xB, out Vector<double> y, out Vector<double> yB, out Vector<double> z, out Vector<double> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup3UnzipX2(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, Vector<sbyte> data4, Vector<sbyte> data5, out Vector<sbyte> xB, out Vector<sbyte> y, out Vector<sbyte> yB, out Vector<sbyte> z, out Vector<sbyte> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup3UnzipX2(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, Vector<byte> data4, Vector<byte> data5, out Vector<byte> xB, out Vector<byte> y, out Vector<byte> yB, out Vector<byte> z, out Vector<byte> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup3UnzipX2(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, Vector<short> data4, Vector<short> data5, out Vector<short> xB, out Vector<short> y, out Vector<short> yB, out Vector<short> z, out Vector<short> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup3UnzipX2(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, Vector<ushort> data4, Vector<ushort> data5, out Vector<ushort> xB, out Vector<ushort> y, out Vector<ushort> yB, out Vector<ushort> z, out Vector<ushort> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup3UnzipX2(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, Vector<int> data4, Vector<int> data5, out Vector<int> xB, out Vector<int> y, out Vector<int> yB, out Vector<int> z, out Vector<int> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup3UnzipX2(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, Vector<uint> data4, Vector<uint> data5, out Vector<uint> xB, out Vector<uint> y, out Vector<uint> yB, out Vector<uint> z, out Vector<uint> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup3UnzipX2(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, Vector<long> data4, Vector<long> data5, out Vector<long> xB, out Vector<long> y, out Vector<long> yB, out Vector<long> z, out Vector<long> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup3UnzipX2(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, Vector<ulong> data4, Vector<ulong> data5, out Vector<ulong> xB, out Vector<ulong> y, out Vector<ulong> yB, out Vector<ulong> z, out Vector<ulong> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YGroup3UnzipX2_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, Vector<T> data4, Vector<T> data5, out Vector<T> xB, out Vector<T> y, out Vector<T> yB, out Vector<T> z, out Vector<T> zB) where T : struct {
            return Statics.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup3Zip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup3Zip_AcceleratedTypes {
            get {
                return Statics.YGroup3Zip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup3Zip(Vector<float> x, Vector<float> y, Vector<float> z, out Vector<float> data1, out Vector<float> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup3Zip(Vector<double> x, Vector<double> y, Vector<double> z, out Vector<double> data1, out Vector<double> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup3Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, out Vector<sbyte> data1, out Vector<sbyte> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup3Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z, out Vector<byte> data1, out Vector<byte> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup3Zip(Vector<short> x, Vector<short> y, Vector<short> z, out Vector<short> data1, out Vector<short> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup3Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, out Vector<ushort> data1, out Vector<ushort> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup3Zip(Vector<int> x, Vector<int> y, Vector<int> z, out Vector<int> data1, out Vector<int> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup3Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z, out Vector<uint> data1, out Vector<uint> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup3Zip(Vector<long> x, Vector<long> y, Vector<long> z, out Vector<long> data1, out Vector<long> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup3Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, out Vector<ulong> data1, out Vector<ulong> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YGroup3Zip_Bit128<T>(Vector<T> x, Vector<T> y, Vector<T> z, out Vector<T> data1, out Vector<T> data2) where T : struct {
            return Statics.YGroup3Zip_Bit128(x, y, z, out data1, out data2);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup3ZipX2_AcceleratedTypes {
            get {
                return Statics.YGroup3ZipX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup3ZipX2(Vector<float> x, Vector<float> xB, Vector<float> y, Vector<float> yB, Vector<float> z, Vector<float> zB, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3, out Vector<float> data4, out Vector<float> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup3ZipX2(Vector<double> x, Vector<double> xB, Vector<double> y, Vector<double> yB, Vector<double> z, Vector<double> zB, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3, out Vector<double> data4, out Vector<double> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup3ZipX2(Vector<sbyte> x, Vector<sbyte> xB, Vector<sbyte> y, Vector<sbyte> yB, Vector<sbyte> z, Vector<sbyte> zB, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3, out Vector<sbyte> data4, out Vector<sbyte> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup3ZipX2(Vector<byte> x, Vector<byte> xB, Vector<byte> y, Vector<byte> yB, Vector<byte> z, Vector<byte> zB, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3, out Vector<byte> data4, out Vector<byte> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup3ZipX2(Vector<short> x, Vector<short> xB, Vector<short> y, Vector<short> yB, Vector<short> z, Vector<short> zB, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3, out Vector<short> data4, out Vector<short> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup3ZipX2(Vector<ushort> x, Vector<ushort> xB, Vector<ushort> y, Vector<ushort> yB, Vector<ushort> z, Vector<ushort> zB, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3, out Vector<ushort> data4, out Vector<ushort> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup3ZipX2(Vector<int> x, Vector<int> xB, Vector<int> y, Vector<int> yB, Vector<int> z, Vector<int> zB, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3, out Vector<int> data4, out Vector<int> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup3ZipX2(Vector<uint> x, Vector<uint> xB, Vector<uint> y, Vector<uint> yB, Vector<uint> z, Vector<uint> zB, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3, out Vector<uint> data4, out Vector<uint> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup3ZipX2(Vector<long> x, Vector<long> xB, Vector<long> y, Vector<long> yB, Vector<long> z, Vector<long> zB, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3, out Vector<long> data4, out Vector<long> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup3ZipX2(Vector<ulong> x, Vector<ulong> xB, Vector<ulong> y, Vector<ulong> yB, Vector<ulong> z, Vector<ulong> zB, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3, out Vector<ulong> data4, out Vector<ulong> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YGroup3ZipX2_Bit128<T>(Vector<T> x, Vector<T> xB, Vector<T> y, Vector<T> yB, Vector<T> z, Vector<T> zB, out Vector<T> data1, out Vector<T> data2, out Vector<T> data3, out Vector<T> data4, out Vector<T> data5) where T : struct {
            return Statics.YGroup3ZipX2_Bit128(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
            get {
                return Statics.YGroup4Unzip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup4Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, out Vector<float> y, out Vector<float> z, out Vector<float> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup4Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, out Vector<double> y, out Vector<double> z, out Vector<double> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup4Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, out Vector<sbyte> y, out Vector<sbyte> z, out Vector<sbyte> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup4Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, out Vector<byte> y, out Vector<byte> z, out Vector<byte> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup4Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, out Vector<short> y, out Vector<short> z, out Vector<short> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup4Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, out Vector<ushort> y, out Vector<ushort> z, out Vector<ushort> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup4Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, out Vector<int> y, out Vector<int> z, out Vector<int> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup4Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, out Vector<uint> y, out Vector<uint> z, out Vector<uint> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup4Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, out Vector<long> y, out Vector<long> z, out Vector<long> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup4Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, out Vector<ulong> y, out Vector<ulong> z, out Vector<ulong> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExInt128> YGroup4Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1, Vector<ExInt128> data2, Vector<ExInt128> data3, out Vector<ExInt128> y, out Vector<ExInt128> z, out Vector<ExInt128> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExUInt128> YGroup4Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1, Vector<ExUInt128> data2, Vector<ExUInt128> data3, out Vector<ExUInt128> y, out Vector<ExUInt128> z, out Vector<ExUInt128> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YGroup4Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, out Vector<T> y, out Vector<T> z, out Vector<T> w) where T : struct {
            return Statics.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
        }


        /// <inheritdoc cref="IVectorTraits.YGroup4Zip_AcceleratedTypes"/>
        public override TypeCodeFlags YGroup4Zip_AcceleratedTypes {
            get {
                return Statics.YGroup4Zip_AcceleratedTypes;
            }
        }
        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YGroup4Zip(Vector<float> x, Vector<float> y, Vector<float> z, Vector<float> w, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YGroup4Zip(Vector<double> x, Vector<double> y, Vector<double> z, Vector<double> w, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YGroup4Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, Vector<sbyte> w, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YGroup4Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z, Vector<byte> w, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YGroup4Zip(Vector<short> x, Vector<short> y, Vector<short> z, Vector<short> w, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YGroup4Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, Vector<ushort> w, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YGroup4Zip(Vector<int> x, Vector<int> y, Vector<int> z, Vector<int> w, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YGroup4Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z, Vector<uint> w, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YGroup4Zip(Vector<long> x, Vector<long> y, Vector<long> z, Vector<long> w, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YGroup4Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, Vector<ulong> w, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExInt128> YGroup4Zip(Vector<ExInt128> x, Vector<ExInt128> y, Vector<ExInt128> z, Vector<ExInt128> w, out Vector<ExInt128> data1, out Vector<ExInt128> data2, out Vector<ExInt128> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ExUInt128> YGroup4Zip(Vector<ExUInt128> x, Vector<ExUInt128> y, Vector<ExUInt128> z, Vector<ExUInt128> w, out Vector<ExUInt128> data1, out Vector<ExUInt128> data2, out Vector<ExUInt128> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YGroup4Zip_Bit128<T>(Vector<T> x, Vector<T> y, Vector<T> z, Vector<T> w, out Vector<T> data1, out Vector<T> data2, out Vector<T> data3) where T : struct {
            return Statics.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
        }


        /// <inheritdoc cref="IVectorTraits.YIsAllTrue_AcceleratedTypes"/>
        public override TypeCodeFlags YIsAllTrue_AcceleratedTypes {
            get {
                return Statics.YIsAllTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsAllTrue{T}(Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool YIsAllTrue<T>(Vector<T> value) where T : struct {
            return Statics.YIsAllTrue(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsAnyTrue_AcceleratedTypes"/>
        public override TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
            get {
                return Statics.YIsAnyTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsAnyTrue{T}(Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool YIsAnyTrue<T>(Vector<T> value) where T : struct {
            return Statics.YIsAnyTrue(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
            get {
                return Statics.YIsEvenInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsEvenInteger(Vector<float> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsEvenInteger(Vector<double> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsEvenInteger(Vector<sbyte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YIsEvenInteger(Vector<byte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsEvenInteger(Vector<short> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YIsEvenInteger(Vector<ushort> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsEvenInteger(Vector<int> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YIsEvenInteger(Vector<uint> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsEvenInteger(Vector<long> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YIsEvenInteger(Vector<ulong> value) {
            return Statics.YIsEvenInteger(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsFinite_AcceleratedTypes"/>
        public override TypeCodeFlags YIsFinite_AcceleratedTypes {
            get {
                return Statics.YIsFinite_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsFinite(Vector<float> value) {
            return Statics.YIsFinite(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsFinite(Vector<double> value) {
            return Statics.YIsFinite(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInfinity_AcceleratedTypes {
            get {
                return Statics.YIsInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsInfinity(Vector<float> value) {
            return Statics.YIsInfinity(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsInfinity(Vector<double> value) {
            return Statics.YIsInfinity(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
            get {
                return Statics.YIsInfinityOrNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsInfinityOrNaN(Vector<float> value) {
            return Statics.YIsInfinityOrNaN(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsInfinityOrNaN(Vector<double> value) {
            return Statics.YIsInfinityOrNaN(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInteger_AcceleratedTypes {
            get {
                return Statics.YIsInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsInteger(Vector<float> value) {
            return Statics.YIsInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsInteger(Vector<double> value) {
            return Statics.YIsInteger(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNaN_AcceleratedTypes {
            get {
                return Statics.YIsNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNaN(Vector<float> value) {
            return Statics.YIsNaN(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNaN(Vector<double> value) {
            return Statics.YIsNaN(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNegative_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegative_AcceleratedTypes {
            get {
                return Statics.YIsNegative_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNegative(Vector<float> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNegative(Vector<double> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsNegative(Vector<sbyte> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsNegative(Vector<short> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNegative(Vector<int> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNegative(Vector<long> value) {
            return Statics.YIsNegative(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
            get {
                return Statics.YIsNegativeInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNegativeInfinity(Vector<float> value) {
            return Statics.YIsNegativeInfinity(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNegativeInfinity(Vector<double> value) {
            return Statics.YIsNegativeInfinity(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNegativeZero_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
            get {
                return Statics.YIsNegativeZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNegativeZero(Vector<float> value) {
            return Statics.YIsNegativeZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNegativeZero(Vector<double> value) {
            return Statics.YIsNegativeZero(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNormal_AcceleratedTypes {
            get {
                return Statics.YIsNormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNormal(Vector<float> value) {
            return Statics.YIsNormal(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNormal(Vector<double> value) {
            return Statics.YIsNormal(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNotEquals_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNotEquals_AcceleratedTypes {
            get {
                return Statics.YIsNotEquals_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YIsNotEquals(Vector<float> left, Vector<float> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YIsNotEquals(Vector<double> left, Vector<double> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsNotEquals(Vector<sbyte> left, Vector<sbyte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YIsNotEquals(Vector<byte> left, Vector<byte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsNotEquals(Vector<short> left, Vector<short> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YIsNotEquals(Vector<ushort> left, Vector<ushort> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNotEquals(Vector<int> left, Vector<int> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YIsNotEquals(Vector<uint> left, Vector<uint> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNotEquals(Vector<long> left, Vector<long> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YIsNotEquals(Vector<ulong> left, Vector<ulong> right) {
            return Statics.YIsNotEquals(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNotNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNotNaN_AcceleratedTypes {
            get {
                return Statics.YIsNotNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNotNaN(Vector<float> value) {
            return Statics.YIsNotNaN(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNotNaN(Vector<double> value) {
            return Statics.YIsNotNaN(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsOddInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsOddInteger_AcceleratedTypes {
            get {
                return Statics.YIsOddInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsOddInteger(Vector<float> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsOddInteger(Vector<double> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsOddInteger(Vector<sbyte> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YIsOddInteger(Vector<byte> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsOddInteger(Vector<short> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YIsOddInteger(Vector<ushort> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsOddInteger(Vector<int> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YIsOddInteger(Vector<uint> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsOddInteger(Vector<long> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YIsOddInteger(Vector<ulong> value) {
            return Statics.YIsOddInteger(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsPositive_AcceleratedTypes"/>
        public override TypeCodeFlags YIsPositive_AcceleratedTypes {
            get {
                return Statics.YIsPositive_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsPositive(Vector<float> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsPositive(Vector<double> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsPositive(Vector<sbyte> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsPositive(Vector<short> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsPositive(Vector<int> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsPositive(Vector<long> value) {
            return Statics.YIsPositive(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
            get {
                return Statics.YIsPositiveInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsPositiveInfinity(Vector<float> value) {
            return Statics.YIsPositiveInfinity(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsPositiveInfinity(Vector<double> value) {
            return Statics.YIsPositiveInfinity(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsSubnormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsSubnormal(Vector<float> value) {
            return Statics.YIsSubnormal(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsSubnormal(Vector<double> value) {
            return Statics.YIsSubnormal(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsZero_AcceleratedTypes"/>
        public override TypeCodeFlags YIsZero_AcceleratedTypes {
            get {
                return Statics.YIsZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsZero(Vector<float> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsZero(Vector<double> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsZero(Vector<sbyte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YIsZero(Vector<byte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsZero(Vector<short> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YIsZero(Vector<ushort> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsZero(Vector<int> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YIsZero(Vector<uint> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsZero(Vector<long> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YIsZero(Vector<ulong> value) {
            return Statics.YIsZero(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsZeroOrSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsZeroOrSubnormal(Vector<float> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsZeroOrSubnormal(Vector<double> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }


        /// <inheritdoc cref="IVectorTraits.YMaxNumber_AcceleratedTypes"/>
        public override TypeCodeFlags YMaxNumber_AcceleratedTypes {
            get {
                return Statics.YMaxNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YMaxNumber(Vector<float> left, Vector<float> right) {
            return Statics.YMaxNumber(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YMaxNumber(Vector<double> left, Vector<double> right) {
            return Statics.YMaxNumber(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.YMinNumber_AcceleratedTypes"/>
        public override TypeCodeFlags YMinNumber_AcceleratedTypes {
            get {
                return Statics.YMinNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YMinNumber(Vector<float> left, Vector<float> right) {
            return Statics.YMinNumber(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YMinNumber(Vector<double> left, Vector<double> right) {
            return Statics.YMinNumber(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{short}, Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ushort}, Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{int}, Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{uint}, Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{long}, Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ulong}, Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{short}, Vector{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{int}, Vector{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{long}, Vector{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }


        /// <inheritdoc cref="IVectorTraits.YOrNot_AcceleratedTypes"/>
        public override TypeCodeFlags YOrNot_AcceleratedTypes {
            get {
                return Statics.YOrNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YOrNot{T}(Vector{T}, Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YOrNot<T>(Vector<T> left, Vector<T> right) where T : struct {
            return Statics.YOrNot(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.YRoundToEven_AcceleratedTypes"/>
        public override TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
                return Statics.YRoundToEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YRoundToEven(Vector<float> value) {
            return Statics.YRoundToEven(value);
        }

        /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YRoundToEven(Vector<double> value) {
            return Statics.YRoundToEven(value);
        }


        /// <inheritdoc cref="IVectorTraits.YRoundToZero_AcceleratedTypes"/>
        public override TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
                return Statics.YRoundToZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YRoundToZero(Vector<float> value) {
            return Statics.YRoundToZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YRoundToZero(Vector<double> value) {
            return Statics.YRoundToZero(value);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleG2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
                return Statics.YShuffleG2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG2(Vector<float> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG2(Vector<double> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG2(Vector<sbyte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG2(Vector<byte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG2(Vector<short> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG2(Vector<ushort> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG2(Vector<int> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG2(Vector<uint> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG2(Vector<long> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG2(Vector<ulong> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG2_Const(Vector<float> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG2_Const(Vector<double> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG2_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG2_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG2_Const(Vector<short> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG2_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG2_Const(Vector<int> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG2_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG2_Const(Vector<long> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG2_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IVectorTraits.YShuffleG4_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
                return Statics.YShuffleG4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG4(Vector<float> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG4(Vector<double> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG4(Vector<sbyte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG4(Vector<byte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG4(Vector<short> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG4(Vector<ushort> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG4(Vector<int> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG4(Vector<uint> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG4(Vector<long> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG4(Vector<ulong> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG4_Const(Vector<float> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG4_Const(Vector<double> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG4_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG4_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG4_Const(Vector<short> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG4_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG4_Const(Vector<int> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG4_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG4_Const(Vector<long> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG4_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
                return Statics.YShuffleG4X2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG4X2(Vector<float> source0, Vector<float> source1, ShuffleControlG4 control, out Vector<float> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG4X2(Vector<double> source0, Vector<double> source1, ShuffleControlG4 control, out Vector<double> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG4X2(Vector<sbyte> source0, Vector<sbyte> source1, ShuffleControlG4 control, out Vector<sbyte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG4X2(Vector<byte> source0, Vector<byte> source1, ShuffleControlG4 control, out Vector<byte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG4X2(Vector<short> source0, Vector<short> source1, ShuffleControlG4 control, out Vector<short> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG4X2(Vector<ushort> source0, Vector<ushort> source1, ShuffleControlG4 control, out Vector<ushort> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG4X2(Vector<int> source0, Vector<int> source1, ShuffleControlG4 control, out Vector<int> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG4X2(Vector<uint> source0, Vector<uint> source1, ShuffleControlG4 control, out Vector<uint> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG4X2(Vector<long> source0, Vector<long> source1, ShuffleControlG4 control, out Vector<long> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG4X2(Vector<ulong> source0, Vector<ulong> source1, ShuffleControlG4 control, out Vector<ulong> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG4X2_Const(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<float> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG4X2_Const(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<double> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG4X2_Const(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<sbyte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG4X2_Const(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<byte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG4X2_Const(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<short> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG4X2_Const(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ushort> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG4X2_Const(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<int> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG4X2_Const(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<uint> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG4X2_Const(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<long> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG4X2_Const(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ulong> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleInsert(Vector<float> back, Vector<float> vector, Vector<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleInsert(Vector<double> back, Vector<double> vector, Vector<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleInsert(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleInsert(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleInsert(Vector<short> back, Vector<short> vector, Vector<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleInsert(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleInsert(Vector<int> back, Vector<int> vector, Vector<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleInsert(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleInsert(Vector<long> back, Vector<long> vector, Vector<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleInsert(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleInsert_Core(Vector<float> back, Vector<float> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleInsert_Core(Vector<double> back, Vector<double> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleInsert_Core(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleInsert_Core(Vector<byte> back, Vector<byte> vector, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleInsert_Core(Vector<short> back, Vector<short> vector, Vector<short> args0, Vector<short> args1, Vector<short> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleInsert_Core(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleInsert_Core(Vector<int> back, Vector<int> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleInsert_Core(Vector<uint> back, Vector<uint> vector, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleInsert_Core(Vector<long> back, Vector<long> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleInsert_Core(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleKernel(Vector<float> vector, Vector<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleKernel(Vector<double> vector, Vector<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleKernel(Vector<int> vector, Vector<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleKernel(Vector<uint> vector, Vector<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleKernel(Vector<long> vector, Vector<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleKernel(Vector<ulong> vector, Vector<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{float}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleKernel_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{double}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleKernel_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleKernel_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleKernel_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleKernel_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleKernel_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleKernel_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleKernel_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleKernel_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleKernel_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX2_AcceleratedTypes {
            get {
                return Statics.YShuffleX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX2(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX2(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX2(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX2(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX2(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX2(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX2(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX2(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX2(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX2(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX2_Core(Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX2_Core(Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX2_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX2_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX2_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX2_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX2_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX2_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX2_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX2_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX2Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX2Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX2Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX2Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX2Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX2Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX2Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX2Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX2Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX2Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX2Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX2Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX2Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX2Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX2Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX2Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX2Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX2Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX2Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX2Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX2Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
            get {
                return Statics.YShuffleX2Kernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX2Kernel(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX2Kernel(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX2Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX2Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX2Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX2Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX2Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX2Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX2Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX2Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX2Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX2Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX2Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX2Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX2Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX2Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX2Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX2Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX2Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX2Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX2Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX3_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX3_AcceleratedTypes {
            get {
                return Statics.YShuffleX3_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX3(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX3(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX3(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX3(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX3(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX3(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX3(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX3(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX3(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX3(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX3_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX3_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX3_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX3_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX3_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX3_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX3_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX3_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX3_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX3_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX3Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX3Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX3Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX3Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX3Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX3Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX3Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX3Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX3Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX3Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX3Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX3Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX3Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX3Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX3Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX3Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX3Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX3Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX3Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX3Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX3Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
            get {
                return Statics.YShuffleX3Kernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX3Kernel(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX3Kernel(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX3Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX3Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX3Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX3Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX3Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX3Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX3Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX3Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX3Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX3Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX3Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX3Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX3Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX3Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX3Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX3Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX3Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX3Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX3Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX4_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX4_AcceleratedTypes {
            get {
                return Statics.YShuffleX4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX4(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX4(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX4(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX4(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX4(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX4(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX4(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX4(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX4(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX4(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX4_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX4_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX4_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX4_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX4_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX4_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX4_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX4_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX4_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX4_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX4Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX4Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX4Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX4Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX4Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX4Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX4Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX4Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX4Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX4Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX4Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX4Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX4Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX4Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX4Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX4Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX4Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX4Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX4Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX4Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX4Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
            get {
                return Statics.YShuffleX4Kernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX4Kernel(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX4Kernel(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX4Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX4Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX4Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX4Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX4Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX4Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX4Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX4Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleX4Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleX4Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleX4Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleX4Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleX4Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleX4Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleX4Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleX4Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleX4Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleX4Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleX4Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IVectorTraits.YSign_AcceleratedTypes"/>
        public override TypeCodeFlags YSign_AcceleratedTypes {
            get {
                return Statics.YSign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YSign(Vector<float> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YSign(Vector<double> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YSign(Vector<sbyte> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YSign(Vector<short> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YSign(Vector<int> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YSign(Vector<long> value) {
            return Statics.YSign(value);
        }


        /// <inheritdoc cref="IVectorTraits.YSignFloat_AcceleratedTypes"/>
        public override TypeCodeFlags YSignFloat_AcceleratedTypes {
            get {
                return Statics.YSignFloat_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YSignFloat(Vector<float> value) {
            return Statics.YSignFloat(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YSignFloat(Vector<double> value) {
            return Statics.YSignFloat(value);
        }

#endif // NET8_0_OR_GREATER
    }
}
