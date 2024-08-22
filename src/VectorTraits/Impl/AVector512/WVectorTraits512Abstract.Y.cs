using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Impl.AVector512 {
    using Statics = WVectorTraits512Base.Statics;

    partial class WVectorTraits512Abstract {
#if NET8_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits512.YBitToByte_IsAccelerated"/>
        public virtual bool YBitToByte_IsAccelerated {
            get {
                return Statics.YBitToByte_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YBitToByte"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YBitToByte(ulong value) {
            return Statics.YBitToByte(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YBitToInt16_IsAccelerated"/>
        public virtual bool YBitToInt16_IsAccelerated {
            get {
                return Statics.YBitToInt16_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YBitToInt16"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YBitToInt16(ulong value) {
            return Statics.YBitToInt16(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YBitToInt32_IsAccelerated"/>
        public virtual bool YBitToInt32_IsAccelerated {
            get {
                return Statics.YBitToInt32_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YBitToInt32"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YBitToInt32(ulong value) {
            return Statics.YBitToInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YBitToInt64_IsAccelerated"/>
        public virtual bool YBitToInt64_IsAccelerated {
            get {
                return Statics.YBitToInt64_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YBitToInt64"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YBitToInt64(ulong value) {
            return Statics.YBitToInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YClamp_AcceleratedTypes"/>
        public virtual TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YClamp(Vector512<float> value, Vector512<float> amin, Vector512<float> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{double}, Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YClamp(Vector512<double> value, Vector512<double> amin, Vector512<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YClamp(Vector512<sbyte> value, Vector512<sbyte> amin, Vector512<sbyte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YClamp(Vector512<byte> value, Vector512<byte> amin, Vector512<byte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YClamp(Vector512<short> value, Vector512<short> amin, Vector512<short> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YClamp(Vector512<ushort> value, Vector512<ushort> amin, Vector512<ushort> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YClamp(Vector512<int> value, Vector512<int> amin, Vector512<int> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YClamp(Vector512<uint> value, Vector512<uint> amin, Vector512<uint> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YClamp(Vector512<long> value, Vector512<long> amin, Vector512<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YClamp(Vector512<ulong> value, Vector512<ulong> amin, Vector512<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IWVectorTraits512.YCopySign_AcceleratedTypes"/>
        public virtual TypeCodeFlags YCopySign_AcceleratedTypes {
            get {
                return Statics.YCopySign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YCopySign(Vector512<float> value, Vector512<float> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YCopySign(Vector512<double> value, Vector512<double> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YCopySign(Vector512<sbyte> value, Vector512<sbyte> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YCopySign(Vector512<short> value, Vector512<short> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YCopySign(Vector512<int> value, Vector512<int> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YCopySign(Vector512<long> value, Vector512<long> sign) {
            return Statics.YCopySign(value, sign);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
            get {
                return Statics.YGroup2Unzip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup2Unzip(Vector512<float> data0, Vector512<float> data1, out Vector512<float> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup2Unzip(Vector512<double> data0, Vector512<double> data1, out Vector512<double> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup2Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, out Vector512<sbyte> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup2Unzip(Vector512<byte> data0, Vector512<byte> data1, out Vector512<byte> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup2Unzip(Vector512<short> data0, Vector512<short> data1, out Vector512<short> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup2Unzip(Vector512<ushort> data0, Vector512<ushort> data1, out Vector512<ushort> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup2Unzip(Vector512<int> data0, Vector512<int> data1, out Vector512<int> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup2Unzip(Vector512<uint> data0, Vector512<uint> data1, out Vector512<uint> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup2Unzip(Vector512<long> data0, Vector512<long> data1, out Vector512<long> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup2Unzip(Vector512<ulong> data0, Vector512<ulong> data1, out Vector512<ulong> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExInt128> YGroup2Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, out Vector512<ExInt128> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExUInt128> YGroup2Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, out Vector512<ExUInt128> y) {
            return Statics.YGroup2Unzip(data0, data1, out y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup2Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, out Vector512<T> y) where T : struct {
            return Statics.YGroup2Unzip_Bit128(data0, data1, out y);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
            get {
                return Statics.YGroup2UnzipEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup2UnzipEven(Vector512<float> data0, Vector512<float> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup2UnzipEven(Vector512<double> data0, Vector512<double> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup2UnzipEven(Vector512<sbyte> data0, Vector512<sbyte> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup2UnzipEven(Vector512<byte> data0, Vector512<byte> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup2UnzipEven(Vector512<short> data0, Vector512<short> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup2UnzipEven(Vector512<ushort> data0, Vector512<ushort> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup2UnzipEven(Vector512<int> data0, Vector512<int> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup2UnzipEven(Vector512<uint> data0, Vector512<uint> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup2UnzipEven(Vector512<long> data0, Vector512<long> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup2UnzipEven(Vector512<ulong> data0, Vector512<ulong> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExInt128> YGroup2UnzipEven(Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExUInt128> YGroup2UnzipEven(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
            return Statics.YGroup2UnzipEven(data0, data1);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
            get {
                return Statics.YGroup2UnzipOdd_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup2UnzipOdd(Vector512<float> data0, Vector512<float> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup2UnzipOdd(Vector512<double> data0, Vector512<double> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup2UnzipOdd(Vector512<sbyte> data0, Vector512<sbyte> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup2UnzipOdd(Vector512<byte> data0, Vector512<byte> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup2UnzipOdd(Vector512<short> data0, Vector512<short> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup2UnzipOdd(Vector512<ushort> data0, Vector512<ushort> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup2UnzipOdd(Vector512<int> data0, Vector512<int> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup2UnzipOdd(Vector512<uint> data0, Vector512<uint> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup2UnzipOdd(Vector512<long> data0, Vector512<long> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup2UnzipOdd(Vector512<ulong> data0, Vector512<ulong> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExInt128> YGroup2UnzipOdd(Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExUInt128> YGroup2UnzipOdd(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
            return Statics.YGroup2UnzipOdd(data0, data1);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup2Zip_AcceleratedTypes {
            get {
                return Statics.YGroup2Zip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup2Zip(Vector512<float> x, Vector512<float> y, out Vector512<float> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup2Zip(Vector512<double> x, Vector512<double> y, out Vector512<double> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup2Zip(Vector512<sbyte> x, Vector512<sbyte> y, out Vector512<sbyte> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup2Zip(Vector512<byte> x, Vector512<byte> y, out Vector512<byte> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup2Zip(Vector512<short> x, Vector512<short> y, out Vector512<short> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup2Zip(Vector512<ushort> x, Vector512<ushort> y, out Vector512<ushort> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup2Zip(Vector512<int> x, Vector512<int> y, out Vector512<int> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup2Zip(Vector512<uint> x, Vector512<uint> y, out Vector512<uint> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup2Zip(Vector512<long> x, Vector512<long> y, out Vector512<long> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup2Zip(Vector512<ulong> x, Vector512<ulong> y, out Vector512<ulong> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExInt128> YGroup2Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, out Vector512<ExInt128> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExUInt128> YGroup2Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, out Vector512<ExUInt128> data1) {
            return Statics.YGroup2Zip(x, y, out data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup2Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, out Vector512<T> data1) where T : struct {
            return Statics.YGroup2Zip_Bit128(x, y, out data1);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
            get {
                return Statics.YGroup2ZipHigh_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup2ZipHigh(Vector512<float> x, Vector512<float> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup2ZipHigh(Vector512<double> x, Vector512<double> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup2ZipHigh(Vector512<sbyte> x, Vector512<sbyte> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup2ZipHigh(Vector512<byte> x, Vector512<byte> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup2ZipHigh(Vector512<short> x, Vector512<short> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup2ZipHigh(Vector512<ushort> x, Vector512<ushort> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup2ZipHigh(Vector512<int> x, Vector512<int> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup2ZipHigh(Vector512<uint> x, Vector512<uint> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup2ZipHigh(Vector512<long> x, Vector512<long> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup2ZipHigh(Vector512<ulong> x, Vector512<ulong> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExInt128> YGroup2ZipHigh(Vector512<ExInt128> x, Vector512<ExInt128> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExUInt128> YGroup2ZipHigh(Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
            return Statics.YGroup2ZipHigh(x, y);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
            get {
                return Statics.YGroup2ZipLow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup2ZipLow(Vector512<float> x, Vector512<float> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup2ZipLow(Vector512<double> x, Vector512<double> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup2ZipLow(Vector512<sbyte> x, Vector512<sbyte> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup2ZipLow(Vector512<byte> x, Vector512<byte> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup2ZipLow(Vector512<short> x, Vector512<short> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup2ZipLow(Vector512<ushort> x, Vector512<ushort> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup2ZipLow(Vector512<int> x, Vector512<int> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup2ZipLow(Vector512<uint> x, Vector512<uint> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup2ZipLow(Vector512<long> x, Vector512<long> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup2ZipLow(Vector512<ulong> x, Vector512<ulong> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExInt128> YGroup2ZipLow(Vector512<ExInt128> x, Vector512<ExInt128> y) {
            return Statics.YGroup2ZipLow(x, y);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExUInt128> YGroup2ZipLow(Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
            return Statics.YGroup2ZipLow(x, y);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
            get {
                return Statics.YGroup3Unzip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup3Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, out Vector512<float> y, out Vector512<float> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup3Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, out Vector512<double> y, out Vector512<double> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup3Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> y, out Vector512<sbyte> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup3Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> y, out Vector512<byte> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup3Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> y, out Vector512<short> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup3Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> y, out Vector512<ushort> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup3Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> y, out Vector512<int> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup3Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> y, out Vector512<uint> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup3Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, out Vector512<long> y, out Vector512<long> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup3Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, out Vector512<ulong> y, out Vector512<ulong> z) {
            return Statics.YGroup3Unzip(data0, data1, data2, out y, out z);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup3Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, out Vector512<T> y, out Vector512<T> z) where T : struct {
            return Statics.YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
            get {
                return Statics.YGroup3UnzipX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup3UnzipX2(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, Vector512<float> data4, Vector512<float> data5, out Vector512<float> xB, out Vector512<float> y, out Vector512<float> yB, out Vector512<float> z, out Vector512<float> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup3UnzipX2(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, Vector512<double> data4, Vector512<double> data5, out Vector512<double> xB, out Vector512<double> y, out Vector512<double> yB, out Vector512<double> z, out Vector512<double> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup3UnzipX2(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, Vector512<sbyte> data4, Vector512<sbyte> data5, out Vector512<sbyte> xB, out Vector512<sbyte> y, out Vector512<sbyte> yB, out Vector512<sbyte> z, out Vector512<sbyte> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup3UnzipX2(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, Vector512<byte> data4, Vector512<byte> data5, out Vector512<byte> xB, out Vector512<byte> y, out Vector512<byte> yB, out Vector512<byte> z, out Vector512<byte> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup3UnzipX2(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, Vector512<short> data4, Vector512<short> data5, out Vector512<short> xB, out Vector512<short> y, out Vector512<short> yB, out Vector512<short> z, out Vector512<short> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup3UnzipX2(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, Vector512<ushort> data4, Vector512<ushort> data5, out Vector512<ushort> xB, out Vector512<ushort> y, out Vector512<ushort> yB, out Vector512<ushort> z, out Vector512<ushort> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup3UnzipX2(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, Vector512<int> data4, Vector512<int> data5, out Vector512<int> xB, out Vector512<int> y, out Vector512<int> yB, out Vector512<int> z, out Vector512<int> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup3UnzipX2(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, Vector512<uint> data4, Vector512<uint> data5, out Vector512<uint> xB, out Vector512<uint> y, out Vector512<uint> yB, out Vector512<uint> z, out Vector512<uint> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup3UnzipX2(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, Vector512<long> data4, Vector512<long> data5, out Vector512<long> xB, out Vector512<long> y, out Vector512<long> yB, out Vector512<long> z, out Vector512<long> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup3UnzipX2(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, Vector512<ulong> data4, Vector512<ulong> data5, out Vector512<ulong> xB, out Vector512<ulong> y, out Vector512<ulong> yB, out Vector512<ulong> z, out Vector512<ulong> zB) {
            return Statics.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup3UnzipX2_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, Vector512<T> data4, Vector512<T> data5, out Vector512<T> xB, out Vector512<T> y, out Vector512<T> yB, out Vector512<T> z, out Vector512<T> zB) where T : struct {
            return Statics.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup3Zip_AcceleratedTypes {
            get {
                return Statics.YGroup3Zip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup3Zip(Vector512<float> x, Vector512<float> y, Vector512<float> z, out Vector512<float> data1, out Vector512<float> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup3Zip(Vector512<double> x, Vector512<double> y, Vector512<double> z, out Vector512<double> data1, out Vector512<double> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup3Zip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, out Vector512<sbyte> data1, out Vector512<sbyte> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup3Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, out Vector512<byte> data1, out Vector512<byte> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup3Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z, out Vector512<short> data1, out Vector512<short> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup3Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, out Vector512<ushort> data1, out Vector512<ushort> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup3Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z, out Vector512<int> data1, out Vector512<int> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup3Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, out Vector512<uint> data1, out Vector512<uint> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup3Zip(Vector512<long> x, Vector512<long> y, Vector512<long> z, out Vector512<long> data1, out Vector512<long> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup3Zip(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, out Vector512<ulong> data1, out Vector512<ulong> data2) {
            return Statics.YGroup3Zip(x, y, z, out data1, out data2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup3Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, out Vector512<T> data1, out Vector512<T> data2) where T : struct {
            return Statics.YGroup3Zip_Bit128(x, y, z, out data1, out data2);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup3ZipX2_AcceleratedTypes {
            get {
                return Statics.YGroup3ZipX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup3ZipX2(Vector512<float> x, Vector512<float> xB, Vector512<float> y, Vector512<float> yB, Vector512<float> z, Vector512<float> zB, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3, out Vector512<float> data4, out Vector512<float> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup3ZipX2(Vector512<double> x, Vector512<double> xB, Vector512<double> y, Vector512<double> yB, Vector512<double> z, Vector512<double> zB, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3, out Vector512<double> data4, out Vector512<double> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup3ZipX2(Vector512<sbyte> x, Vector512<sbyte> xB, Vector512<sbyte> y, Vector512<sbyte> yB, Vector512<sbyte> z, Vector512<sbyte> zB, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3, out Vector512<sbyte> data4, out Vector512<sbyte> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup3ZipX2(Vector512<byte> x, Vector512<byte> xB, Vector512<byte> y, Vector512<byte> yB, Vector512<byte> z, Vector512<byte> zB, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3, out Vector512<byte> data4, out Vector512<byte> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup3ZipX2(Vector512<short> x, Vector512<short> xB, Vector512<short> y, Vector512<short> yB, Vector512<short> z, Vector512<short> zB, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3, out Vector512<short> data4, out Vector512<short> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup3ZipX2(Vector512<ushort> x, Vector512<ushort> xB, Vector512<ushort> y, Vector512<ushort> yB, Vector512<ushort> z, Vector512<ushort> zB, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3, out Vector512<ushort> data4, out Vector512<ushort> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup3ZipX2(Vector512<int> x, Vector512<int> xB, Vector512<int> y, Vector512<int> yB, Vector512<int> z, Vector512<int> zB, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3, out Vector512<int> data4, out Vector512<int> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup3ZipX2(Vector512<uint> x, Vector512<uint> xB, Vector512<uint> y, Vector512<uint> yB, Vector512<uint> z, Vector512<uint> zB, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3, out Vector512<uint> data4, out Vector512<uint> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup3ZipX2(Vector512<long> x, Vector512<long> xB, Vector512<long> y, Vector512<long> yB, Vector512<long> z, Vector512<long> zB, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3, out Vector512<long> data4, out Vector512<long> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup3ZipX2(Vector512<ulong> x, Vector512<ulong> xB, Vector512<ulong> y, Vector512<ulong> yB, Vector512<ulong> z, Vector512<ulong> zB, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3, out Vector512<ulong> data4, out Vector512<ulong> data5) {
            return Statics.YGroup3ZipX2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup3ZipX2_Bit128<T>(Vector512<T> x, Vector512<T> xB, Vector512<T> y, Vector512<T> yB, Vector512<T> z, Vector512<T> zB, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3, out Vector512<T> data4, out Vector512<T> data5) where T : struct {
            return Statics.YGroup3ZipX2_Bit128(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
            get {
                return Statics.YGroup4Unzip_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup4Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, out Vector512<float> y, out Vector512<float> z, out Vector512<float> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup4Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, out Vector512<double> y, out Vector512<double> z, out Vector512<double> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup4Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> y, out Vector512<sbyte> z, out Vector512<sbyte> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup4Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup4Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup4Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup4Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> y, out Vector512<int> z, out Vector512<int> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup4Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> y, out Vector512<uint> z, out Vector512<uint> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup4Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> y, out Vector512<long> z, out Vector512<long> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup4Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> y, out Vector512<ulong> z, out Vector512<ulong> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExInt128> YGroup4Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, Vector512<ExInt128> data2, Vector512<ExInt128> data3, out Vector512<ExInt128> y, out Vector512<ExInt128> z, out Vector512<ExInt128> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExUInt128> YGroup4Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, Vector512<ExUInt128> data2, Vector512<ExUInt128> data3, out Vector512<ExUInt128> y, out Vector512<ExUInt128> z, out Vector512<ExUInt128> w) {
            return Statics.YGroup4Unzip(data0, data1, data2, data3, out y, out z, out w);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup4Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, out Vector512<T> y, out Vector512<T> z, out Vector512<T> w) where T : struct {
            return Statics.YGroup4Unzip_Bit128(data0, data1, data2, data3, out y, out z, out w);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip_AcceleratedTypes"/>
        public virtual TypeCodeFlags YGroup4Zip_AcceleratedTypes {
            get {
                return Statics.YGroup4Zip_AcceleratedTypes;
            }
        }
        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YGroup4Zip(Vector512<float> x, Vector512<float> y, Vector512<float> z, Vector512<float> w, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YGroup4Zip(Vector512<double> x, Vector512<double> y, Vector512<double> z, Vector512<double> w, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YGroup4Zip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YGroup4Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YGroup4Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YGroup4Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YGroup4Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YGroup4Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YGroup4Zip(Vector512<long> x, Vector512<long> y, Vector512<long> z, Vector512<long> w, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YGroup4Zip(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, Vector512<ulong> w, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExInt128> YGroup4Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, Vector512<ExInt128> z, Vector512<ExInt128> w, out Vector512<ExInt128> data1, out Vector512<ExInt128> data2, out Vector512<ExInt128> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ExUInt128> YGroup4Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, Vector512<ExUInt128> z, Vector512<ExUInt128> w, out Vector512<ExUInt128> data1, out Vector512<ExUInt128> data2, out Vector512<ExUInt128> data3) {
            return Statics.YGroup4Zip(x, y, z, w, out data1, out data2, out data3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup4Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3) where T : struct {
            return Statics.YGroup4Zip_Bit128(x, y, z, w, out data1, out data2, out data3);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup6Unzip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup6Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, Vector512<T> data4, Vector512<T> data5, out Vector512<T> y, out Vector512<T> z, out Vector512<T> w, out Vector512<T> u, out Vector512<T> v) where T : struct {
            return Statics.YGroup6Unzip_Bit128(data0, data1, data2, data3, data4, data5, out y, out z, out w, out u, out v);
        }


        /// <inheritdoc cref="IWVectorTraits512.YGroup6Zip_Bit128"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YGroup6Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w, Vector512<T> u, Vector512<T> v, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3, out Vector512<T> data4, out Vector512<T> data5) where T : struct {
            return Statics.YGroup6Zip_Bit128(x, y, z, w, u, v, out data1, out data2, out data3, out data4, out data5);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsAllTrue_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsAllTrue_AcceleratedTypes {
            get {
                return Statics.YIsAllTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsAllTrue{T}(Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual bool YIsAllTrue<T>(Vector512<T> value) where T : struct {
            return Statics.YIsAllTrue(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsAnyTrue_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
            get {
                return Statics.YIsAnyTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsAnyTrue{T}(Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual bool YIsAnyTrue<T>(Vector512<T> value) where T : struct {
            return Statics.YIsAnyTrue(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
            get {
                return Statics.YIsEvenInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsEvenInteger(Vector512<float> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsEvenInteger(Vector512<double> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YIsEvenInteger(Vector512<sbyte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YIsEvenInteger(Vector512<byte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YIsEvenInteger(Vector512<short> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YIsEvenInteger(Vector512<ushort> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsEvenInteger(Vector512<int> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YIsEvenInteger(Vector512<uint> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsEvenInteger(Vector512<long> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YIsEvenInteger(Vector512<ulong> value) {
            return Statics.YIsEvenInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsFinite_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsFinite_AcceleratedTypes {
            get {
                return Statics.YIsFinite_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsFinite(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsFinite(Vector512<float> value) {
            return Statics.YIsFinite(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsFinite(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsFinite(Vector512<double> value) {
            return Statics.YIsFinite(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsInfinity_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsInfinity_AcceleratedTypes {
            get {
                return Statics.YIsInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInfinity(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsInfinity(Vector512<float> value) {
            return Statics.YIsInfinity(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInfinity(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsInfinity(Vector512<double> value) {
            return Statics.YIsInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsInfinityOrNaN_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
            get {
                return Statics.YIsInfinityOrNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInfinityOrNaN(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsInfinityOrNaN(Vector512<float> value) {
            return Statics.YIsInfinityOrNaN(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInfinityOrNaN(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsInfinityOrNaN(Vector512<double> value) {
            return Statics.YIsInfinityOrNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsInteger_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsInteger_AcceleratedTypes {
            get {
                return Statics.YIsInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInteger(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsInteger(Vector512<float> value) {
            return Statics.YIsInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsInteger(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsInteger(Vector512<double> value) {
            return Statics.YIsInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNaN_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNaN_AcceleratedTypes {
            get {
                return Statics.YIsNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNaN(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsNaN(Vector512<float> value) {
            return Statics.YIsNaN(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNaN(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsNaN(Vector512<double> value) {
            return Statics.YIsNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNegative_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNegative_AcceleratedTypes {
            get {
                return Statics.YIsNegative_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsNegative(Vector512<float> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsNegative(Vector512<double> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YIsNegative(Vector512<sbyte> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YIsNegative(Vector512<short> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsNegative(Vector512<int> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsNegative(Vector512<long> value) {
            return Statics.YIsNegative(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeInfinity_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
            get {
                return Statics.YIsNegativeInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeInfinity(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsNegativeInfinity(Vector512<float> value) {
            return Statics.YIsNegativeInfinity(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeInfinity(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsNegativeInfinity(Vector512<double> value) {
            return Statics.YIsNegativeInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeZero_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
            get {
                return Statics.YIsNegativeZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeZero(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsNegativeZero(Vector512<float> value) {
            return Statics.YIsNegativeZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNegativeZero(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsNegativeZero(Vector512<double> value) {
            return Statics.YIsNegativeZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNormal_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNormal_AcceleratedTypes {
            get {
                return Statics.YIsNormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNormal(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsNormal(Vector512<float> value) {
            return Statics.YIsNormal(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNormal(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsNormal(Vector512<double> value) {
            return Statics.YIsNormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNotEquals_AcceleratedTypes {
            get {
                return Statics.YIsNotEquals_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YIsNotEquals(Vector512<float> left, Vector512<float> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YIsNotEquals(Vector512<double> left, Vector512<double> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YIsNotEquals(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YIsNotEquals(Vector512<byte> left, Vector512<byte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YIsNotEquals(Vector512<short> left, Vector512<short> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YIsNotEquals(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsNotEquals(Vector512<int> left, Vector512<int> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YIsNotEquals(Vector512<uint> left, Vector512<uint> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsNotEquals(Vector512<long> left, Vector512<long> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YIsNotEquals(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.YIsNotEquals(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsNotNaN_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNotNaN_AcceleratedTypes {
            get {
                return Statics.YIsNotNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotNaN(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsNotNaN(Vector512<float> value) {
            return Statics.YIsNotNaN(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsNotNaN(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsNotNaN(Vector512<double> value) {
            return Statics.YIsNotNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsOddInteger_AcceleratedTypes
        {
            get
            {
                return Statics.YIsOddInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsOddInteger(Vector512<float> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsOddInteger(Vector512<double> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YIsOddInteger(Vector512<sbyte> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YIsOddInteger(Vector512<byte> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YIsOddInteger(Vector512<short> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YIsOddInteger(Vector512<ushort> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsOddInteger(Vector512<int> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YIsOddInteger(Vector512<uint> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsOddInteger(Vector512<long> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YIsOddInteger(Vector512<ulong> value)
        {
            return Statics.YIsOddInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsPositive_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsPositive_AcceleratedTypes {
            get {
                return Statics.YIsPositive_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsPositive(Vector512<float> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsPositive(Vector512<double> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YIsPositive(Vector512<sbyte> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YIsPositive(Vector512<short> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsPositive(Vector512<int> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsPositive(Vector512<long> value) {
            return Statics.YIsPositive(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsPositiveInfinity_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
            get {
                return Statics.YIsPositiveInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositiveInfinity(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsPositiveInfinity(Vector512<float> value) {
            return Statics.YIsPositiveInfinity(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsPositiveInfinity(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsPositiveInfinity(Vector512<double> value) {
            return Statics.YIsPositiveInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsSubnormal_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsSubnormal(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsSubnormal(Vector512<float> value) {
            return Statics.YIsSubnormal(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsSubnormal(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsSubnormal(Vector512<double> value) {
            return Statics.YIsSubnormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsZero_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsZero_AcceleratedTypes {
            get {
                return Statics.YIsZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsZero(Vector512<float> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsZero(Vector512<double> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YIsZero(Vector512<sbyte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YIsZero(Vector512<byte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YIsZero(Vector512<short> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YIsZero(Vector512<ushort> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsZero(Vector512<int> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YIsZero(Vector512<uint> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsZero(Vector512<long> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YIsZero(Vector512<ulong> value) {
            return Statics.YIsZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YIsZeroOrSubnormal_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsZeroOrSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZeroOrSubnormal(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YIsZeroOrSubnormal(Vector512<float> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YIsZeroOrSubnormal(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YIsZeroOrSubnormal(Vector512<double> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YMaxNumber_AcceleratedTypes"/>
        public virtual TypeCodeFlags YMaxNumber_AcceleratedTypes {
            get {
                return Statics.YMaxNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YMaxNumber(Vector512<float> left, Vector512<float> right) {
            return Statics.YMaxNumber(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YMaxNumber(Vector512<double> left, Vector512<double> right) {
            return Statics.YMaxNumber(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.YMinNumber_AcceleratedTypes"/>
        public virtual TypeCodeFlags YMinNumber_AcceleratedTypes {
            get {
                return Statics.YMinNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YMinNumber(Vector512<float> left, Vector512<float> right) {
            return Statics.YMinNumber(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YMinNumber(Vector512<double> left, Vector512<double> right) {
            return Statics.YMinNumber(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate_AcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{short}, Vector512{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YNarrowSaturate(Vector512<short> lower, Vector512<short> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ushort}, Vector512{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YNarrowSaturate(Vector512<ushort> lower, Vector512<ushort> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{int}, Vector512{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YNarrowSaturate(Vector512<int> lower, Vector512<int> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{uint}, Vector512{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YNarrowSaturate(Vector512<uint> lower, Vector512<uint> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{long}, Vector512{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YNarrowSaturate(Vector512<long> lower, Vector512<long> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ulong}, Vector512{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YNarrowSaturate(Vector512<ulong> lower, Vector512<ulong> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{short}, Vector512{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YNarrowSaturateUnsigned(Vector512<short> lower, Vector512<short> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{int}, Vector512{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YNarrowSaturateUnsigned(Vector512<int> lower, Vector512<int> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{long}, Vector512{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YNarrowSaturateUnsigned(Vector512<long> lower, Vector512<long> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits512.YOrNot_AcceleratedTypes"/>
        public virtual TypeCodeFlags YOrNot_AcceleratedTypes {
            get {
                return Statics.YOrNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YOrNot{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<T> YOrNot<T>(Vector512<T> left, Vector512<T> right) where T : struct {
            return Statics.YOrNot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.YRoundToEven_AcceleratedTypes"/>
        public virtual TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
                return Statics.YRoundToEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YRoundToEven(Vector512<float> value) {
            return Statics.YRoundToEven(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YRoundToEven(Vector512<double> value) {
            return Statics.YRoundToEven(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YRoundToZero_AcceleratedTypes"/>
        public virtual TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
                return Statics.YRoundToZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YRoundToZero(Vector512<float> value) {
            return Statics.YRoundToZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YRoundToZero(Vector512<double> value) {
            return Statics.YRoundToZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
                return Statics.YShuffleG2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleG2(Vector512<float> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleG2(Vector512<double> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleG2(Vector512<sbyte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleG2(Vector512<byte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleG2(Vector512<short> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleG2(Vector512<ushort> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleG2(Vector512<int> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleG2(Vector512<uint> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleG2(Vector512<long> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleG2(Vector512<ulong> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleG2_Const(Vector512<float> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleG2_Const(Vector512<double> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleG2_Const(Vector512<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleG2_Const(Vector512<byte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleG2_Const(Vector512<short> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleG2_Const(Vector512<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleG2_Const(Vector512<int> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleG2_Const(Vector512<uint> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleG2_Const(Vector512<long> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleG2_Const(Vector512<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
                return Statics.YShuffleG4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleG4(Vector512<float> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleG4(Vector512<double> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleG4(Vector512<sbyte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleG4(Vector512<byte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleG4(Vector512<short> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleG4(Vector512<ushort> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleG4(Vector512<int> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleG4(Vector512<uint> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleG4(Vector512<long> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleG4(Vector512<ulong> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleG4_Const(Vector512<float> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleG4_Const(Vector512<double> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleG4_Const(Vector512<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleG4_Const(Vector512<byte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleG4_Const(Vector512<short> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleG4_Const(Vector512<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleG4_Const(Vector512<int> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleG4_Const(Vector512<uint> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleG4_Const(Vector512<long> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleG4_Const(Vector512<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
                return Statics.YShuffleG4X2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{float}, Vector512{float}, ShuffleControlG4, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleG4X2(Vector512<float> source0, Vector512<float> source1, ShuffleControlG4 control, out Vector512<float> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{double}, Vector512{double}, ShuffleControlG4, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleG4X2(Vector512<double> source0, Vector512<double> source1, ShuffleControlG4 control, out Vector512<double> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleG4X2(Vector512<sbyte> source0, Vector512<sbyte> source1, ShuffleControlG4 control, out Vector512<sbyte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{byte}, Vector512{byte}, ShuffleControlG4, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleG4X2(Vector512<byte> source0, Vector512<byte> source1, ShuffleControlG4 control, out Vector512<byte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{short}, Vector512{short}, ShuffleControlG4, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleG4X2(Vector512<short> source0, Vector512<short> source1, ShuffleControlG4 control, out Vector512<short> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleG4X2(Vector512<ushort> source0, Vector512<ushort> source1, ShuffleControlG4 control, out Vector512<ushort> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{int}, Vector512{int}, ShuffleControlG4, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleG4X2(Vector512<int> source0, Vector512<int> source1, ShuffleControlG4 control, out Vector512<int> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{uint}, Vector512{uint}, ShuffleControlG4, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleG4X2(Vector512<uint> source0, Vector512<uint> source1, ShuffleControlG4 control, out Vector512<uint> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{long}, Vector512{long}, ShuffleControlG4, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleG4X2(Vector512<long> source0, Vector512<long> source1, ShuffleControlG4 control, out Vector512<long> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleG4X2(Vector512<ulong> source0, Vector512<ulong> source1, ShuffleControlG4 control, out Vector512<ulong> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{float}, Vector512{float}, ShuffleControlG4, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleG4X2_Const(Vector512<float> source0, Vector512<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<float> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{double}, Vector512{double}, ShuffleControlG4, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleG4X2_Const(Vector512<double> source0, Vector512<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<double> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleG4X2_Const(Vector512<sbyte> source0, Vector512<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<sbyte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{byte}, Vector512{byte}, ShuffleControlG4, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleG4X2_Const(Vector512<byte> source0, Vector512<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<byte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{short}, Vector512{short}, ShuffleControlG4, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleG4X2_Const(Vector512<short> source0, Vector512<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<short> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleG4X2_Const(Vector512<ushort> source0, Vector512<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ushort> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{int}, Vector512{int}, ShuffleControlG4, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleG4X2_Const(Vector512<int> source0, Vector512<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<int> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{uint}, Vector512{uint}, ShuffleControlG4, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleG4X2_Const(Vector512<uint> source0, Vector512<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<uint> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{long}, Vector512{long}, ShuffleControlG4, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleG4X2_Const(Vector512<long> source0, Vector512<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<long> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleG4X2_Const(Vector512<ulong> source0, Vector512<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ulong> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleInsert(Vector512<float> back, Vector512<float> vector, Vector512<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleInsert(Vector512<double> back, Vector512<double> vector, Vector512<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleInsert(Vector512<sbyte> back, Vector512<sbyte> vector, Vector512<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleInsert(Vector512<byte> back, Vector512<byte> vector, Vector512<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleInsert(Vector512<short> back, Vector512<short> vector, Vector512<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleInsert(Vector512<ushort> back, Vector512<ushort> vector, Vector512<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleInsert(Vector512<int> back, Vector512<int> vector, Vector512<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleInsert(Vector512<uint> back, Vector512<uint> vector, Vector512<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleInsert(Vector512<long> back, Vector512<long> vector, Vector512<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleInsert(Vector512<ulong> back, Vector512<ulong> vector, Vector512<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleInsert_Core(Vector512<float> back, Vector512<float> vector, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleInsert_Core(Vector512<double> back, Vector512<double> vector, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleInsert_Core(Vector512<sbyte> back, Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleInsert_Core(Vector512<byte> back, Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleInsert_Core(Vector512<short> back, Vector512<short> vector, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleInsert_Core(Vector512<ushort> back, Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleInsert_Core(Vector512<int> back, Vector512<int> vector, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleInsert_Core(Vector512<uint> back, Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleInsert_Core(Vector512<long> back, Vector512<long> vector, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleInsert_Core(Vector512<ulong> back, Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleKernel(Vector512<float> vector, Vector512<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleKernel(Vector512<double> vector, Vector512<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleKernel(Vector512<sbyte> vector, Vector512<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleKernel(Vector512<byte> vector, Vector512<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleKernel(Vector512<short> vector, Vector512<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleKernel(Vector512<ushort> vector, Vector512<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleKernel(Vector512<int> vector, Vector512<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleKernel(Vector512<uint> vector, Vector512<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleKernel(Vector512<long> vector, Vector512<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleKernel(Vector512<ulong> vector, Vector512<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleKernel_Core(Vector512<float> vector, Vector512<int> args0, Vector512<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{double}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleKernel_Core(Vector512<double> vector, Vector512<long> args0, Vector512<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleKernel_Core(Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleKernel_Core(Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleKernel_Core(Vector512<short> vector, Vector512<short> args0, Vector512<short> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleKernel_Core(Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleKernel_Core(Vector512<int> vector, Vector512<int> args0, Vector512<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleKernel_Core(Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleKernel_Core(Vector512<long> vector, Vector512<long> args0, Vector512<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleKernel_Core(Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX2_AcceleratedTypes {
            get {
                return Statics.YShuffleX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX2(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX2(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX2(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX2(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX2(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX2(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX2(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX2(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX2(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX2(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX2_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX2_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX2_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX2_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX2_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX2_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX2_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX2_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX2_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX2_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX2Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX2Insert(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX2Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX2Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX2Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX2Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX2Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX2Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX2Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX2Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX2Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX2Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX2Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX2Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX2Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX2Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX2Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX2Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX2Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX2Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX2Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
            get {
                return Statics.YShuffleX2Kernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX2Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX2Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX2Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX2Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX2Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX2Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX2Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX2Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX2Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX2Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX2Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX2Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX2Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX2Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX2Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX2Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX2Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX2Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX2Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX2Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX3_AcceleratedTypes {
            get {
                return Statics.YShuffleX3_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX3(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX3(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX3(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX3(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX3(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX3(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX3(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX3(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX3(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX3(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
            return Statics.YShuffleX3(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
            Statics.YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX3_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX3_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX3_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX3_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX3_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX3_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX3_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX3_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX3_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX3_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
            return Statics.YShuffleX3_Core(vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX3Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX3Insert(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX3Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX3Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX3Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX3Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX3Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX3Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX3Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX3Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX3Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
            return Statics.YShuffleX3Insert(back, vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
            Statics.YShuffleX3Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX3Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX3Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX3Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX3Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX3Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX3Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX3Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX3Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX3Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX3Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
            return Statics.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
            get {
                return Statics.YShuffleX3Kernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX3Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX3Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX3Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX3Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX3Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX3Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX3Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX3Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX3Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX3Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
            return Statics.YShuffleX3Kernel(vector0, vector1, vector2, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX3Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
            Statics.YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX3Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX3Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX3Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX3Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX3Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX3Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX3Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX3Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX3Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX3Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
            return Statics.YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX4_AcceleratedTypes {
            get {
                return Statics.YShuffleX4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX4(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX4(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX4(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX4(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX4(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX4(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX4(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX4(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX4(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX4(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
            return Statics.YShuffleX4(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
            Statics.YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX4_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX4_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX4_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX4_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX4_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX4_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX4_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX4_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX4_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX4_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
            return Statics.YShuffleX4_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX4Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX4Insert(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX4Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX4Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX4Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX4Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX4Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX4Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX4Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX4Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX4Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
            return Statics.YShuffleX4Insert(back, vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
            Statics.YShuffleX4Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX4Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX4Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX4Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX4Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX4Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX4Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX4Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX4Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX4Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX4Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
            return Statics.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
            get {
                return Statics.YShuffleX4Kernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX4Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX4Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX4Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX4Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX4Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX4Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX4Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX4Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX4Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX4Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
            return Statics.YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX4Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
            Statics.YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YShuffleX4Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YShuffleX4Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YShuffleX4Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<byte> YShuffleX4Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YShuffleX4Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ushort> YShuffleX4Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YShuffleX4Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<uint> YShuffleX4Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YShuffleX4Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<ulong> YShuffleX4Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
            return Statics.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IWVectorTraits512.YSign_AcceleratedTypes"/>
        public virtual TypeCodeFlags YSign_AcceleratedTypes {
            get {
                return Statics.YSign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YSign(Vector512<float> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YSign(Vector512<double> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<sbyte> YSign(Vector512<sbyte> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<short> YSign(Vector512<short> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<int> YSign(Vector512<int> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<long> YSign(Vector512<long> value) {
            return Statics.YSign(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.YSignFloat_AcceleratedTypes"/>
        public virtual TypeCodeFlags YSignFloat_AcceleratedTypes {
            get {
                return Statics.YSignFloat_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<float> YSignFloat(Vector512<float> value) {
            return Statics.YSignFloat(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector512<double> YSignFloat(Vector512<double> value) {
            return Statics.YSignFloat(value);
        }

#endif
    }
}
