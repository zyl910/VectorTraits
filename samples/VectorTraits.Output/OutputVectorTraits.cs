using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using System.Threading.Tasks;

namespace Zyl.VectorTraits.Output {
    internal class OutputVectorTraits {
        /// <summary>Show full text.</summary>
        public static bool ShowFull { get; set; }

        /// <summary>
        /// WriteLine with format.
        /// </summary>
        /// <param name="writer">The TextWriter.</param>
        /// <param name="indent">The indent.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args</param>
        private static void WriteLine(TextWriter writer, string indent, string format, params object?[] args) {
            if (null == writer) return;
            TraitsUtil.WriteLine(indent, writer, format, args);
        }

        /// <summary>
        /// Run base info.
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        public static void RunBaseInfo(TextWriter writer, string indent) {
            // Vector create .
            writer.WriteLine(indent + "[Vector create]");
            double[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            byte[] arrByte = { byte.MinValue, byte.MaxValue, 0, 1 };
            //writer.WriteLine(Vectors.Create<Byte>(null)); // ArgumentNullException
            //writer.WriteLine(Vectors.Create(arrByte)); // IndexOutOfRangeException
            WriteLine(writer, indent, "Create by T[]:\t{0}", Vectors.Create(arr));
            var parr = new ReadOnlySpan<double>(arr);
            WriteLine(writer, indent, "Create by Span<T>:\t{0}", Vectors.Create(new Span<double>(arr)));
            WriteLine(writer, indent, "Create by ReadOnlySpan<T>:\t{0}", Vectors.Create(parr));
            if (true) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                var parr2 = MemoryMarshal.AsBytes(parr);
                WriteLine(writer, indent, "Create by ReadOnlySpan<byte>:\t{0}", Vectors.Create<double>(parr2));
#else
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
            WriteLine(writer, indent, "Vectors.CreatePadding(arrByte):\t{0}", Vectors.CreatePadding(arrByte));
            WriteLine(writer, indent, "Vectors.CreateRotate(arrByte):\t{0}", Vectors.CreateRotate(arrByte));
            writer.WriteLine();

            // Scalars<T> .
            writer.WriteLine(indent + "[Scalar samples]");
            RunInfoScalars<float>(writer, indent);
            RunInfoScalars<double>(writer, indent);
            RunInfoScalars<sbyte>(writer, indent);
            RunInfoScalars<byte>(writer, indent);
            RunInfoScalars<short>(writer, indent);
            RunInfoScalars<ushort>(writer, indent);
            RunInfoScalars<int>(writer, indent);
            RunInfoScalars<uint>(writer, indent);
            RunInfoScalars<long>(writer, indent);
            RunInfoScalars<ulong>(writer, indent);
            RunInfoScalars<IntPtr>(writer, indent);
            RunInfoScalars<UIntPtr>(writer, indent);
#if NET5_0_OR_GREATER
            RunInfoScalars<Half>(writer, indent);
#endif // NET5_0_OR_GREATER
            writer.WriteLine();

            // Vectors<T> .
            writer.WriteLine(indent + "[Vector samples]");
            RunInfoVectors<float>(writer, indent);
            RunInfoVectors<double>(writer, indent);
            RunInfoVectors<sbyte>(writer, indent);
            RunInfoVectors<byte>(writer, indent);
            RunInfoVectors<short>(writer, indent);
            RunInfoVectors<ushort>(writer, indent);
            RunInfoVectors<int>(writer, indent);
            RunInfoVectors<uint>(writer, indent);
            RunInfoVectors<long>(writer, indent);
            RunInfoVectors<ulong>(writer, indent);
#if NET6_0_OR_GREATER
            RunInfoVectors<nint>(writer, indent);
            RunInfoVectors<nuint>(writer, indent);
#endif // NET6_0_OR_GREATER
            unsafe {
                // When the return type is `T`, you cannot get a pointer. // CS0211	Cannot take the address of the given expression
                //fixed (void* p = &Vectors<ulong>.Zero) {
                //    WriteLine(writer, indent, "&Vectors<ulong>.Zero:\t0x{0:X}", (IntPtr)p);
                //}
                // When the return type is `ref readonly T`, you cannot get a pointer.
                fixed (void* p = &Vectors<ulong>.V0) {
                    WriteLine(writer, indent, "&Vectors<ulong>.V0:\t0x{0:X}", (IntPtr)p);
                }
            }
            writer.WriteLine();

            // Vector64s<T> .
            try {
                RunInfoVector64s<float>(writer, indent);
                RunInfoVector64s<double>(writer, indent);
                RunInfoVector64s<sbyte>(writer, indent);
                RunInfoVector64s<byte>(writer, indent);
                RunInfoVector64s<short>(writer, indent);
                RunInfoVector64s<ushort>(writer, indent);
                RunInfoVector64s<int>(writer, indent);
                RunInfoVector64s<uint>(writer, indent);
                RunInfoVector64s<long>(writer, indent);
                RunInfoVector64s<ulong>(writer, indent);
            } catch (Exception ex) {
                writer.WriteLine("RunInfoVector64s fail! " + ex.ToString());
            }
            writer.WriteLine();

            // Vector128s<T> .
            try {
                RunInfoVector128s<float>(writer, indent);
                RunInfoVector128s<double>(writer, indent);
                RunInfoVector128s<sbyte>(writer, indent);
                RunInfoVector128s<byte>(writer, indent);
                RunInfoVector128s<short>(writer, indent);
                RunInfoVector128s<ushort>(writer, indent);
                RunInfoVector128s<int>(writer, indent);
                RunInfoVector128s<uint>(writer, indent);
                RunInfoVector128s<long>(writer, indent);
                RunInfoVector128s<ulong>(writer, indent);
            } catch (Exception ex) {
                writer.WriteLine("RunInfoVector128s fail! " + ex.ToString());
            }
            writer.WriteLine();

            // Vector256s<T> .
            try {
                RunInfoVector256s<float>(writer, indent);
                RunInfoVector256s<double>(writer, indent);
                RunInfoVector256s<sbyte>(writer, indent);
                RunInfoVector256s<byte>(writer, indent);
                RunInfoVector256s<short>(writer, indent);
                RunInfoVector256s<ushort>(writer, indent);
                RunInfoVector256s<int>(writer, indent);
                RunInfoVector256s<uint>(writer, indent);
                RunInfoVector256s<long>(writer, indent);
                RunInfoVector256s<ulong>(writer, indent);
            } catch (Exception ex) {
                writer.WriteLine("RunInfoVector256s fail! " + ex.ToString());
            }
            writer.WriteLine();
        }

        /// <summary>
        /// Run base - <see cref="Scalars{T}"/>
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <typeparam name="T">The vector element type. T can be any primitive numeric type.</typeparam>
        public static void RunInfoScalars<T>(TextWriter writer, string indent) where T : struct {
            writer.WriteLine(indent + string.Format("-- Scalars<{0}> --", typeof(T).Name));
            if (ShowFull) {
                WriteLine(writer, indent, "V0:\t{0}", Scalars<T>.V0);
                WriteLine(writer, indent, "AllBitsSet:\t{0}", Scalars<T>.AllBitsSet);
            }
            WriteLine(writer, indent, "ByteSize:\t{0}", Scalars<T>.ByteSize);
            writer.WriteLine(indent + string.Format("SignBits-ExponentBits-MantissaBits:\t{0}-{1}-{2}", Scalars<T>.SignBits, Scalars<T>.ExponentBits, Scalars<T>.MantissaBits));
            if (ShowFull) {
                writer.WriteLine(indent + string.Format("SignShift-ExponentShift-MantissaShift:\t{0}-{1}-{2}", Scalars<T>.SignShift, Scalars<T>.ExponentShift, Scalars<T>.MantissaShift));
                WriteLine(writer, indent, "BitSizeMask:\t{0}", Scalars<T>.BitSizeMask);
                WriteLine(writer, indent, "ExponentBias:\t{0}", Scalars<T>.ExponentBias);
                WriteLine(writer, indent, "SignMask:\t{0}", Scalars<T>.SignMask);
                WriteLine(writer, indent, "ExponentMask:\t{0}", Scalars<T>.ExponentMask);
                WriteLine(writer, indent, "MantissaMask:\t{0}", Scalars<T>.MantissaMask);
                WriteLine(writer, indent, "NonSignMask:\t{0}", Scalars<T>.NonSignMask);
                WriteLine(writer, indent, "NonExponentMask:\t{0}", Scalars<T>.NonExponentMask);
                WriteLine(writer, indent, "NonMantissaMask:\t{0}", Scalars<T>.NonMantissaMask);
                WriteLine(writer, indent, "SignMask:\t{0}", Scalars<T>.SignMask);
                WriteLine(writer, indent, "ExponentMask:\t{0}", Scalars<T>.ExponentMask);
                WriteLine(writer, indent, "MantissaMask:\t{0}", Scalars<T>.MantissaMask);
                WriteLine(writer, indent, "NonSignMask:\t{0}", Scalars<T>.NonSignMask);
                WriteLine(writer, indent, "NonExponentMask:\t{0}", Scalars<T>.NonExponentMask);
                WriteLine(writer, indent, "NonMantissaMask:\t{0}", Scalars<T>.NonMantissaMask);
                WriteLine(writer, indent, "Epsilon:\t{0}", Scalars<T>.Epsilon);
                WriteLine(writer, indent, "MaxValue:\t{0}", Scalars<T>.MaxValue);
                WriteLine(writer, indent, "MinValue:\t{0}", Scalars<T>.MinValue);
                WriteLine(writer, indent, "NaN:\t{0}", Scalars<T>.NaN);
                WriteLine(writer, indent, "NegativeInfinity:\t{0}", Scalars<T>.NegativeInfinity);
                WriteLine(writer, indent, "PositiveInfinity:\t{0}", Scalars<T>.PositiveInfinity);
                WriteLine(writer, indent, "NormOne:\t{0}", Scalars<T>.NormOne);
                WriteLine(writer, indent, "FixedShift:\t{0}", Scalars<T>.FixedShift);
                WriteLine(writer, indent, "FixedOne:\t{0}", Scalars<T>.FixedOne);
                WriteLine(writer, indent, "FixedOneDouble:\t{0}", Scalars<T>.FixedOneDouble);
                WriteLine(writer, indent, "E:\t{0}", Scalars<T>.E);
                WriteLine(writer, indent, "Pi:\t{0}", Scalars<T>.Pi);
                WriteLine(writer, indent, "Tau:\t{0}", Scalars<T>.Tau);
                WriteLine(writer, indent, "V0:\t{0}", Scalars<T>.V0);
                WriteLine(writer, indent, "V1:\t{0}", Scalars<T>.V1);
                WriteLine(writer, indent, "VMaxSByte:\t{0}", Scalars<T>.VMaxSByte);
                WriteLine(writer, indent, "VMaxByte:\t{0}", Scalars<T>.VMaxByte);
                WriteLine(writer, indent, "VMaxInt16:\t{0}", Scalars<T>.VMaxInt16);
                WriteLine(writer, indent, "VMaxUInt16:\t{0}", Scalars<T>.VMaxUInt16);
                WriteLine(writer, indent, "VMaxInt32:\t{0}", Scalars<T>.VMaxInt32);
                WriteLine(writer, indent, "VMaxUInt32:\t{0}", Scalars<T>.VMaxUInt32);
                WriteLine(writer, indent, "V_1:\t{0}", Scalars<T>.V_1);
                WriteLine(writer, indent, "VMinSByte:\t{0}", Scalars<T>.VMinSByte);
                WriteLine(writer, indent, "VMinInt16:\t{0}", Scalars<T>.VMinInt16);
                WriteLine(writer, indent, "VMinInt32:\t{0}", Scalars<T>.VMinInt32);
                WriteLine(writer, indent, "VReciprocalMaxSByte:\t{0}", Scalars<T>.VReciprocalMaxSByte);
                WriteLine(writer, indent, "VReciprocalMaxByte:\t{0}", Scalars<T>.VReciprocalMaxByte);
                WriteLine(writer, indent, "VReciprocalMaxInt16:\t{0}", Scalars<T>.VReciprocalMaxInt16);
                WriteLine(writer, indent, "VReciprocalMaxUInt16:\t{0}", Scalars<T>.VReciprocalMaxUInt16);
                WriteLine(writer, indent, "VReciprocalMaxInt32:\t{0}", Scalars<T>.VReciprocalMaxInt32);
                WriteLine(writer, indent, "VReciprocalMaxUInt32:\t{0}", Scalars<T>.VReciprocalMaxUInt32);
            }
        }

        /// <summary>
        /// Run base - <see cref="Vectors{T}"/>
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <typeparam name="T">The vector element type. T can be any primitive numeric type.</typeparam>
        public static void RunInfoVectors<T>(TextWriter writer, string indent) where T : struct {
            writer.WriteLine(indent + string.Format("-- Vectors<{0}> (Count={1}) --", typeof(T).Name, Vector<T>.Count));
            if (ShowFull) {
                WriteLine(writer, indent, "ElementByteSize:\t{0}", Vectors<T>.ElementByteSize);
            }
            writer.WriteLine(indent + string.Format("SignBits-ExponentBits-MantissaBits:\t{0}-{1}-{2}", Vectors<T>.ElementSignBits, Vectors<T>.ElementExponentBits, Vectors<T>.ElementMantissaBits));
            if (ShowFull) {
                writer.WriteLine(indent + string.Format("SignShift-ExponentShift-MantissaShift:\t{0}-{1}-{2}", Vectors<T>.ElementSignShift, Vectors<T>.ElementExponentShift, Vectors<T>.ElementMantissaShift));
                WriteLine(writer, indent, "ElementV0:\t{0}", Vectors<T>.ElementV0);
                WriteLine(writer, indent, "ElementAllBitsSet:\t{0}", Vectors<T>.ElementAllBitsSet);
                WriteLine(writer, indent, "ElementSignMask:\t{0}", Vectors<T>.ElementSignMask);
                WriteLine(writer, indent, "ElementExponentMask:\t{0}", Vectors<T>.ElementExponentMask);
                WriteLine(writer, indent, "ElementMantissaMask:\t{0}", Vectors<T>.ElementMantissaMask);
                WriteLine(writer, indent, "ElementNonSignMask:\t{0}", Vectors<T>.ElementNonSignMask);
                WriteLine(writer, indent, "ElementNonExponentMask:\t{0}", Vectors<T>.ElementNonExponentMask);
                WriteLine(writer, indent, "ElementNonMantissaMask:\t{0}", Vectors<T>.ElementNonMantissaMask);
                WriteLine(writer, indent, "ElementEpsilon:\t{0}", Vectors<T>.ElementEpsilon);
                WriteLine(writer, indent, "ElementMaxValue:\t{0}", Vectors<T>.ElementMaxValue);
                WriteLine(writer, indent, "ElementMinValue:\t{0}", Vectors<T>.ElementMinValue);
                WriteLine(writer, indent, "ElementNaN:\t{0}", Vectors<T>.ElementNaN);
                WriteLine(writer, indent, "ElementNegativeInfinity:\t{0}", Vectors<T>.ElementNegativeInfinity);
                WriteLine(writer, indent, "ElementPositiveInfinity:\t{0}", Vectors<T>.ElementPositiveInfinity);
                WriteLine(writer, indent, "AllBitsSet:\t{0}", Vectors<T>.AllBitsSet);
                WriteLine(writer, indent, "SignMask:\t{0}", Vectors<T>.SignMask);
                WriteLine(writer, indent, "ExponentMask:\t{0}", Vectors<T>.ExponentMask);
                WriteLine(writer, indent, "MantissaMask:\t{0}", Vectors<T>.MantissaMask);
                WriteLine(writer, indent, "NonSignMask:\t{0}", Vectors<T>.NonSignMask);
                WriteLine(writer, indent, "NonExponentMask:\t{0}", Vectors<T>.NonExponentMask);
                WriteLine(writer, indent, "NonMantissaMask:\t{0}", Vectors<T>.NonMantissaMask);
                WriteLine(writer, indent, "Epsilon:\t{0}", Vectors<T>.Epsilon);
                WriteLine(writer, indent, "MaxValue:\t{0}", Vectors<T>.MaxValue);
                WriteLine(writer, indent, "MinValue:\t{0}", Vectors<T>.MinValue);
                WriteLine(writer, indent, "NaN:\t{0}", Vectors<T>.NaN);
                WriteLine(writer, indent, "NegativeInfinity:\t{0}", Vectors<T>.NegativeInfinity);
                WriteLine(writer, indent, "PositiveInfinity:\t{0}", Vectors<T>.PositiveInfinity);
                WriteLine(writer, indent, "FixedOne:\t{0}", Vectors<T>.FixedOne);
                WriteLine(writer, indent, "E:\t{0}", Vectors<T>.E);
                WriteLine(writer, indent, "Pi:\t{0}", Vectors<T>.Pi);
                WriteLine(writer, indent, "Tau:\t{0}", Vectors<T>.Tau);
                WriteLine(writer, indent, "V0:\t{0}", Vectors<T>.V0);
                WriteLine(writer, indent, "V1:\t{0}", Vectors<T>.V1);
                WriteLine(writer, indent, "VMaxSByte:\t{0}", Vectors<T>.VMaxSByte);
                WriteLine(writer, indent, "VMaxByte:\t{0}", Vectors<T>.VMaxByte);
                WriteLine(writer, indent, "VMaxInt16:\t{0}", Vectors<T>.VMaxInt16);
                WriteLine(writer, indent, "VMaxUInt16:\t{0}", Vectors<T>.VMaxUInt16);
                WriteLine(writer, indent, "VMaxInt32:\t{0}", Vectors<T>.VMaxInt32);
                WriteLine(writer, indent, "VMaxUInt32:\t{0}", Vectors<T>.VMaxUInt32);
                WriteLine(writer, indent, "V_1:\t{0}", Vectors<T>.V_1);
                WriteLine(writer, indent, "VMinSByte:\t{0}", Vectors<T>.VMinSByte);
                WriteLine(writer, indent, "VMinInt16:\t{0}", Vectors<T>.VMinInt16);
                WriteLine(writer, indent, "VMinInt32:\t{0}", Vectors<T>.VMinInt32);
                WriteLine(writer, indent, "VReciprocalMaxSByte:\t{0}", Vectors<T>.VReciprocalMaxSByte);
                WriteLine(writer, indent, "VReciprocalMaxByte:\t{0}", Vectors<T>.VReciprocalMaxByte);
                WriteLine(writer, indent, "VReciprocalMaxInt16:\t{0}", Vectors<T>.VReciprocalMaxInt16);
                WriteLine(writer, indent, "VReciprocalMaxUInt16:\t{0}", Vectors<T>.VReciprocalMaxUInt16);
                WriteLine(writer, indent, "VReciprocalMaxInt32:\t{0}", Vectors<T>.VReciprocalMaxInt32);
                WriteLine(writer, indent, "VReciprocalMaxUInt32:\t{0}", Vectors<T>.VReciprocalMaxUInt32);
            }
            WriteLine(writer, indent, "Serial:\t{0}", Vectors<T>.Serial);
            WriteLine(writer, indent, "SerialDesc:\t{0}", Vectors<T>.SerialDesc);
            WriteLine(writer, indent, "SerialNegative:\t{0}", Vectors<T>.SerialNegative);
            WriteLine(writer, indent, "Demo:\t{0}", Vectors<T>.Demo);
            WriteLine(writer, indent, "MaskBitPosSerial:\t{0}", Vectors<T>.MaskBitPosSerial);
            WriteLine(writer, indent, "MaskBitPosSerialRotate:\t{0}", Vectors<T>.MaskBitPosSerialRotate);
            WriteLine(writer, indent, "MaskBitsSerial:\t{0}", Vectors<T>.MaskBitsSerial);
            WriteLine(writer, indent, "MaskBitsSerialRotate:\t{0}", Vectors<T>.MaskBitsSerialRotate);
            if (ShowFull) {
                WriteLine(writer, indent, "InterlacedSign:\t{0}", Vectors<T>.InterlacedSign);
                WriteLine(writer, indent, "InterlacedSignNegative:\t{0}", Vectors<T>.InterlacedSignNegative);
                WriteLine(writer, indent, "MaskBits8:\t{0}", Vectors<T>.MaskBits8);
                WriteLine(writer, indent, "MaskBits16:\t{0}", Vectors<T>.MaskBits16);
                WriteLine(writer, indent, "MaskBits32:\t{0}", Vectors<T>.MaskBits32);
                WriteLine(writer, indent, "XyXMask:\t{0}", Vectors<T>.XyXMask);
                WriteLine(writer, indent, "XyYMask:\t{0}", Vectors<T>.XyYMask);
                WriteLine(writer, indent, "XyzwXMask:\t{0}", Vectors<T>.XyzwXMask);
                WriteLine(writer, indent, "XyzwYMask:\t{0}", Vectors<T>.XyzwYMask);
                WriteLine(writer, indent, "XyzwZMask:\t{0}", Vectors<T>.XyzwZMask);
                WriteLine(writer, indent, "XyzwWMask:\t{0}", Vectors<T>.XyzwWMask);
                WriteLine(writer, indent, "XyzwNotXMask:\t{0}", Vectors<T>.XyzwNotXMask);
                WriteLine(writer, indent, "XyzwNotYMask:\t{0}", Vectors<T>.XyzwNotYMask);
                WriteLine(writer, indent, "XyzwNotZMask:\t{0}", Vectors<T>.XyzwNotZMask);
                WriteLine(writer, indent, "XyzwNotWMask:\t{0}", Vectors<T>.XyzwNotWMask);
                WriteLine(writer, indent, "XyzwXNormOne:\t{0}", Vectors<T>.XyzwXNormOne);
                WriteLine(writer, indent, "XyzwYNormOne:\t{0}", Vectors<T>.XyzwYNormOne);
                WriteLine(writer, indent, "XyzwZNormOne:\t{0}", Vectors<T>.XyzwZNormOne);
                WriteLine(writer, indent, "XyzwWNormOne:\t{0}", Vectors<T>.XyzwWNormOne);
                WriteLine(writer, indent, "RgbaANormOne:\t{0}", Vectors<T>.RgbaANormOne);
            }
        }

        /// <summary>
        /// Run base - <see cref="Vector64s{T}"/>
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <typeparam name="T">The vector element type. T can be any primitive numeric type.</typeparam>
        public static void RunInfoVector64s<T>(TextWriter writer, string indent) where T : struct {
            writer.WriteLine(indent + string.Format("-- Vector64s<{0}> (Count={1}) --", typeof(T).Name, Vector64<T>.Count));
            if (ShowFull) {
                WriteLine(writer, indent, "ElementByteSize:\t{0}", Vector64s<T>.ElementByteSize);
            }
            writer.WriteLine(indent + string.Format("SignBits-ExponentBits-MantissaBits:\t{0}-{1}-{2}", Vector64s<T>.ElementSignBits, Vector64s<T>.ElementExponentBits, Vector64s<T>.ElementMantissaBits));
            if (ShowFull) {
                writer.WriteLine(indent + string.Format("SignShift-ExponentShift-MantissaShift:\t{0}-{1}-{2}", Vector64s<T>.ElementSignShift, Vector64s<T>.ElementExponentShift, Vector64s<T>.ElementMantissaShift));
                WriteLine(writer, indent, "ElementV0:\t{0}", Vector64s<T>.ElementV0);
                WriteLine(writer, indent, "ElementAllBitsSet:\t{0}", Vector64s<T>.ElementAllBitsSet);
                WriteLine(writer, indent, "ElementSignMask:\t{0}", Vector64s<T>.ElementSignMask);
                WriteLine(writer, indent, "ElementExponentMask:\t{0}", Vector64s<T>.ElementExponentMask);
                WriteLine(writer, indent, "ElementMantissaMask:\t{0}", Vector64s<T>.ElementMantissaMask);
                WriteLine(writer, indent, "ElementNonSignMask:\t{0}", Vector64s<T>.ElementNonSignMask);
                WriteLine(writer, indent, "ElementNonExponentMask:\t{0}", Vector64s<T>.ElementNonExponentMask);
                WriteLine(writer, indent, "ElementNonMantissaMask:\t{0}", Vector64s<T>.ElementNonMantissaMask);
                WriteLine(writer, indent, "ElementEpsilon:\t{0}", Vector64s<T>.ElementEpsilon);
                WriteLine(writer, indent, "ElementMaxValue:\t{0}", Vector64s<T>.ElementMaxValue);
                WriteLine(writer, indent, "ElementMinValue:\t{0}", Vector64s<T>.ElementMinValue);
                WriteLine(writer, indent, "ElementNaN:\t{0}", Vector64s<T>.ElementNaN);
                WriteLine(writer, indent, "ElementNegativeInfinity:\t{0}", Vector64s<T>.ElementNegativeInfinity);
                WriteLine(writer, indent, "ElementPositiveInfinity:\t{0}", Vector64s<T>.ElementPositiveInfinity);
                WriteLine(writer, indent, "AllBitsSet:\t{0}", Vector64s<T>.AllBitsSet);
                WriteLine(writer, indent, "SignMask:\t{0}", Vector64s<T>.SignMask);
                WriteLine(writer, indent, "ExponentMask:\t{0}", Vector64s<T>.ExponentMask);
                WriteLine(writer, indent, "MantissaMask:\t{0}", Vector64s<T>.MantissaMask);
                WriteLine(writer, indent, "NonSignMask:\t{0}", Vector64s<T>.NonSignMask);
                WriteLine(writer, indent, "NonExponentMask:\t{0}", Vector64s<T>.NonExponentMask);
                WriteLine(writer, indent, "NonMantissaMask:\t{0}", Vector64s<T>.NonMantissaMask);
                WriteLine(writer, indent, "Epsilon:\t{0}", Vector64s<T>.Epsilon);
                WriteLine(writer, indent, "MaxValue:\t{0}", Vector64s<T>.MaxValue);
                WriteLine(writer, indent, "MinValue:\t{0}", Vector64s<T>.MinValue);
                WriteLine(writer, indent, "NaN:\t{0}", Vector64s<T>.NaN);
                WriteLine(writer, indent, "NegativeInfinity:\t{0}", Vector64s<T>.NegativeInfinity);
                WriteLine(writer, indent, "PositiveInfinity:\t{0}", Vector64s<T>.PositiveInfinity);
                WriteLine(writer, indent, "FixedOne:\t{0}", Vector64s<T>.FixedOne);
                WriteLine(writer, indent, "E:\t{0}", Vector64s<T>.E);
                WriteLine(writer, indent, "Pi:\t{0}", Vector64s<T>.Pi);
                WriteLine(writer, indent, "Tau:\t{0}", Vector64s<T>.Tau);
                WriteLine(writer, indent, "V0:\t{0}", Vector64s<T>.V0);
                WriteLine(writer, indent, "V1:\t{0}", Vector64s<T>.V1);
                WriteLine(writer, indent, "VMaxSByte:\t{0}", Vector64s<T>.VMaxSByte);
                WriteLine(writer, indent, "VMaxByte:\t{0}", Vector64s<T>.VMaxByte);
                WriteLine(writer, indent, "VMaxInt16:\t{0}", Vector64s<T>.VMaxInt16);
                WriteLine(writer, indent, "VMaxUInt16:\t{0}", Vector64s<T>.VMaxUInt16);
                WriteLine(writer, indent, "VMaxInt32:\t{0}", Vector64s<T>.VMaxInt32);
                WriteLine(writer, indent, "VMaxUInt32:\t{0}", Vector64s<T>.VMaxUInt32);
                WriteLine(writer, indent, "V_1:\t{0}", Vector64s<T>.V_1);
                WriteLine(writer, indent, "VMinSByte:\t{0}", Vector64s<T>.VMinSByte);
                WriteLine(writer, indent, "VMinInt16:\t{0}", Vector64s<T>.VMinInt16);
                WriteLine(writer, indent, "VMinInt32:\t{0}", Vector64s<T>.VMinInt32);
                WriteLine(writer, indent, "VReciprocalMaxSByte:\t{0}", Vector64s<T>.VReciprocalMaxSByte);
                WriteLine(writer, indent, "VReciprocalMaxByte:\t{0}", Vector64s<T>.VReciprocalMaxByte);
                WriteLine(writer, indent, "VReciprocalMaxInt16:\t{0}", Vector64s<T>.VReciprocalMaxInt16);
                WriteLine(writer, indent, "VReciprocalMaxUInt16:\t{0}", Vector64s<T>.VReciprocalMaxUInt16);
                WriteLine(writer, indent, "VReciprocalMaxInt32:\t{0}", Vector64s<T>.VReciprocalMaxInt32);
                WriteLine(writer, indent, "VReciprocalMaxUInt32:\t{0}", Vector64s<T>.VReciprocalMaxUInt32);
            }
            WriteLine(writer, indent, "Serial:\t{0}", Vector64s<T>.Serial);
            WriteLine(writer, indent, "SerialDesc:\t{0}", Vector64s<T>.SerialDesc);
            WriteLine(writer, indent, "SerialNegative:\t{0}", Vector64s<T>.SerialNegative);
            WriteLine(writer, indent, "Demo:\t{0}", Vector64s<T>.Demo);
            WriteLine(writer, indent, "MaskBitPosSerial:\t{0}", Vector64s<T>.MaskBitPosSerial);
            WriteLine(writer, indent, "MaskBitPosSerialRotate:\t{0}", Vector64s<T>.MaskBitPosSerialRotate);
            WriteLine(writer, indent, "MaskBitsSerial:\t{0}", Vector64s<T>.MaskBitsSerial);
            WriteLine(writer, indent, "MaskBitsSerialRotate:\t{0}", Vector64s<T>.MaskBitsSerialRotate);
            if (ShowFull) {
                WriteLine(writer, indent, "InterlacedSign:\t{0}", Vector64s<T>.InterlacedSign);
                WriteLine(writer, indent, "InterlacedSignNegative:\t{0}", Vector64s<T>.InterlacedSignNegative);
                WriteLine(writer, indent, "MaskBits8:\t{0}", Vector64s<T>.MaskBits8);
                WriteLine(writer, indent, "MaskBits16:\t{0}", Vector64s<T>.MaskBits16);
                WriteLine(writer, indent, "MaskBits32:\t{0}", Vector64s<T>.MaskBits32);
                WriteLine(writer, indent, "XyXMask:\t{0}", Vector64s<T>.XyXMask);
                WriteLine(writer, indent, "XyYMask:\t{0}", Vector64s<T>.XyYMask);
                WriteLine(writer, indent, "XyzwXMask:\t{0}", Vector64s<T>.XyzwXMask);
                WriteLine(writer, indent, "XyzwYMask:\t{0}", Vector64s<T>.XyzwYMask);
                WriteLine(writer, indent, "XyzwZMask:\t{0}", Vector64s<T>.XyzwZMask);
                WriteLine(writer, indent, "XyzwWMask:\t{0}", Vector64s<T>.XyzwWMask);
                WriteLine(writer, indent, "XyzwNotXMask:\t{0}", Vector64s<T>.XyzwNotXMask);
                WriteLine(writer, indent, "XyzwNotYMask:\t{0}", Vector64s<T>.XyzwNotYMask);
                WriteLine(writer, indent, "XyzwNotZMask:\t{0}", Vector64s<T>.XyzwNotZMask);
                WriteLine(writer, indent, "XyzwNotWMask:\t{0}", Vector64s<T>.XyzwNotWMask);
                WriteLine(writer, indent, "XyzwXNormOne:\t{0}", Vector64s<T>.XyzwXNormOne);
                WriteLine(writer, indent, "XyzwYNormOne:\t{0}", Vector64s<T>.XyzwYNormOne);
                WriteLine(writer, indent, "XyzwZNormOne:\t{0}", Vector64s<T>.XyzwZNormOne);
                WriteLine(writer, indent, "XyzwWNormOne:\t{0}", Vector64s<T>.XyzwWNormOne);
                WriteLine(writer, indent, "RgbaANormOne:\t{0}", Vector64s<T>.RgbaANormOne);
            }
        }

        /// <summary>
        /// Run base - <see cref="Vector128s{T}"/>
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <typeparam name="T">The vector element type. T can be any primitive numeric type.</typeparam>
        public static void RunInfoVector128s<T>(TextWriter writer, string indent) where T : struct {
            writer.WriteLine(indent + string.Format("-- Vector128s<{0}> (Count={1}) --", typeof(T).Name, Vector128<T>.Count));
            if (ShowFull) {
                WriteLine(writer, indent, "ElementByteSize:\t{0}", Vector128s<T>.ElementByteSize);
            }
            writer.WriteLine(indent + string.Format("SignBits-ExponentBits-MantissaBits:\t{0}-{1}-{2}", Vector128s<T>.ElementSignBits, Vector128s<T>.ElementExponentBits, Vector128s<T>.ElementMantissaBits));
            if (ShowFull) {
                writer.WriteLine(indent + string.Format("SignShift-ExponentShift-MantissaShift:\t{0}-{1}-{2}", Vector128s<T>.ElementSignShift, Vector128s<T>.ElementExponentShift, Vector128s<T>.ElementMantissaShift));
                WriteLine(writer, indent, "ElementV0:\t{0}", Vector128s<T>.ElementV0);
                WriteLine(writer, indent, "ElementAllBitsSet:\t{0}", Vector128s<T>.ElementAllBitsSet);
                WriteLine(writer, indent, "ElementSignMask:\t{0}", Vector128s<T>.ElementSignMask);
                WriteLine(writer, indent, "ElementExponentMask:\t{0}", Vector128s<T>.ElementExponentMask);
                WriteLine(writer, indent, "ElementMantissaMask:\t{0}", Vector128s<T>.ElementMantissaMask);
                WriteLine(writer, indent, "ElementNonSignMask:\t{0}", Vector128s<T>.ElementNonSignMask);
                WriteLine(writer, indent, "ElementNonExponentMask:\t{0}", Vector128s<T>.ElementNonExponentMask);
                WriteLine(writer, indent, "ElementNonMantissaMask:\t{0}", Vector128s<T>.ElementNonMantissaMask);
                WriteLine(writer, indent, "ElementEpsilon:\t{0}", Vector128s<T>.ElementEpsilon);
                WriteLine(writer, indent, "ElementMaxValue:\t{0}", Vector128s<T>.ElementMaxValue);
                WriteLine(writer, indent, "ElementMinValue:\t{0}", Vector128s<T>.ElementMinValue);
                WriteLine(writer, indent, "ElementNaN:\t{0}", Vector128s<T>.ElementNaN);
                WriteLine(writer, indent, "ElementNegativeInfinity:\t{0}", Vector128s<T>.ElementNegativeInfinity);
                WriteLine(writer, indent, "ElementPositiveInfinity:\t{0}", Vector128s<T>.ElementPositiveInfinity);
                WriteLine(writer, indent, "AllBitsSet:\t{0}", Vector128s<T>.AllBitsSet);
                WriteLine(writer, indent, "SignMask:\t{0}", Vector128s<T>.SignMask);
                WriteLine(writer, indent, "ExponentMask:\t{0}", Vector128s<T>.ExponentMask);
                WriteLine(writer, indent, "MantissaMask:\t{0}", Vector128s<T>.MantissaMask);
                WriteLine(writer, indent, "NonSignMask:\t{0}", Vector128s<T>.NonSignMask);
                WriteLine(writer, indent, "NonExponentMask:\t{0}", Vector128s<T>.NonExponentMask);
                WriteLine(writer, indent, "NonMantissaMask:\t{0}", Vector128s<T>.NonMantissaMask);
                WriteLine(writer, indent, "Epsilon:\t{0}", Vector128s<T>.Epsilon);
                WriteLine(writer, indent, "MaxValue:\t{0}", Vector128s<T>.MaxValue);
                WriteLine(writer, indent, "MinValue:\t{0}", Vector128s<T>.MinValue);
                WriteLine(writer, indent, "NaN:\t{0}", Vector128s<T>.NaN);
                WriteLine(writer, indent, "NegativeInfinity:\t{0}", Vector128s<T>.NegativeInfinity);
                WriteLine(writer, indent, "PositiveInfinity:\t{0}", Vector128s<T>.PositiveInfinity);
                WriteLine(writer, indent, "FixedOne:\t{0}", Vector128s<T>.FixedOne);
                WriteLine(writer, indent, "E:\t{0}", Vector128s<T>.E);
                WriteLine(writer, indent, "Pi:\t{0}", Vector128s<T>.Pi);
                WriteLine(writer, indent, "Tau:\t{0}", Vector128s<T>.Tau);
                WriteLine(writer, indent, "V0:\t{0}", Vector128s<T>.V0);
                WriteLine(writer, indent, "V1:\t{0}", Vector128s<T>.V1);
                WriteLine(writer, indent, "VMaxSByte:\t{0}", Vector128s<T>.VMaxSByte);
                WriteLine(writer, indent, "VMaxByte:\t{0}", Vector128s<T>.VMaxByte);
                WriteLine(writer, indent, "VMaxInt16:\t{0}", Vector128s<T>.VMaxInt16);
                WriteLine(writer, indent, "VMaxUInt16:\t{0}", Vector128s<T>.VMaxUInt16);
                WriteLine(writer, indent, "VMaxInt32:\t{0}", Vector128s<T>.VMaxInt32);
                WriteLine(writer, indent, "VMaxUInt32:\t{0}", Vector128s<T>.VMaxUInt32);
                WriteLine(writer, indent, "V_1:\t{0}", Vector128s<T>.V_1);
                WriteLine(writer, indent, "VMinSByte:\t{0}", Vector128s<T>.VMinSByte);
                WriteLine(writer, indent, "VMinInt16:\t{0}", Vector128s<T>.VMinInt16);
                WriteLine(writer, indent, "VMinInt32:\t{0}", Vector128s<T>.VMinInt32);
                WriteLine(writer, indent, "VReciprocalMaxSByte:\t{0}", Vector128s<T>.VReciprocalMaxSByte);
                WriteLine(writer, indent, "VReciprocalMaxByte:\t{0}", Vector128s<T>.VReciprocalMaxByte);
                WriteLine(writer, indent, "VReciprocalMaxInt16:\t{0}", Vector128s<T>.VReciprocalMaxInt16);
                WriteLine(writer, indent, "VReciprocalMaxUInt16:\t{0}", Vector128s<T>.VReciprocalMaxUInt16);
                WriteLine(writer, indent, "VReciprocalMaxInt32:\t{0}", Vector128s<T>.VReciprocalMaxInt32);
                WriteLine(writer, indent, "VReciprocalMaxUInt32:\t{0}", Vector128s<T>.VReciprocalMaxUInt32);
            }
            WriteLine(writer, indent, "Serial:\t{0}", Vector128s<T>.Serial);
            WriteLine(writer, indent, "SerialDesc:\t{0}", Vector128s<T>.SerialDesc);
            WriteLine(writer, indent, "SerialNegative:\t{0}", Vector128s<T>.SerialNegative);
            WriteLine(writer, indent, "Demo:\t{0}", Vector128s<T>.Demo);
            WriteLine(writer, indent, "MaskBitPosSerial:\t{0}", Vector128s<T>.MaskBitPosSerial);
            WriteLine(writer, indent, "MaskBitPosSerialRotate:\t{0}", Vector128s<T>.MaskBitPosSerialRotate);
            WriteLine(writer, indent, "MaskBitsSerial:\t{0}", Vector128s<T>.MaskBitsSerial);
            WriteLine(writer, indent, "MaskBitsSerialRotate:\t{0}", Vector128s<T>.MaskBitsSerialRotate);
            if (ShowFull) {
                WriteLine(writer, indent, "InterlacedSign:\t{0}", Vector128s<T>.InterlacedSign);
                WriteLine(writer, indent, "InterlacedSignNegative:\t{0}", Vector128s<T>.InterlacedSignNegative);
                WriteLine(writer, indent, "MaskBits8:\t{0}", Vector128s<T>.MaskBits8);
                WriteLine(writer, indent, "MaskBits16:\t{0}", Vector128s<T>.MaskBits16);
                WriteLine(writer, indent, "MaskBits32:\t{0}", Vector128s<T>.MaskBits32);
                WriteLine(writer, indent, "XyXMask:\t{0}", Vector128s<T>.XyXMask);
                WriteLine(writer, indent, "XyYMask:\t{0}", Vector128s<T>.XyYMask);
                WriteLine(writer, indent, "XyzwXMask:\t{0}", Vector128s<T>.XyzwXMask);
                WriteLine(writer, indent, "XyzwYMask:\t{0}", Vector128s<T>.XyzwYMask);
                WriteLine(writer, indent, "XyzwZMask:\t{0}", Vector128s<T>.XyzwZMask);
                WriteLine(writer, indent, "XyzwWMask:\t{0}", Vector128s<T>.XyzwWMask);
                WriteLine(writer, indent, "XyzwNotXMask:\t{0}", Vector128s<T>.XyzwNotXMask);
                WriteLine(writer, indent, "XyzwNotYMask:\t{0}", Vector128s<T>.XyzwNotYMask);
                WriteLine(writer, indent, "XyzwNotZMask:\t{0}", Vector128s<T>.XyzwNotZMask);
                WriteLine(writer, indent, "XyzwNotWMask:\t{0}", Vector128s<T>.XyzwNotWMask);
                WriteLine(writer, indent, "XyzwXNormOne:\t{0}", Vector128s<T>.XyzwXNormOne);
                WriteLine(writer, indent, "XyzwYNormOne:\t{0}", Vector128s<T>.XyzwYNormOne);
                WriteLine(writer, indent, "XyzwZNormOne:\t{0}", Vector128s<T>.XyzwZNormOne);
                WriteLine(writer, indent, "XyzwWNormOne:\t{0}", Vector128s<T>.XyzwWNormOne);
                WriteLine(writer, indent, "RgbaANormOne:\t{0}", Vector128s<T>.RgbaANormOne);
            }
        }

        /// <summary>
        /// Run base - <see cref="Vector256s{T}"/>
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <typeparam name="T">The vector element type. T can be any primitive numeric type.</typeparam>
        public static void RunInfoVector256s<T>(TextWriter writer, string indent) where T : struct {
            writer.WriteLine(indent + string.Format("-- Vector256s<{0}> (Count={1}) --", typeof(T).Name, Vector256<T>.Count));
            if (ShowFull) {
                WriteLine(writer, indent, "ElementByteSize:\t{0}", Vector256s<T>.ElementByteSize);
            }
            writer.WriteLine(indent + string.Format("SignBits-ExponentBits-MantissaBits:\t{0}-{1}-{2}", Vector256s<T>.ElementSignBits, Vector256s<T>.ElementExponentBits, Vector256s<T>.ElementMantissaBits));
            if (ShowFull) {
                writer.WriteLine(indent + string.Format("SignShift-ExponentShift-MantissaShift:\t{0}-{1}-{2}", Vector256s<T>.ElementSignShift, Vector256s<T>.ElementExponentShift, Vector256s<T>.ElementMantissaShift));
                WriteLine(writer, indent, "ElementV0:\t{0}", Vector256s<T>.ElementV0);
                WriteLine(writer, indent, "ElementAllBitsSet:\t{0}", Vector256s<T>.ElementAllBitsSet);
                WriteLine(writer, indent, "ElementSignMask:\t{0}", Vector256s<T>.ElementSignMask);
                WriteLine(writer, indent, "ElementExponentMask:\t{0}", Vector256s<T>.ElementExponentMask);
                WriteLine(writer, indent, "ElementMantissaMask:\t{0}", Vector256s<T>.ElementMantissaMask);
                WriteLine(writer, indent, "ElementNonSignMask:\t{0}", Vector256s<T>.ElementNonSignMask);
                WriteLine(writer, indent, "ElementNonExponentMask:\t{0}", Vector256s<T>.ElementNonExponentMask);
                WriteLine(writer, indent, "ElementNonMantissaMask:\t{0}", Vector256s<T>.ElementNonMantissaMask);
                WriteLine(writer, indent, "ElementEpsilon:\t{0}", Vector256s<T>.ElementEpsilon);
                WriteLine(writer, indent, "ElementMaxValue:\t{0}", Vector256s<T>.ElementMaxValue);
                WriteLine(writer, indent, "ElementMinValue:\t{0}", Vector256s<T>.ElementMinValue);
                WriteLine(writer, indent, "ElementNaN:\t{0}", Vector256s<T>.ElementNaN);
                WriteLine(writer, indent, "ElementNegativeInfinity:\t{0}", Vector256s<T>.ElementNegativeInfinity);
                WriteLine(writer, indent, "ElementPositiveInfinity:\t{0}", Vector256s<T>.ElementPositiveInfinity);
                WriteLine(writer, indent, "AllBitsSet:\t{0}", Vector256s<T>.AllBitsSet);
                WriteLine(writer, indent, "SignMask:\t{0}", Vector256s<T>.SignMask);
                WriteLine(writer, indent, "ExponentMask:\t{0}", Vector256s<T>.ExponentMask);
                WriteLine(writer, indent, "MantissaMask:\t{0}", Vector256s<T>.MantissaMask);
                WriteLine(writer, indent, "NonSignMask:\t{0}", Vector256s<T>.NonSignMask);
                WriteLine(writer, indent, "NonExponentMask:\t{0}", Vector256s<T>.NonExponentMask);
                WriteLine(writer, indent, "NonMantissaMask:\t{0}", Vector256s<T>.NonMantissaMask);
                WriteLine(writer, indent, "Epsilon:\t{0}", Vector256s<T>.Epsilon);
                WriteLine(writer, indent, "MaxValue:\t{0}", Vector256s<T>.MaxValue);
                WriteLine(writer, indent, "MinValue:\t{0}", Vector256s<T>.MinValue);
                WriteLine(writer, indent, "NaN:\t{0}", Vector256s<T>.NaN);
                WriteLine(writer, indent, "NegativeInfinity:\t{0}", Vector256s<T>.NegativeInfinity);
                WriteLine(writer, indent, "PositiveInfinity:\t{0}", Vector256s<T>.PositiveInfinity);
                WriteLine(writer, indent, "FixedOne:\t{0}", Vector256s<T>.FixedOne);
                WriteLine(writer, indent, "E:\t{0}", Vector256s<T>.E);
                WriteLine(writer, indent, "Pi:\t{0}", Vector256s<T>.Pi);
                WriteLine(writer, indent, "Tau:\t{0}", Vector256s<T>.Tau);
                WriteLine(writer, indent, "V0:\t{0}", Vector256s<T>.V0);
                WriteLine(writer, indent, "V1:\t{0}", Vector256s<T>.V1);
                WriteLine(writer, indent, "VMaxSByte:\t{0}", Vector256s<T>.VMaxSByte);
                WriteLine(writer, indent, "VMaxByte:\t{0}", Vector256s<T>.VMaxByte);
                WriteLine(writer, indent, "VMaxInt16:\t{0}", Vector256s<T>.VMaxInt16);
                WriteLine(writer, indent, "VMaxUInt16:\t{0}", Vector256s<T>.VMaxUInt16);
                WriteLine(writer, indent, "VMaxInt32:\t{0}", Vector256s<T>.VMaxInt32);
                WriteLine(writer, indent, "VMaxUInt32:\t{0}", Vector256s<T>.VMaxUInt32);
                WriteLine(writer, indent, "V_1:\t{0}", Vector256s<T>.V_1);
                WriteLine(writer, indent, "VMinSByte:\t{0}", Vector256s<T>.VMinSByte);
                WriteLine(writer, indent, "VMinInt16:\t{0}", Vector256s<T>.VMinInt16);
                WriteLine(writer, indent, "VMinInt32:\t{0}", Vector256s<T>.VMinInt32);
                WriteLine(writer, indent, "VReciprocalMaxSByte:\t{0}", Vector256s<T>.VReciprocalMaxSByte);
                WriteLine(writer, indent, "VReciprocalMaxByte:\t{0}", Vector256s<T>.VReciprocalMaxByte);
                WriteLine(writer, indent, "VReciprocalMaxInt16:\t{0}", Vector256s<T>.VReciprocalMaxInt16);
                WriteLine(writer, indent, "VReciprocalMaxUInt16:\t{0}", Vector256s<T>.VReciprocalMaxUInt16);
                WriteLine(writer, indent, "VReciprocalMaxInt32:\t{0}", Vector256s<T>.VReciprocalMaxInt32);
                WriteLine(writer, indent, "VReciprocalMaxUInt32:\t{0}", Vector256s<T>.VReciprocalMaxUInt32);
            }
            WriteLine(writer, indent, "Serial:\t{0}", Vector256s<T>.Serial);
            WriteLine(writer, indent, "SerialDesc:\t{0}", Vector256s<T>.SerialDesc);
            WriteLine(writer, indent, "SerialNegative:\t{0}", Vector256s<T>.SerialNegative);
            WriteLine(writer, indent, "Demo:\t{0}", Vector256s<T>.Demo);
            WriteLine(writer, indent, "MaskBitPosSerial:\t{0}", Vector256s<T>.MaskBitPosSerial);
            WriteLine(writer, indent, "MaskBitPosSerialRotate:\t{0}", Vector256s<T>.MaskBitPosSerialRotate);
            WriteLine(writer, indent, "MaskBitsSerial:\t{0}", Vector256s<T>.MaskBitsSerial);
            WriteLine(writer, indent, "MaskBitsSerialRotate:\t{0}", Vector256s<T>.MaskBitsSerialRotate);
            if (ShowFull) {
                WriteLine(writer, indent, "InterlacedSign:\t{0}", Vector256s<T>.InterlacedSign);
                WriteLine(writer, indent, "InterlacedSignNegative:\t{0}", Vector256s<T>.InterlacedSignNegative);
                WriteLine(writer, indent, "MaskBits8:\t{0}", Vector256s<T>.MaskBits8);
                WriteLine(writer, indent, "MaskBits16:\t{0}", Vector256s<T>.MaskBits16);
                WriteLine(writer, indent, "MaskBits32:\t{0}", Vector256s<T>.MaskBits32);
                WriteLine(writer, indent, "XyXMask:\t{0}", Vector256s<T>.XyXMask);
                WriteLine(writer, indent, "XyYMask:\t{0}", Vector256s<T>.XyYMask);
                WriteLine(writer, indent, "XyzwXMask:\t{0}", Vector256s<T>.XyzwXMask);
                WriteLine(writer, indent, "XyzwYMask:\t{0}", Vector256s<T>.XyzwYMask);
                WriteLine(writer, indent, "XyzwZMask:\t{0}", Vector256s<T>.XyzwZMask);
                WriteLine(writer, indent, "XyzwWMask:\t{0}", Vector256s<T>.XyzwWMask);
                WriteLine(writer, indent, "XyzwNotXMask:\t{0}", Vector256s<T>.XyzwNotXMask);
                WriteLine(writer, indent, "XyzwNotYMask:\t{0}", Vector256s<T>.XyzwNotYMask);
                WriteLine(writer, indent, "XyzwNotZMask:\t{0}", Vector256s<T>.XyzwNotZMask);
                WriteLine(writer, indent, "XyzwNotWMask:\t{0}", Vector256s<T>.XyzwNotWMask);
                WriteLine(writer, indent, "XyzwXNormOne:\t{0}", Vector256s<T>.XyzwXNormOne);
                WriteLine(writer, indent, "XyzwYNormOne:\t{0}", Vector256s<T>.XyzwYNormOne);
                WriteLine(writer, indent, "XyzwZNormOne:\t{0}", Vector256s<T>.XyzwZNormOne);
                WriteLine(writer, indent, "XyzwWNormOne:\t{0}", Vector256s<T>.XyzwWNormOne);
                WriteLine(writer, indent, "RgbaANormOne:\t{0}", Vector256s<T>.RgbaANormOne);
            }
        }

    }
}
