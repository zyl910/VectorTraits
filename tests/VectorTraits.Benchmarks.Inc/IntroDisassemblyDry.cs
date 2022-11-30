using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public class IntroDisassemblyDry {

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

        [Benchmark]
        public int RunVector128() {
            StringWriter writer = new StringWriter();
            string indent = "";
            string indentNext = indent + "\t";
#if NET7_0_OR_GREATER
            if (Vector128.IsHardwareAccelerated) {
                writer.WriteLine();
            }
            writer.WriteLine(indent + string.Format("-- Vector128.IsSupported:\t{0}", Vector128.IsHardwareAccelerated));
            if (!Vector128.IsHardwareAccelerated) {
                return 0;
            }

            // Count.
            writer.WriteLine(indent + string.Format("Vector128<Single>.Count:\t{0}", Vector128<Single>.Count));
            writer.WriteLine(indent + string.Format("Vector128<Double>.Count:\t{0}", Vector128<Double>.Count));
            writer.WriteLine(indent + string.Format("Vector128<SByte>.Count:\t{0}", Vector128<SByte>.Count));
            writer.WriteLine(indent + string.Format("Vector128<Byte>.Count:\t{0}", Vector128<Byte>.Count));
            writer.WriteLine(indent + string.Format("Vector128<Int16>.Count:\t{0}", Vector128<Int16>.Count));
            writer.WriteLine(indent + string.Format("Vector128<UInt16>.Count:\t{0}", Vector128<UInt16>.Count));
            writer.WriteLine(indent + string.Format("Vector128<Int32>.Count:\t{0}", Vector128<Int32>.Count));
            writer.WriteLine(indent + string.Format("Vector128<UInt32>.Count:\t{0}", Vector128<UInt32>.Count));
            writer.WriteLine(indent + string.Format("Vector128<Int64>.Count:\t{0}", Vector128<Int64>.Count));
            writer.WriteLine(indent + string.Format("Vector128<UInt64>.Count:\t{0}", Vector128<UInt64>.Count));
            writer.WriteLine(indent + string.Format("Vector128<IntPtr>.Count:\t{0}", Vector128<IntPtr>.Count));
            writer.WriteLine(indent + string.Format("Vector128<UIntPtr>.Count:\t{0}", Vector128<UIntPtr>.Count));
            // Unhandled exception. System.NotSupportedException: Specified type is not supported
            //writer.WriteLine(indent + string.Format("Vector128<Half>.Count:\t{0}", Vector128<Half>.Count));

            // -- Methods --
            int shift;
            unchecked {
                //Debugger.Break();
                // Abs<T>(Vector128<T>)	
                // Computes the absolute value of each element in a vector.
                WriteLine(writer, indent, "Abs(Vector128s<Single>.Demo):\t{0}", Vector128.Abs(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "Abs(Vector128s<Double>.Demo):\t{0}", Vector128.Abs(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "Abs(Vector128s<SByte>.Demo):\t{0}", Vector128.Abs(Vector128s<SByte>.Demo));
                WriteLine(writer, indent, "Abs(Vector128s<Byte>.Demo):\t{0}", Vector128.Abs(Vector128s<Byte>.Demo));
                WriteLine(writer, indent, "Abs(Vector128s<Int16>.Demo):\t{0}", Vector128.Abs(Vector128s<Int16>.Demo));
                WriteLine(writer, indent, "Abs(Vector128s<UInt16>.Demo):\t{0}", Vector128.Abs(Vector128s<UInt16>.Demo));
                WriteLine(writer, indent, "Abs(Vector128s<Int32>.Demo):\t{0}", Vector128.Abs(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "Abs(Vector128s<UInt32>.Demo):\t{0}", Vector128.Abs(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "Abs(Vector128s<Int64>.Demo):\t{0}", Vector128.Abs(Vector128s<Int64>.Demo));
                WriteLine(writer, indent, "Abs(Vector128s<UInt64>.Demo):\t{0}", Vector128.Abs(Vector128s<UInt64>.Demo));

                // Add<T>(Vector128<T>, Vector128<T>)	
                // Adds writero vectors to compute their sum.
                WriteLine(writer, indent, "Add(Vector128s<Single>.Demo, Vector128s<Single>.V2):\t{0}", Vector128.Add(Vector128s<Single>.Demo, Vector128s<Single>.V2));
                WriteLine(writer, indent, "Add(Vector128s<Double>.Demo, Vector128s<Double>.V2):\t{0}", Vector128.Add(Vector128s<Double>.Demo, Vector128s<Double>.V2));
                WriteLine(writer, indent, "Add(Vector128s<SByte>.Demo, Vector128s<SByte>.V2):\t{0}", Vector128.Add(Vector128s<SByte>.Demo, Vector128s<SByte>.V2));
                WriteLine(writer, indent, "Add(Vector128s<Byte>.Demo, Vector128s<Byte>.V2):\t{0}", Vector128.Add(Vector128s<Byte>.Demo, Vector128s<Byte>.V2));
                WriteLine(writer, indent, "Add(Vector128s<Int16>.Demo, Vector128s<Int16>.V2):\t{0}", Vector128.Add(Vector128s<Int16>.Demo, Vector128s<Int16>.V2));
                WriteLine(writer, indent, "Add(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2):\t{0}", Vector128.Add(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2));
                WriteLine(writer, indent, "Add(Vector128s<Int32>.Demo, Vector128s<Int32>.V2):\t{0}", Vector128.Add(Vector128s<Int32>.Demo, Vector128s<Int32>.V2));
                WriteLine(writer, indent, "Add(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2):\t{0}", Vector128.Add(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2));
                WriteLine(writer, indent, "Add(Vector128s<Int64>.Demo, Vector128s<Int64>.V2):\t{0}", Vector128.Add(Vector128s<Int64>.Demo, Vector128s<Int64>.V2));
                WriteLine(writer, indent, "Add(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2):\t{0}", Vector128.Add(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2));

                // AndNot<T>(Vector128<T>, Vector128<T>)	
                // Computes the bitwise-and of a given vector and the ones complement of another vector.
                WriteLine(writer, indent, "AndNot(Vector128s<Single>.Demo, Vector128s<Single>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<Single>.Demo, Vector128s<Single>.XyzwWMask));
                WriteLine(writer, indent, "AndNot(Vector128s<Double>.Demo, Vector128s<Double>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<Double>.Demo, Vector128s<Double>.XyzwWMask));
                WriteLine(writer, indent, "AndNot(Vector128s<SByte>.Demo, Vector128s<SByte>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<SByte>.Demo, Vector128s<SByte>.XyzwWMask));
                WriteLine(writer, indent, "AndNot(Vector128s<Byte>.Demo, Vector128s<Byte>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<Byte>.Demo, Vector128s<Byte>.XyzwWMask));
                WriteLine(writer, indent, "AndNot(Vector128s<Int16>.Demo, Vector128s<Int16>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<Int16>.Demo, Vector128s<Int16>.XyzwWMask));
                WriteLine(writer, indent, "AndNot(Vector128s<UInt16>.Demo, Vector128s<UInt16>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<UInt16>.Demo, Vector128s<UInt16>.XyzwWMask));
                WriteLine(writer, indent, "AndNot(Vector128s<Int32>.Demo, Vector128s<Int32>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<Int32>.Demo, Vector128s<Int32>.XyzwWMask));
                WriteLine(writer, indent, "AndNot(Vector128s<UInt32>.Demo, Vector128s<UInt32>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<UInt32>.Demo, Vector128s<UInt32>.XyzwWMask));
                WriteLine(writer, indent, "AndNot(Vector128s<Int64>.Demo, Vector128s<Int64>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<Int64>.Demo, Vector128s<Int64>.XyzwWMask));
                WriteLine(writer, indent, "AndNot(Vector128s<UInt64>.Demo, Vector128s<UInt64>.XyzwWMask):\t{0}", Vector128.AndNot(Vector128s<UInt64>.Demo, Vector128s<UInt64>.XyzwWMask));

                // As<TFrom,TTo>(Vector128<TFrom>)	
                // Reinterprets a Vector128<T> of type TFrom as a new Vector128<T> of type TTo.
                // AsByte<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type Byte.
                // AsDouble<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type Double.
                // AsInt16<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type Int16.
                // AsInt32<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type Int32.
                // AsInt64<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type Int64.
                // AsNInt<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128<T>.
                // AsNUInt<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128<T>.
                // AsSByte<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type SByte.
                // AsSingle<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type Single.
                // AsUInt16<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type UInt16.
                // AsUInt32<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type UInt32.
                // AsUInt64<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector128 of type UInt64.
                // AsVector<T>(Vector128<T>)	
                // Reinterprets a Vector128<T> as a new Vector<T>.
                // AsVector128<T>(Vector<T>)	
                // Reinterprets a Vector<T> as a new Vector128<T>.
                // `As***` see below.

                // BitwiseAnd<T>(Vector128<T>, Vector128<T>)	
                // Computes the bitwise-and of writero vectors.
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<Single>.Demo, Vector128s<Single>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<Single>.Demo, Vector128s<Single>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<Double>.Demo, Vector128s<Double>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<Double>.Demo, Vector128s<Double>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<SByte>.Demo, Vector128s<SByte>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<SByte>.Demo, Vector128s<SByte>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<Byte>.Demo, Vector128s<Byte>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<Byte>.Demo, Vector128s<Byte>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<Int16>.Demo, Vector128s<Int16>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<Int16>.Demo, Vector128s<Int16>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<UInt16>.Demo, Vector128s<UInt16>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<UInt16>.Demo, Vector128s<UInt16>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<Int32>.Demo, Vector128s<Int32>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<Int32>.Demo, Vector128s<Int32>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<UInt32>.Demo, Vector128s<UInt32>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<UInt32>.Demo, Vector128s<UInt32>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<Int64>.Demo, Vector128s<Int64>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<Int64>.Demo, Vector128s<Int64>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseAnd(Vector128s<UInt64>.Demo, Vector128s<UInt64>.XyzwWMask):\t{0}", Vector128.BitwiseAnd(Vector128s<UInt64>.Demo, Vector128s<UInt64>.XyzwWMask));

                // BitwiseOr<T>(Vector128<T>, Vector128<T>)	
                // Computes the bitwise-or of writero vectors.
                WriteLine(writer, indent, "BitwiseOr(Vector128s<Single>.Demo, Vector128s<Single>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<Single>.Demo, Vector128s<Single>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseOr(Vector128s<Double>.Demo, Vector128s<Double>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<Double>.Demo, Vector128s<Double>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseOr(Vector128s<SByte>.Demo, Vector128s<SByte>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<SByte>.Demo, Vector128s<SByte>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseOr(Vector128s<Byte>.Demo, Vector128s<Byte>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<Byte>.Demo, Vector128s<Byte>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseOr(Vector128s<Int16>.Demo, Vector128s<Int16>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<Int16>.Demo, Vector128s<Int16>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseOr(Vector128s<UInt16>.Demo, Vector128s<UInt16>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<UInt16>.Demo, Vector128s<UInt16>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseOr(Vector128s<Int32>.Demo, Vector128s<Int32>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<Int32>.Demo, Vector128s<Int32>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseOr(Vector128s<UInt32>.Demo, Vector128s<UInt32>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<UInt32>.Demo, Vector128s<UInt32>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseOr(Vector128s<Int64>.Demo, Vector128s<Int64>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<Int64>.Demo, Vector128s<Int64>.XyzwWMask));
                WriteLine(writer, indent, "BitwiseOr(Vector128s<UInt64>.Demo, Vector128s<UInt64>.XyzwWMask):\t{0}", Vector128.BitwiseOr(Vector128s<UInt64>.Demo, Vector128s<UInt64>.XyzwWMask));

                // Ceiling(Vector128<Double>)	
                // Computes the ceiling of each element in a vector.
                // Ceiling(Vector128<Single>)	
                // Computes the ceiling of each element in a vector.
                Tip.Ceiling<Single>();
                WriteLine(writer, indent, "Ceiling(Vector128s<Single>.Demo):\t{0}", Vector128.Ceiling(Vector128s<Single>.Demo));
                Tip.Ceiling<Double>();
                WriteLine(writer, indent, "Ceiling(Vector128s<Double>.Demo):\t{0}", Vector128.Ceiling(Vector128s<Double>.Demo));

                // ConditionalSelect<T>(Vector128<T>, Vector128<T>, Vector128<T>)	
                // Conditionally selects a value from writero vectors on a bitwise basis.
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<Single>.XyzwWMask, Vector128s<Single>.Demo, Vector128s<Single>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<Single>.XyzwWMask, Vector128s<Single>.Demo, Vector128s<Single>.V7));
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<Double>.XyzwWMask, Vector128s<Double>.Demo, Vector128s<Double>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<Double>.XyzwWMask, Vector128s<Double>.Demo, Vector128s<Double>.V7));
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<SByte>.XyzwWMask, Vector128s<SByte>.Demo, Vector128s<SByte>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<SByte>.XyzwWMask, Vector128s<SByte>.Demo, Vector128s<SByte>.V7));
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<Byte>.XyzwWMask, Vector128s<Byte>.Demo, Vector128s<Byte>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<Byte>.XyzwWMask, Vector128s<Byte>.Demo, Vector128s<Byte>.V7));
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<Int16>.XyzwWMask, Vector128s<Int16>.Demo, Vector128s<Int16>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<Int16>.XyzwWMask, Vector128s<Int16>.Demo, Vector128s<Int16>.V7));
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<UInt16>.XyzwWMask, Vector128s<UInt16>.Demo, Vector128s<UInt16>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<UInt16>.XyzwWMask, Vector128s<UInt16>.Demo, Vector128s<UInt16>.V7));
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<Int32>.XyzwWMask, Vector128s<Int32>.Demo, Vector128s<Int32>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<Int32>.XyzwWMask, Vector128s<Int32>.Demo, Vector128s<Int32>.V7));
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<UInt32>.XyzwWMask, Vector128s<UInt32>.Demo, Vector128s<UInt32>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<UInt32>.XyzwWMask, Vector128s<UInt32>.Demo, Vector128s<UInt32>.V7));
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<Int64>.XyzwWMask, Vector128s<Int64>.Demo, Vector128s<Int64>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<Int64>.XyzwWMask, Vector128s<Int64>.Demo, Vector128s<Int64>.V7));
                WriteLine(writer, indent, "ConditionalSelect(Vector128s<UInt64>.XyzwWMask, Vector128s<UInt64>.Demo, Vector128s<UInt64>.V7):\t{0}", Vector128.ConditionalSelect(Vector128s<UInt64>.XyzwWMask, Vector128s<UInt64>.Demo, Vector128s<UInt64>.V7));

                // ConvertToDouble(Vector128<Int64>)	
                // Converts a Vector128<T> to a Vector128<T>.
                // ConvertToDouble(Vector128<UInt64>)	
                // Converts a Vector128<T> to a Vector128<T>.
                // ConvertToInt32(Vector128<Single>)	
                // Converts a Vector128<T> to a Vector128<T>.
                // ConvertToInt64(Vector128<Double>)	
                // Converts a Vector128<T> to a Vector128<T>.
                // ConvertToSingle(Vector128<Int32>)	
                // Converts a Vector128<T> to a Vector128<T>.
                // ConvertToSingle(Vector128<UInt32>)	
                // Converts a Vector128<T> to a Vector128<T>.
                // ConvertToUInt32(Vector128<Single>)	
                // Converts a Vector128<T> to a Vector128<T>.
                // ConvertToUInt64(Vector128<Double>)	
                // Converts a Vector128<T> to a Vector128<T>.
                WriteLine(writer, indent, "ConvertToDouble(Vector128s<Int64>.Demo):\t{0}", Vector128.ConvertToDouble(Vector128s<Int64>.Demo));
                WriteLine(writer, indent, "ConvertToDouble(Vector128s<UInt64>.Demo):\t{0}", Vector128.ConvertToDouble(Vector128s<UInt64>.Demo));
                WriteLine(writer, indent, "ConvertToInt32(Vector128s<Single>.Demo):\t{0}", Vector128.ConvertToInt32(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "ConvertToInt64(Vector128s<Double>.Demo):\t{0}", Vector128.ConvertToInt64(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "ConvertToSingle(Vector128s<Int32>.Demo):\t{0}", Vector128.ConvertToSingle(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "ConvertToSingle(Vector128s<UInt32>.Demo):\t{0}", Vector128.ConvertToSingle(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "ConvertToUInt32(Vector128s<Single>.Demo):\t{0}", Vector128.ConvertToUInt32(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "ConvertToUInt64(Vector128s<Double>.Demo):\t{0}", Vector128.ConvertToUInt64(Vector128s<Double>.Demo));

                // CopyTo<T>(Vector128<T>, Span<T>)	
                // Copies a Vector128<T> to a given span.
                // CopyTo<T>(Vector128<T>, T[])	
                // Copies a Vector128<T> to a given array.
                // CopyTo<T>(Vector128<T>, T[], Int32)	
                // Copies a Vector128<T> to a given array starting at the specified index.

                // Create(Byte)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte, Byte)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(Double)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(Double, Double, Double, Double)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(Int16)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(Int16, Int16, Int16, Int16, Int16, Int16, Int16, Int16, Int16, Int16, Int16, Int16, Int16, Int16, Int16, Int16)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(Int32)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(Int64)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(Int64, Int64, Int64, Int64)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(IntPtr)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(SByte)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte, SByte)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(Single)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(Single, Single, Single, Single, Single, Single, Single, Single)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(UInt16)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16, UInt16)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(UInt32)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(UInt64)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create(UInt64, UInt64, UInt64, UInt64)	
                // Creates a new Vector128<T> instance with each element initialized to the corresponding specified value.
                // Create(UIntPtr)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // `Create` see below.

                // Create(Vector64<Byte>, Vector64<Byte>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                // Create(Vector64<Double>, Vector64<Double>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                // Create(Vector64<Int16>, Vector64<Int16>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                // Create(Vector64<Int32>, Vector64<Int32>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                // Create(Vector64<Int64>, Vector64<Int64>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                // Create(Vector64<SByte>, Vector64<SByte>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                // Create(Vector64<Single>, Vector64<Single>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                // Create(Vector64<UInt16>, Vector64<UInt16>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                // Create(Vector64<UInt32>, Vector64<UInt32>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                // Create(Vector64<UInt64>, Vector64<UInt64>)	
                // Creates a new Vector128<T> instance from writero Vector64<T> instances.
                WriteLine(writer, indent, "Create(Vector64s<Single>.Demo, Vector64s<Single>.SerialNegative):\t{0}", Vector128.Create(Vector64s<Single>.Demo, Vector64s<Single>.SerialNegative));

                // Create<T>(ReadOnlySpan<T>)	
                // Creates a new Vector128<T> from a given readonly span.
                // Create<T>(T)	
                // Creates a new Vector128<T> instance with all elements initialized to the specified value.
                // Create<T>(T[])	
                // Creates a new Vector128<T> from a given array.
                // Create<T>(T[], Int32)	
                // Creates a new Vector128<T> from a given array.
                // `Create` see below.

                // CreateScalar(Byte)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(Double)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(Int16)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(Int32)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(Int64)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(IntPtr)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(SByte)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(Single)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(UInt16)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(UInt32)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(UInt64)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                // CreateScalar(UIntPtr)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements initialized to zero.
                WriteLine(writer, indent, "CreateScalar(9):\t{0}", Vector128.CreateScalar(9));

                // CreateScalarUnsafe(Byte)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(Double)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(Int16)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(Int32)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(Int64)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(IntPtr)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(SByte)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(Single)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(UInt16)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(UInt32)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(UInt64)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                // CreateScalarUnsafe(UIntPtr)	
                // Creates a new Vector128<T> instance with the first element initialized to the specified value and the remaining elements left uninitialized.
                WriteLine(writer, indent, "CreateScalarUnsafe(9):\t{0}", Vector128.CreateScalarUnsafe(9));

                // Divide<T>(Vector128<T>, Vector128<T>)	
                // Divides writero vectors to compute their quotient.
                WriteLine(writer, indent, "Divide(Vector128s<Single>.Demo, Vector128s<Single>.V2):\t{0}", Vector128.Divide(Vector128s<Single>.Demo, Vector128s<Single>.V2));
                WriteLine(writer, indent, "Divide(Vector128s<Double>.Demo, Vector128s<Double>.V2):\t{0}", Vector128.Divide(Vector128s<Double>.Demo, Vector128s<Double>.V2));
                WriteLine(writer, indent, "Divide(Vector128s<SByte>.Demo, Vector128s<SByte>.V2):\t{0}", Vector128.Divide(Vector128s<SByte>.Demo, Vector128s<SByte>.V2));
                WriteLine(writer, indent, "Divide(Vector128s<Byte>.Demo, Vector128s<Byte>.V2):\t{0}", Vector128.Divide(Vector128s<Byte>.Demo, Vector128s<Byte>.V2));
                WriteLine(writer, indent, "Divide(Vector128s<Int16>.Demo, Vector128s<Int16>.V2):\t{0}", Vector128.Divide(Vector128s<Int16>.Demo, Vector128s<Int16>.V2));
                WriteLine(writer, indent, "Divide(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2):\t{0}", Vector128.Divide(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2));
                WriteLine(writer, indent, "Divide(Vector128s<Int32>.Demo, Vector128s<Int32>.V2):\t{0}", Vector128.Divide(Vector128s<Int32>.Demo, Vector128s<Int32>.V2));
                WriteLine(writer, indent, "Divide(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2):\t{0}", Vector128.Divide(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2));
                WriteLine(writer, indent, "Divide(Vector128s<Int64>.Demo, Vector128s<Int64>.V2):\t{0}", Vector128.Divide(Vector128s<Int64>.Demo, Vector128s<Int64>.V2));
                WriteLine(writer, indent, "Divide(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2):\t{0}", Vector128.Divide(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2));

                // Dot<T>(Vector128<T>, Vector128<T>)	
                // Computes the dot product of writero vectors.
                WriteLine(writer, indent, "Dot(Vector128s<Int32>.V1, Vector128s<Int32>.V2):\t{0}", Vector128.Dot(Vector128s<Int32>.V1, Vector128s<Int32>.V2)); // 1*2*Vector128<T>.Count
                WriteLine(writer, indent, "Dot(Vector128s<Single>.Demo, Vector128s<Single>.V2):\t{0}", Vector128.Dot(Vector128s<Single>.Demo, Vector128s<Single>.V2));
                WriteLine(writer, indent, "Dot(Vector128s<Double>.Demo, Vector128s<Double>.V2):\t{0}", Vector128.Dot(Vector128s<Double>.Demo, Vector128s<Double>.V2));
                WriteLine(writer, indent, "Dot(Vector128s<SByte>.Demo, Vector128s<SByte>.V2):\t{0}", Vector128.Dot(Vector128s<SByte>.Demo, Vector128s<SByte>.V2));
                WriteLine(writer, indent, "Dot(Vector128s<Byte>.Demo, Vector128s<Byte>.V2):\t{0}", Vector128.Dot(Vector128s<Byte>.Demo, Vector128s<Byte>.V2));
                WriteLine(writer, indent, "Dot(Vector128s<Int16>.Demo, Vector128s<Int16>.V2):\t{0}", Vector128.Dot(Vector128s<Int16>.Demo, Vector128s<Int16>.V2));
                WriteLine(writer, indent, "Dot(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2):\t{0}", Vector128.Dot(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2));
                WriteLine(writer, indent, "Dot(Vector128s<Int32>.Demo, Vector128s<Int32>.V2):\t{0}", Vector128.Dot(Vector128s<Int32>.Demo, Vector128s<Int32>.V2));
                WriteLine(writer, indent, "Dot(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2):\t{0}", Vector128.Dot(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2));
                WriteLine(writer, indent, "Dot(Vector128s<Int64>.Demo, Vector128s<Int64>.V2):\t{0}", Vector128.Dot(Vector128s<Int64>.Demo, Vector128s<Int64>.V2));
                WriteLine(writer, indent, "Dot(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2):\t{0}", Vector128.Dot(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2));

                // Equals<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if they are equal on a per-element basis.
                WriteLine(writer, indent, "Equals(Vector128s<Single>.Demo, Vector128s<Single>.MinValue):\t{0}", Vector128.Equals(Vector128s<Single>.Demo, Vector128s<Single>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<Double>.Demo, Vector128s<Double>.MinValue):\t{0}", Vector128.Equals(Vector128s<Double>.Demo, Vector128s<Double>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<SByte>.Demo, Vector128s<SByte>.MinValue):\t{0}", Vector128.Equals(Vector128s<SByte>.Demo, Vector128s<SByte>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<Byte>.Demo, Vector128s<Byte>.MinValue):\t{0}", Vector128.Equals(Vector128s<Byte>.Demo, Vector128s<Byte>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<Int16>.Demo, Vector128s<Int16>.MinValue):\t{0}", Vector128.Equals(Vector128s<Int16>.Demo, Vector128s<Int16>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<UInt16>.Demo, Vector128s<UInt16>.MinValue):\t{0}", Vector128.Equals(Vector128s<UInt16>.Demo, Vector128s<UInt16>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<Int32>.Demo, Vector128s<Int32>.MinValue):\t{0}", Vector128.Equals(Vector128s<Int32>.Demo, Vector128s<Int32>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<UInt32>.Demo, Vector128s<UInt32>.MinValue):\t{0}", Vector128.Equals(Vector128s<UInt32>.Demo, Vector128s<UInt32>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<Int64>.Demo, Vector128s<Int64>.MinValue):\t{0}", Vector128.Equals(Vector128s<Int64>.Demo, Vector128s<Int64>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<UInt64>.Demo, Vector128s<UInt64>.MinValue):\t{0}", Vector128.Equals(Vector128s<UInt64>.Demo, Vector128s<UInt64>.MinValue));
                WriteLine(writer, indent, "Equals(Vector128s<Single>.Demo, Vector128s<Single>.V0):\t{0}", Vector128.Equals(Vector128s<Single>.Demo, Vector128s<Single>.V0));
                WriteLine(writer, indent, "Equals(Vector128s<Double>.Demo, Vector128s<Double>.V0):\t{0}", Vector128.Equals(Vector128s<Double>.Demo, Vector128s<Double>.V0));
                WriteLine(writer, indent, "Equals(Vector128s<SByte>.Demo, Vector128s<SByte>.V0):\t{0}", Vector128.Equals(Vector128s<SByte>.Demo, Vector128s<SByte>.V0));
                WriteLine(writer, indent, "Equals(Vector128s<Byte>.Demo, Vector128s<Byte>.V0):\t{0}", Vector128.Equals(Vector128s<Byte>.Demo, Vector128s<Byte>.V0));
                WriteLine(writer, indent, "Equals(Vector128s<Int16>.Demo, Vector128s<Int16>.V0):\t{0}", Vector128.Equals(Vector128s<Int16>.Demo, Vector128s<Int16>.V0));
                WriteLine(writer, indent, "Equals(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0):\t{0}", Vector128.Equals(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0));
                WriteLine(writer, indent, "Equals(Vector128s<Int32>.Demo, Vector128s<Int32>.V0):\t{0}", Vector128.Equals(Vector128s<Int32>.Demo, Vector128s<Int32>.V0));
                WriteLine(writer, indent, "Equals(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0):\t{0}", Vector128.Equals(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0));
                WriteLine(writer, indent, "Equals(Vector128s<Int64>.Demo, Vector128s<Int64>.V0):\t{0}", Vector128.Equals(Vector128s<Int64>.Demo, Vector128s<Int64>.V0));
                WriteLine(writer, indent, "Equals(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0):\t{0}", Vector128.Equals(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0));

                // EqualsAll<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if all elements are equal.
                WriteLine(writer, indent, "EqualsAll(Vector128s<Single>.Demo, Vector128s<Single>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<Single>.Demo, Vector128s<Single>.MinValue));
                WriteLine(writer, indent, "EqualsAll(Vector128s<Double>.Demo, Vector128s<Double>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<Double>.Demo, Vector128s<Double>.MinValue));
                WriteLine(writer, indent, "EqualsAll(Vector128s<SByte>.Demo, Vector128s<SByte>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<SByte>.Demo, Vector128s<SByte>.MinValue));
                WriteLine(writer, indent, "EqualsAll(Vector128s<Byte>.Demo, Vector128s<Byte>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<Byte>.Demo, Vector128s<Byte>.MinValue));
                WriteLine(writer, indent, "EqualsAll(Vector128s<Int16>.Demo, Vector128s<Int16>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<Int16>.Demo, Vector128s<Int16>.MinValue));
                WriteLine(writer, indent, "EqualsAll(Vector128s<UInt16>.Demo, Vector128s<UInt16>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<UInt16>.Demo, Vector128s<UInt16>.MinValue));
                WriteLine(writer, indent, "EqualsAll(Vector128s<Int32>.Demo, Vector128s<Int32>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<Int32>.Demo, Vector128s<Int32>.MinValue));
                WriteLine(writer, indent, "EqualsAll(Vector128s<UInt32>.Demo, Vector128s<UInt32>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<UInt32>.Demo, Vector128s<UInt32>.MinValue));
                WriteLine(writer, indent, "EqualsAll(Vector128s<Int64>.Demo, Vector128s<Int64>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<Int64>.Demo, Vector128s<Int64>.MinValue));
                WriteLine(writer, indent, "EqualsAll(Vector128s<UInt64>.Demo, Vector128s<UInt64>.MinValue):\t{0}", Vector128.EqualsAll(Vector128s<UInt64>.Demo, Vector128s<UInt64>.MinValue));

                // EqualsAny<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if any elements are equal.
                WriteLine(writer, indent, "EqualsAny(Vector128s<Single>.Demo, Vector128s<Single>.V0):\t{0}", Vector128.EqualsAny(Vector128s<Single>.Demo, Vector128s<Single>.V0));
                WriteLine(writer, indent, "EqualsAny(Vector128s<Double>.Demo, Vector128s<Double>.V0):\t{0}", Vector128.EqualsAny(Vector128s<Double>.Demo, Vector128s<Double>.V0));
                WriteLine(writer, indent, "EqualsAny(Vector128s<SByte>.Demo, Vector128s<SByte>.V0):\t{0}", Vector128.EqualsAny(Vector128s<SByte>.Demo, Vector128s<SByte>.V0));
                WriteLine(writer, indent, "EqualsAny(Vector128s<Byte>.Demo, Vector128s<Byte>.V0):\t{0}", Vector128.EqualsAny(Vector128s<Byte>.Demo, Vector128s<Byte>.V0));
                WriteLine(writer, indent, "EqualsAny(Vector128s<Int16>.Demo, Vector128s<Int16>.V0):\t{0}", Vector128.EqualsAny(Vector128s<Int16>.Demo, Vector128s<Int16>.V0));
                WriteLine(writer, indent, "EqualsAny(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0):\t{0}", Vector128.EqualsAny(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0));
                WriteLine(writer, indent, "EqualsAny(Vector128s<Int32>.Demo, Vector128s<Int32>.V0):\t{0}", Vector128.EqualsAny(Vector128s<Int32>.Demo, Vector128s<Int32>.V0));
                WriteLine(writer, indent, "EqualsAny(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0):\t{0}", Vector128.EqualsAny(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0));
                WriteLine(writer, indent, "EqualsAny(Vector128s<Int64>.Demo, Vector128s<Int64>.V0):\t{0}", Vector128.EqualsAny(Vector128s<Int64>.Demo, Vector128s<Int64>.V0));
                WriteLine(writer, indent, "EqualsAny(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0):\t{0}", Vector128.EqualsAny(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0));

                // ExtractMostSignificantBits<T>(Vector128<T>)	
                // Extracts the most significant bit from each element in a vector.
                Tip.ExtractMostSignificantBits<Single>();
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<Single>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<Double>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<SByte>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<SByte>.Demo));
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<Byte>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<Byte>.Demo));
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<Int16>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<Int16>.Demo));
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<UInt16>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<UInt16>.Demo));
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<Int32>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<UInt32>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<Int64>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<Int64>.Demo));
                Tip.ExtractMostSignificantBits<UInt64>();
                WriteLine(writer, indent, "ExtractMostSignificantBits(Vector128s<UInt64>.Demo):\t{0}", Vector128.ExtractMostSignificantBits(Vector128s<UInt64>.Demo));

                // Floor(Vector128<Double>)	
                // Computes the floor of each element in a vector.
                // Floor(Vector128<Single>)	
                // Computes the floor of each element in a vector.
                Tip.Floor<Single>();
                WriteLine(writer, indent, "Floor(Vector128s<Single>.Demo):\t{0}", Vector128.Floor(Vector128s<Single>.Demo));
                Tip.Floor<Double>();
                WriteLine(writer, indent, "Floor(Vector128s<Double>.Demo):\t{0}", Vector128.Floor(Vector128s<Double>.Demo));

                // GetElement<T>(Vector128<T>, Int32)	
                // Gets the element at the specified index.
                // Ignore.
                if (true) {
                    shift = 1;
                    WriteLine(writer, indent, "shift:\t{0}", shift);
                    WriteLine(writer, indent, "GetElement(Vector128s<Single>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<Single>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<Double>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<Double>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<SByte>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<SByte>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<Byte>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<Byte>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<Int16>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<Int16>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<UInt16>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<UInt16>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<Int32>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<Int32>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<UInt32>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<UInt32>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<Int64>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<Int64>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<UInt64>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<UInt64>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<IntPtr>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<IntPtr>.Demo, shift));
                    WriteLine(writer, indent, "GetElement(Vector128s<UIntPtr>.Demo, shift):\t{0}", Vector128.GetElement(Vector128s<UIntPtr>.Demo, shift));
                }

                // GetLower<T>(Vector128<T>)	
                // Gets the value of the lower 64 bits as a new Vector64<T>.
                WriteLine(writer, indent, "GetLower(Vector128s<Single>.Demo):\t{0}", Vector128.GetLower(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "GetLower(Vector128s<Double>.Demo):\t{0}", Vector128.GetLower(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "GetLower(Vector128s<SByte>.Demo):\t{0}", Vector128.GetLower(Vector128s<SByte>.Demo));
                WriteLine(writer, indent, "GetLower(Vector128s<Byte>.Demo):\t{0}", Vector128.GetLower(Vector128s<Byte>.Demo));
                WriteLine(writer, indent, "GetLower(Vector128s<Int16>.Demo):\t{0}", Vector128.GetLower(Vector128s<Int16>.Demo));
                WriteLine(writer, indent, "GetLower(Vector128s<UInt16>.Demo):\t{0}", Vector128.GetLower(Vector128s<UInt16>.Demo));
                WriteLine(writer, indent, "GetLower(Vector128s<Int32>.Demo):\t{0}", Vector128.GetLower(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "GetLower(Vector128s<UInt32>.Demo):\t{0}", Vector128.GetLower(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "GetLower(Vector128s<Int64>.Demo):\t{0}", Vector128.GetLower(Vector128s<Int64>.Demo));
                WriteLine(writer, indent, "GetLower(Vector128s<UInt64>.Demo):\t{0}", Vector128.GetLower(Vector128s<UInt64>.Demo));

                // GetUpper<T>(Vector128<T>)	
                // Gets the value of the upper 64 bits as a new Vector64<T>.
                WriteLine(writer, indent, "GetUpper(Vector128s<Single>.Demo):\t{0}", Vector128.GetUpper(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "GetUpper(Vector128s<Double>.Demo):\t{0}", Vector128.GetUpper(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "GetUpper(Vector128s<SByte>.Demo):\t{0}", Vector128.GetUpper(Vector128s<SByte>.Demo));
                WriteLine(writer, indent, "GetUpper(Vector128s<Byte>.Demo):\t{0}", Vector128.GetUpper(Vector128s<Byte>.Demo));
                WriteLine(writer, indent, "GetUpper(Vector128s<Int16>.Demo):\t{0}", Vector128.GetUpper(Vector128s<Int16>.Demo));
                WriteLine(writer, indent, "GetUpper(Vector128s<UInt16>.Demo):\t{0}", Vector128.GetUpper(Vector128s<UInt16>.Demo));
                WriteLine(writer, indent, "GetUpper(Vector128s<Int32>.Demo):\t{0}", Vector128.GetUpper(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "GetUpper(Vector128s<UInt32>.Demo):\t{0}", Vector128.GetUpper(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "GetUpper(Vector128s<Int64>.Demo):\t{0}", Vector128.GetUpper(Vector128s<Int64>.Demo));
                WriteLine(writer, indent, "GetUpper(Vector128s<UInt64>.Demo):\t{0}", Vector128.GetUpper(Vector128s<UInt64>.Demo));

                // GreaterThan<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine which is greater on a per-element basis.
                WriteLine(writer, indent, "GreaterThan(Vector128s<Single>.Demo, Vector128s<Single>.V0):\t{0}", Vector128.GreaterThan(Vector128s<Single>.Demo, Vector128s<Single>.V0));
                WriteLine(writer, indent, "GreaterThan(Vector128s<Double>.Demo, Vector128s<Double>.V0):\t{0}", Vector128.GreaterThan(Vector128s<Double>.Demo, Vector128s<Double>.V0));
                WriteLine(writer, indent, "GreaterThan(Vector128s<SByte>.Demo, Vector128s<SByte>.V0):\t{0}", Vector128.GreaterThan(Vector128s<SByte>.Demo, Vector128s<SByte>.V0));
                WriteLine(writer, indent, "GreaterThan(Vector128s<Byte>.Demo, Vector128s<Byte>.V0):\t{0}", Vector128.GreaterThan(Vector128s<Byte>.Demo, Vector128s<Byte>.V0));
                WriteLine(writer, indent, "GreaterThan(Vector128s<Int16>.Demo, Vector128s<Int16>.V0):\t{0}", Vector128.GreaterThan(Vector128s<Int16>.Demo, Vector128s<Int16>.V0));
                WriteLine(writer, indent, "GreaterThan(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0):\t{0}", Vector128.GreaterThan(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0));
                WriteLine(writer, indent, "GreaterThan(Vector128s<Int32>.Demo, Vector128s<Int32>.V0):\t{0}", Vector128.GreaterThan(Vector128s<Int32>.Demo, Vector128s<Int32>.V0));
                WriteLine(writer, indent, "GreaterThan(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0):\t{0}", Vector128.GreaterThan(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0));
                WriteLine(writer, indent, "GreaterThan(Vector128s<Int64>.Demo, Vector128s<Int64>.V0):\t{0}", Vector128.GreaterThan(Vector128s<Int64>.Demo, Vector128s<Int64>.V0));
                WriteLine(writer, indent, "GreaterThan(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0):\t{0}", Vector128.GreaterThan(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0));

                // GreaterThanAll<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if all elements are greater.
                // GreaterThanAny<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if any elements are greater.

                // GreaterThanOrEqual<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine which is greater or equal on a per-element basis.
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<Single>.Demo, Vector128s<Single>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<Single>.Demo, Vector128s<Single>.V0));
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<Double>.Demo, Vector128s<Double>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<Double>.Demo, Vector128s<Double>.V0));
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<SByte>.Demo, Vector128s<SByte>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<SByte>.Demo, Vector128s<SByte>.V0));
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<Byte>.Demo, Vector128s<Byte>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<Byte>.Demo, Vector128s<Byte>.V0));
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<Int16>.Demo, Vector128s<Int16>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<Int16>.Demo, Vector128s<Int16>.V0));
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0));
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<Int32>.Demo, Vector128s<Int32>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<Int32>.Demo, Vector128s<Int32>.V0));
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0));
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<Int64>.Demo, Vector128s<Int64>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<Int64>.Demo, Vector128s<Int64>.V0));
                WriteLine(writer, indent, "GreaterThanOrEqual(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0):\t{0}", Vector128.GreaterThanOrEqual(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0));

                // GreaterThanOrEqualAll<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if all elements are greater or equal.
                // GreaterThanOrEqualAny<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if any elements are greater or equal.

                // LessThan<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine which is less on a per-element basis.
                WriteLine(writer, indent, "LessThan(Vector128s<Single>.Demo, Vector128s<Single>.V0):\t{0}", Vector128.LessThan(Vector128s<Single>.Demo, Vector128s<Single>.V0));
                WriteLine(writer, indent, "LessThan(Vector128s<Double>.Demo, Vector128s<Double>.V0):\t{0}", Vector128.LessThan(Vector128s<Double>.Demo, Vector128s<Double>.V0));
                WriteLine(writer, indent, "LessThan(Vector128s<SByte>.Demo, Vector128s<SByte>.V0):\t{0}", Vector128.LessThan(Vector128s<SByte>.Demo, Vector128s<SByte>.V0));
                WriteLine(writer, indent, "LessThan(Vector128s<Byte>.Demo, Vector128s<Byte>.V0):\t{0}", Vector128.LessThan(Vector128s<Byte>.Demo, Vector128s<Byte>.V0));
                WriteLine(writer, indent, "LessThan(Vector128s<Int16>.Demo, Vector128s<Int16>.V0):\t{0}", Vector128.LessThan(Vector128s<Int16>.Demo, Vector128s<Int16>.V0));
                WriteLine(writer, indent, "LessThan(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0):\t{0}", Vector128.LessThan(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0));
                WriteLine(writer, indent, "LessThan(Vector128s<Int32>.Demo, Vector128s<Int32>.V0):\t{0}", Vector128.LessThan(Vector128s<Int32>.Demo, Vector128s<Int32>.V0));
                WriteLine(writer, indent, "LessThan(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0):\t{0}", Vector128.LessThan(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0));
                WriteLine(writer, indent, "LessThan(Vector128s<Int64>.Demo, Vector128s<Int64>.V0):\t{0}", Vector128.LessThan(Vector128s<Int64>.Demo, Vector128s<Int64>.V0));
                WriteLine(writer, indent, "LessThan(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0):\t{0}", Vector128.LessThan(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0));

                // LessThanAll<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if all elements are less.
                // LessThanAny<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if any elements are less.

                // LessThanOrEqual<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine which is less or equal on a per-element basis.
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<Single>.Demo, Vector128s<Single>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<Single>.Demo, Vector128s<Single>.V0));
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<Double>.Demo, Vector128s<Double>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<Double>.Demo, Vector128s<Double>.V0));
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<SByte>.Demo, Vector128s<SByte>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<SByte>.Demo, Vector128s<SByte>.V0));
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<Byte>.Demo, Vector128s<Byte>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<Byte>.Demo, Vector128s<Byte>.V0));
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<Int16>.Demo, Vector128s<Int16>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<Int16>.Demo, Vector128s<Int16>.V0));
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0));
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<Int32>.Demo, Vector128s<Int32>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<Int32>.Demo, Vector128s<Int32>.V0));
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0));
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<Int64>.Demo, Vector128s<Int64>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<Int64>.Demo, Vector128s<Int64>.V0));
                WriteLine(writer, indent, "LessThanOrEqual(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0):\t{0}", Vector128.LessThanOrEqual(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0));

                // LessThanOrEqualAll<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if all elements are less or equal.
                // LessThanOrEqualAny<T>(Vector128<T>, Vector128<T>)	
                // Compares writero vectors to determine if any elements are less or equal.

                // Load<T>(T*)	
                // Loads a vector from the given source.
                // LoadAligned<T>(T*)	
                // Loads a vector from the given aligned source.
                // LoadAlignedNonTemporal<T>(T*)	
                // Loads a vector from the given aligned source.
                // LoadUnsafe<T>(T)	
                // Loads a vector from the given source.
                // LoadUnsafe<T>(T, UIntPtr)	
                // Loads a vector from the given source and element offset.
                // Ignore.

                // Max<T>(Vector128<T>, Vector128<T>)	
                // Computes the maximum of writero vectors on a per-element basis.
                WriteLine(writer, indent, "Max(Vector128s<Single>.Demo, Vector128s<Single>.V0):\t{0}", Vector128.Max(Vector128s<Single>.Demo, Vector128s<Single>.V0));
                WriteLine(writer, indent, "Max(Vector128s<Double>.Demo, Vector128s<Double>.V0):\t{0}", Vector128.Max(Vector128s<Double>.Demo, Vector128s<Double>.V0));
                WriteLine(writer, indent, "Max(Vector128s<SByte>.Demo, Vector128s<SByte>.V0):\t{0}", Vector128.Max(Vector128s<SByte>.Demo, Vector128s<SByte>.V0));
                WriteLine(writer, indent, "Max(Vector128s<Byte>.Demo, Vector128s<Byte>.V0):\t{0}", Vector128.Max(Vector128s<Byte>.Demo, Vector128s<Byte>.V0));
                WriteLine(writer, indent, "Max(Vector128s<Int16>.Demo, Vector128s<Int16>.V0):\t{0}", Vector128.Max(Vector128s<Int16>.Demo, Vector128s<Int16>.V0));
                WriteLine(writer, indent, "Max(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0):\t{0}", Vector128.Max(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0));
                WriteLine(writer, indent, "Max(Vector128s<Int32>.Demo, Vector128s<Int32>.V0):\t{0}", Vector128.Max(Vector128s<Int32>.Demo, Vector128s<Int32>.V0));
                WriteLine(writer, indent, "Max(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0):\t{0}", Vector128.Max(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0));
                WriteLine(writer, indent, "Max(Vector128s<Int64>.Demo, Vector128s<Int64>.V0):\t{0}", Vector128.Max(Vector128s<Int64>.Demo, Vector128s<Int64>.V0));
                WriteLine(writer, indent, "Max(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0):\t{0}", Vector128.Max(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0));

                // Min<T>(Vector128<T>, Vector128<T>)	
                // Computes the minimum of writero vectors on a per-element basis.
                WriteLine(writer, indent, "Min(Vector128s<Single>.Demo, Vector128s<Single>.V0):\t{0}", Vector128.Min(Vector128s<Single>.Demo, Vector128s<Single>.V0));
                WriteLine(writer, indent, "Min(Vector128s<Double>.Demo, Vector128s<Double>.V0):\t{0}", Vector128.Min(Vector128s<Double>.Demo, Vector128s<Double>.V0));
                WriteLine(writer, indent, "Min(Vector128s<SByte>.Demo, Vector128s<SByte>.V0):\t{0}", Vector128.Min(Vector128s<SByte>.Demo, Vector128s<SByte>.V0));
                WriteLine(writer, indent, "Min(Vector128s<Byte>.Demo, Vector128s<Byte>.V0):\t{0}", Vector128.Min(Vector128s<Byte>.Demo, Vector128s<Byte>.V0));
                WriteLine(writer, indent, "Min(Vector128s<Int16>.Demo, Vector128s<Int16>.V0):\t{0}", Vector128.Min(Vector128s<Int16>.Demo, Vector128s<Int16>.V0));
                WriteLine(writer, indent, "Min(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0):\t{0}", Vector128.Min(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V0));
                WriteLine(writer, indent, "Min(Vector128s<Int32>.Demo, Vector128s<Int32>.V0):\t{0}", Vector128.Min(Vector128s<Int32>.Demo, Vector128s<Int32>.V0));
                WriteLine(writer, indent, "Min(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0):\t{0}", Vector128.Min(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V0));
                WriteLine(writer, indent, "Min(Vector128s<Int64>.Demo, Vector128s<Int64>.V0):\t{0}", Vector128.Min(Vector128s<Int64>.Demo, Vector128s<Int64>.V0));
                WriteLine(writer, indent, "Min(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0):\t{0}", Vector128.Min(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V0));
                // limit to [0, 255].
                WriteLine(writer, indent, "Vector128.Min(Vector128.Max(Vector128s<Single>.Demo, Vector128s<Single>.V0), Vector128s<Single>.VMaxByte)):\t{0}", Vector128.Min(Vector128.Max(Vector128s<Single>.Demo, Vector128s<Single>.V0), Vector128s<Single>.VMaxByte));

                // Multiply<T>(T, Vector128<T>)	
                // Multiplies a vector by a scalar to compute their product.
                // Multiply<T>(Vector128<T>, T)	
                // Multiplies a vector by a scalar to compute their product.
                // Multiply<T>(Vector128<T>, Vector128<T>)	
                // Multiplies writero vectors to compute their element-wise product.
                WriteLine(writer, indent, "Multiply(Vector128s<Single>.Demo, Vector128s<Single>.V2):\t{0}", Vector128.Multiply(Vector128s<Single>.Demo, Vector128s<Single>.V2));
                WriteLine(writer, indent, "Multiply(Vector128s<Double>.Demo, Vector128s<Double>.V2):\t{0}", Vector128.Multiply(Vector128s<Double>.Demo, Vector128s<Double>.V2));
                WriteLine(writer, indent, "Multiply(Vector128s<SByte>.Demo, Vector128s<SByte>.V2):\t{0}", Vector128.Multiply(Vector128s<SByte>.Demo, Vector128s<SByte>.V2));
                WriteLine(writer, indent, "Multiply(Vector128s<Byte>.Demo, Vector128s<Byte>.V2):\t{0}", Vector128.Multiply(Vector128s<Byte>.Demo, Vector128s<Byte>.V2));
                WriteLine(writer, indent, "Multiply(Vector128s<Int16>.Demo, Vector128s<Int16>.V2):\t{0}", Vector128.Multiply(Vector128s<Int16>.Demo, Vector128s<Int16>.V2));
                WriteLine(writer, indent, "Multiply(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2):\t{0}", Vector128.Multiply(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2));
                WriteLine(writer, indent, "Multiply(Vector128s<Int32>.Demo, Vector128s<Int32>.V2):\t{0}", Vector128.Multiply(Vector128s<Int32>.Demo, Vector128s<Int32>.V2));
                WriteLine(writer, indent, "Multiply(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2):\t{0}", Vector128.Multiply(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2));
                WriteLine(writer, indent, "Multiply(Vector128s<Int64>.Demo, Vector128s<Int64>.V2):\t{0}", Vector128.Multiply(Vector128s<Int64>.Demo, Vector128s<Int64>.V2));
                WriteLine(writer, indent, "Multiply(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2):\t{0}", Vector128.Multiply(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2));

                // Narrow(Vector128<Double>, Vector128<Double>)	
                // Narrows writero Vector128<T> instances into one Vector128<T>.
                // Narrow(Vector128<Int16>, Vector128<Int16>)	
                // Narrows writero Vector128<T> instances into one Vector128<T>.
                // Narrow(Vector128<Int32>, Vector128<Int32>)	
                // Narrows writero Vector128<T> instances into one Vector128<T>.
                // Narrow(Vector128<Int64>, Vector128<Int64>)	
                // Narrows writero Vector128<T> instances into one Vector128<T>.
                // Narrow(Vector128<UInt16>, Vector128<UInt16>)	
                // Narrows writero Vector128<T> instances into one Vector128<T>.
                // Narrow(Vector128<UInt32>, Vector128<UInt32>)	
                // Narrows writero Vector128<T> instances into one Vector128<T>.
                // Narrow(Vector128<UInt64>, Vector128<UInt64>)	
                // Narrows writero Vector128<T> instances into one Vector128<T>.
                Tip.Narrow<Single>();
                WriteLine(writer, indent, "Narrow(Vector128s<Double>.Demo, Vector128s<Double>.SerialNegative):\t{0}", Vector128.Narrow(Vector128s<Double>.Demo, Vector128s<Double>.SerialNegative));
                WriteLine(writer, indent, "Narrow(Vector128s<Int16>.Demo, Vector128s<Int16>.SerialNegative):\t{0}", Vector128.Narrow(Vector128s<Int16>.Demo, Vector128s<Int16>.SerialNegative));
                WriteLine(writer, indent, "Narrow(Vector128s<Int32>.Demo, Vector128s<Int32>.SerialNegative):\t{0}", Vector128.Narrow(Vector128s<Int32>.Demo, Vector128s<Int32>.SerialNegative));
                WriteLine(writer, indent, "Narrow(Vector128s<Int64>.Demo, Vector128s<Int64>.SerialNegative):\t{0}", Vector128.Narrow(Vector128s<Int64>.Demo, Vector128s<Int64>.SerialNegative));
                WriteLine(writer, indent, "Narrow(Vector128s<UInt16>.Demo, Vector128s<UInt16>.SerialNegative):\t{0}", Vector128.Narrow(Vector128s<UInt16>.Demo, Vector128s<UInt16>.SerialNegative));
                WriteLine(writer, indent, "Narrow(Vector128s<UInt32>.Demo, Vector128s<UInt32>.SerialNegative):\t{0}", Vector128.Narrow(Vector128s<UInt32>.Demo, Vector128s<UInt32>.SerialNegative));
                Tip.Narrow<UInt64>();
                WriteLine(writer, indent, "Narrow(Vector128s<UInt64>.Demo, Vector128s<UInt64>.SerialNegative):\t{0}", Vector128.Narrow(Vector128s<UInt64>.Demo, Vector128s<UInt64>.SerialNegative));

                // Negate<T>(Vector128<T>)	
                // Negates a vector.
                WriteLine(writer, indent, "Negate(Vector128s<Single>.Demo):\t{0}", Vector128.Negate(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "Negate(Vector128s<Double>.Demo):\t{0}", Vector128.Negate(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "Negate(Vector128s<SByte>.Demo):\t{0}", Vector128.Negate(Vector128s<SByte>.Demo));
                WriteLine(writer, indent, "Negate(Vector128s<Byte>.Demo):\t{0}", Vector128.Negate(Vector128s<Byte>.Demo));
                WriteLine(writer, indent, "Negate(Vector128s<Int16>.Demo):\t{0}", Vector128.Negate(Vector128s<Int16>.Demo));
                WriteLine(writer, indent, "Negate(Vector128s<UInt16>.Demo):\t{0}", Vector128.Negate(Vector128s<UInt16>.Demo));
                WriteLine(writer, indent, "Negate(Vector128s<Int32>.Demo):\t{0}", Vector128.Negate(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "Negate(Vector128s<UInt32>.Demo):\t{0}", Vector128.Negate(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "Negate(Vector128s<Int64>.Demo):\t{0}", Vector128.Negate(Vector128s<Int64>.Demo));
                WriteLine(writer, indent, "Negate(Vector128s<UInt64>.Demo):\t{0}", Vector128.Negate(Vector128s<UInt64>.Demo));

                // OnesComplement<T>(Vector128<T>)	
                // Computes the ones-complement of a vector.
                WriteLine(writer, indent, "OnesComplement(Vector128s<Single>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "OnesComplement(Vector128s<Double>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "OnesComplement(Vector128s<SByte>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<SByte>.Demo));
                WriteLine(writer, indent, "OnesComplement(Vector128s<Byte>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<Byte>.Demo));
                WriteLine(writer, indent, "OnesComplement(Vector128s<Int16>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<Int16>.Demo));
                WriteLine(writer, indent, "OnesComplement(Vector128s<UInt16>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<UInt16>.Demo));
                WriteLine(writer, indent, "OnesComplement(Vector128s<Int32>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "OnesComplement(Vector128s<UInt32>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "OnesComplement(Vector128s<Int64>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<Int64>.Demo));
                WriteLine(writer, indent, "OnesComplement(Vector128s<UInt64>.Demo):\t{0}", Vector128.OnesComplement(Vector128s<UInt64>.Demo));

                // ShiftLeft(Vector128<Byte>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                // ShiftLeft(Vector128<Int16>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                // ShiftLeft(Vector128<Int32>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                // ShiftLeft(Vector128<Int64>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                // ShiftLeft(Vector128<IntPtr>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                // ShiftLeft(Vector128<SByte>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                // ShiftLeft(Vector128<UInt16>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                // ShiftLeft(Vector128<UInt32>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                // ShiftLeft(Vector128<UInt64>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                // ShiftLeft(Vector128<UIntPtr>, Int32)	
                // Shifts each element of a vector left by the specified amount.
                shift = 4;
                WriteLine(writer, indent, "shift:\t{0}", shift);
                Tip.ShiftLeft<SByte>();
                WriteLine(writer, indent, "ShiftLeft(Vector128s<SByte>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<SByte>.Demo, shift));
                WriteLine(writer, indent, "ShiftLeft(Vector128s<Byte>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<Byte>.Demo, shift));
                WriteLine(writer, indent, "ShiftLeft(Vector128s<Int16>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<Int16>.Demo, shift));
                WriteLine(writer, indent, "ShiftLeft(Vector128s<UInt16>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<UInt16>.Demo, shift));
                WriteLine(writer, indent, "ShiftLeft(Vector128s<Int32>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<Int32>.Demo, shift));
                WriteLine(writer, indent, "ShiftLeft(Vector128s<UInt32>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<UInt32>.Demo, shift));
                WriteLine(writer, indent, "ShiftLeft(Vector128s<Int64>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<Int64>.Demo, shift));
                WriteLine(writer, indent, "ShiftLeft(Vector128s<UInt64>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<UInt64>.Demo, shift));
                WriteLine(writer, indent, "ShiftLeft(Vector128s<IntPtr>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<IntPtr>.Demo, shift));
                Tip.ShiftLeft<UIntPtr>();
                WriteLine(writer, indent, "ShiftLeft(Vector128s<UIntPtr>.Demo, shift):\t{0}", Vector128.ShiftLeft(Vector128s<UIntPtr>.Demo, shift));

                // ShiftRightArithmetic(Vector128<Int16>, Int32)	
                // Shifts (signed) each element of a vector right by the specified amount.
                // ShiftRightArithmetic(Vector128<Int32>, Int32)	
                // Shifts (signed) each element of a vector right by the specified amount.
                // ShiftRightArithmetic(Vector128<Int64>, Int32)	
                // Shifts (signed) each element of a vector right by the specified amount.
                // ShiftRightArithmetic(Vector128<IntPtr>, Int32)	
                // Shifts (signed) each element of a vector right by the specified amount.
                // ShiftRightArithmetic(Vector128<SByte>, Int32)	
                // Shifts (signed) each element of a vector right by the specified amount.
                Tip.ShiftRightArithmetic<SByte>();
                WriteLine(writer, indent, "ShiftRightArithmetic(Vector128s<SByte>.Demo, shift):\t{0}", Vector128.ShiftRightArithmetic(Vector128s<SByte>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightArithmetic(Vector128s<Int16>.Demo, shift):\t{0}", Vector128.ShiftRightArithmetic(Vector128s<Int16>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightArithmetic(Vector128s<Int32>.Demo, shift):\t{0}", Vector128.ShiftRightArithmetic(Vector128s<Int32>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightArithmetic(Vector128s<Int64>.Demo, shift):\t{0}", Vector128.ShiftRightArithmetic(Vector128s<Int64>.Demo, shift));
                Tip.ShiftRightArithmetic<IntPtr>();
                WriteLine(writer, indent, "ShiftRightArithmetic(Vector128s<IntPtr>.Demo, shift):\t{0}", Vector128.ShiftRightArithmetic(Vector128s<IntPtr>.Demo, shift));

                // ShiftRightLogical(Vector128<Byte>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                // ShiftRightLogical(Vector128<Int16>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                // ShiftRightLogical(Vector128<Int32>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                // ShiftRightLogical(Vector128<Int64>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                // ShiftRightLogical(Vector128<IntPtr>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                // ShiftRightLogical(Vector128<SByte>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                // ShiftRightLogical(Vector128<UInt16>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                // ShiftRightLogical(Vector128<UInt32>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                // ShiftRightLogical(Vector128<UInt64>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                // ShiftRightLogical(Vector128<UIntPtr>, Int32)	
                // Shifts (unsigned) each element of a vector right by the specified amount.
                Tip.ShiftRightLogical<SByte>();
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<SByte>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<SByte>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<Byte>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<Byte>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<Int16>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<Int16>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<UInt16>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<UInt16>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<Int32>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<Int32>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<UInt32>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<UInt32>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<Int64>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<Int64>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<UInt64>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<UInt64>.Demo, shift));
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<IntPtr>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<IntPtr>.Demo, shift));
                Tip.ShiftRightLogical<UIntPtr>();
                WriteLine(writer, indent, "ShiftRightLogical(Vector128s<UIntPtr>.Demo, shift):\t{0}", Vector128.ShiftRightLogical(Vector128s<UIntPtr>.Demo, shift));

                // Shuffle(Vector128<Byte>, Vector128<Byte>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                // Shuffle(Vector128<Double>, Vector128<Int64>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                // Shuffle(Vector128<Int16>, Vector128<Int16>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                // Shuffle(Vector128<Int32>, Vector128<Int32>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                // Shuffle(Vector128<Int64>, Vector128<Int64>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                // Shuffle(Vector128<SByte>, Vector128<SByte>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                // Shuffle(Vector128<Single>, Vector128<Int32>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                // Shuffle(Vector128<UInt16>, Vector128<UInt16>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                // Shuffle(Vector128<UInt32>, Vector128<UInt32>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                // Shuffle(Vector128<UInt64>, Vector128<UInt64>)	
                // Creates a new vector by selecting values from an input vector using a set of indices.
                Tip.Shuffle<Single>();
                WriteLine(writer, indent, "Shuffle(Vector128s<Single>.Demo, Vector128s<Int32>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<Single>.Demo, Vector128s<Int32>.SerialDesc));
                WriteLine(writer, indent, "Shuffle(Vector128s<Double>.Demo, Vector128s<Int64>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<Double>.Demo, Vector128s<Int64>.SerialDesc));
                WriteLine(writer, indent, "Shuffle(Vector128s<SByte>.Demo, Vector128s<SByte>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<SByte>.Demo, Vector128s<SByte>.SerialDesc));
                WriteLine(writer, indent, "Shuffle(Vector128s<Byte>.Demo, Vector128s<Byte>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<Byte>.Demo, Vector128s<Byte>.SerialDesc));
                WriteLine(writer, indent, "Shuffle(Vector128s<Int16>.Demo, Vector128s<Int16>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<Int16>.Demo, Vector128s<Int16>.SerialDesc));
                WriteLine(writer, indent, "Shuffle(Vector128s<UInt16>.Demo, Vector128s<UInt16>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<UInt16>.Demo, Vector128s<UInt16>.SerialDesc));
                WriteLine(writer, indent, "Shuffle(Vector128s<Int32>.Demo, Vector128s<Int32>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<Int32>.Demo, Vector128s<Int32>.SerialDesc));
                WriteLine(writer, indent, "Shuffle(Vector128s<UInt32>.Demo, Vector128s<UInt32>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<UInt32>.Demo, Vector128s<UInt32>.SerialDesc));
                WriteLine(writer, indent, "Shuffle(Vector128s<Int64>.Demo, Vector128s<Int64>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<Int64>.Demo, Vector128s<Int64>.SerialDesc));
                Tip.Shuffle<UInt64>();
                WriteLine(writer, indent, "Shuffle(Vector128s<UInt64>.Demo, Vector128s<UInt64>.SerialDesc):\t{0}", Vector128.Shuffle(Vector128s<UInt64>.Demo, Vector128s<UInt64>.SerialDesc));

                // Sqrt<T>(Vector128<T>)	
                // Computes the square root of a vector on a per-element basis.
                WriteLine(writer, indent, "Sqrt(Vector128s<Single>.Demo):\t{0}", Vector128.Sqrt(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "Sqrt(Vector128s<Double>.Demo):\t{0}", Vector128.Sqrt(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "Sqrt(Vector128s<SByte>.Demo):\t{0}", Vector128.Sqrt(Vector128s<SByte>.Demo));
                WriteLine(writer, indent, "Sqrt(Vector128s<Byte>.Demo):\t{0}", Vector128.Sqrt(Vector128s<Byte>.Demo));
                WriteLine(writer, indent, "Sqrt(Vector128s<Int16>.Demo):\t{0}", Vector128.Sqrt(Vector128s<Int16>.Demo));
                WriteLine(writer, indent, "Sqrt(Vector128s<UInt16>.Demo):\t{0}", Vector128.Sqrt(Vector128s<UInt16>.Demo));
                WriteLine(writer, indent, "Sqrt(Vector128s<Int32>.Demo):\t{0}", Vector128.Sqrt(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "Sqrt(Vector128s<UInt32>.Demo):\t{0}", Vector128.Sqrt(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "Sqrt(Vector128s<Int64>.Demo):\t{0}", Vector128.Sqrt(Vector128s<Int64>.Demo));
                WriteLine(writer, indent, "Sqrt(Vector128s<UInt64>.Demo):\t{0}", Vector128.Sqrt(Vector128s<UInt64>.Demo));

                // Store<T>(Vector128<T>, T*)	
                // Stores a vector at the given destination.
                // StoreAligned<T>(Vector128<T>, T*)	
                // Stores a vector at the given aligned destination.
                // StoreAlignedNonTemporal<T>(Vector128<T>, T*)	
                // Stores a vector at the given aligned destination.
                // StoreUnsafe<T>(Vector128<T>, T)	
                // Stores a vector at the given destination.
                // StoreUnsafe<T>(Vector128<T>, T, UIntPtr)	
                // Stores a vector at the given destination.
                // Ignore.

                // Subtract<T>(Vector128<T>, Vector128<T>)	
                // Subtracts writero vectors to compute their difference.
                WriteLine(writer, indent, "Subtract(Vector128s<Single>.Demo, Vector128s<Single>.V2):\t{0}", Vector128.Subtract(Vector128s<Single>.Demo, Vector128s<Single>.V2));
                WriteLine(writer, indent, "Subtract(Vector128s<Double>.Demo, Vector128s<Double>.V2):\t{0}", Vector128.Subtract(Vector128s<Double>.Demo, Vector128s<Double>.V2));
                WriteLine(writer, indent, "Subtract(Vector128s<SByte>.Demo, Vector128s<SByte>.V2):\t{0}", Vector128.Subtract(Vector128s<SByte>.Demo, Vector128s<SByte>.V2));
                WriteLine(writer, indent, "Subtract(Vector128s<Byte>.Demo, Vector128s<Byte>.V2):\t{0}", Vector128.Subtract(Vector128s<Byte>.Demo, Vector128s<Byte>.V2));
                WriteLine(writer, indent, "Subtract(Vector128s<Int16>.Demo, Vector128s<Int16>.V2):\t{0}", Vector128.Subtract(Vector128s<Int16>.Demo, Vector128s<Int16>.V2));
                WriteLine(writer, indent, "Subtract(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2):\t{0}", Vector128.Subtract(Vector128s<UInt16>.Demo, Vector128s<UInt16>.V2));
                WriteLine(writer, indent, "Subtract(Vector128s<Int32>.Demo, Vector128s<Int32>.V2):\t{0}", Vector128.Subtract(Vector128s<Int32>.Demo, Vector128s<Int32>.V2));
                WriteLine(writer, indent, "Subtract(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2):\t{0}", Vector128.Subtract(Vector128s<UInt32>.Demo, Vector128s<UInt32>.V2));
                WriteLine(writer, indent, "Subtract(Vector128s<Int64>.Demo, Vector128s<Int64>.V2):\t{0}", Vector128.Subtract(Vector128s<Int64>.Demo, Vector128s<Int64>.V2));
                WriteLine(writer, indent, "Subtract(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2):\t{0}", Vector128.Subtract(Vector128s<UInt64>.Demo, Vector128s<UInt64>.V2));

                // Sum<T>(Vector128<T>)	
                // Computes the sum of all elements in a vector.
                Tip.Sum<Single>();
                WriteLine(writer, indent, "Sum(Vector128s<Single>.Demo):\t{0}", Vector128.Sum(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "Sum(Vector128s<Double>.Demo):\t{0}", Vector128.Sum(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "Sum(Vector128s<SByte>.Demo):\t{0}", Vector128.Sum(Vector128s<SByte>.Demo));
                WriteLine(writer, indent, "Sum(Vector128s<Byte>.Demo):\t{0}", Vector128.Sum(Vector128s<Byte>.Demo));
                WriteLine(writer, indent, "Sum(Vector128s<Int16>.Demo):\t{0}", Vector128.Sum(Vector128s<Int16>.Demo));
                WriteLine(writer, indent, "Sum(Vector128s<UInt16>.Demo):\t{0}", Vector128.Sum(Vector128s<UInt16>.Demo));
                WriteLine(writer, indent, "Sum(Vector128s<Int32>.Demo):\t{0}", Vector128.Sum(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "Sum(Vector128s<UInt32>.Demo):\t{0}", Vector128.Sum(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "Sum(Vector128s<Int64>.Demo):\t{0}", Vector128.Sum(Vector128s<Int64>.Demo));
                Tip.Sum<Single>();
                WriteLine(writer, indent, "Sum(Vector128s<UInt64>.Demo):\t{0}", Vector128.Sum(Vector128s<UInt64>.Demo));

                // ToScalar<T>(Vector128<T>)	
                // Converts the given vector to a scalar containing the value of the first element.
                WriteLine(writer, indent, "ToScalar(Vector128s<Single>.Demo):\t{0}", Vector128.ToScalar(Vector128s<Single>.Demo));
                WriteLine(writer, indent, "ToScalar(Vector128s<Double>.Demo):\t{0}", Vector128.ToScalar(Vector128s<Double>.Demo));
                WriteLine(writer, indent, "ToScalar(Vector128s<SByte>.Demo):\t{0}", Vector128.ToScalar(Vector128s<SByte>.Demo));
                WriteLine(writer, indent, "ToScalar(Vector128s<Byte>.Demo):\t{0}", Vector128.ToScalar(Vector128s<Byte>.Demo));
                WriteLine(writer, indent, "ToScalar(Vector128s<Int16>.Demo):\t{0}", Vector128.ToScalar(Vector128s<Int16>.Demo));
                WriteLine(writer, indent, "ToScalar(Vector128s<UInt16>.Demo):\t{0}", Vector128.ToScalar(Vector128s<UInt16>.Demo));
                WriteLine(writer, indent, "ToScalar(Vector128s<Int32>.Demo):\t{0}", Vector128.ToScalar(Vector128s<Int32>.Demo));
                WriteLine(writer, indent, "ToScalar(Vector128s<UInt32>.Demo):\t{0}", Vector128.ToScalar(Vector128s<UInt32>.Demo));
                WriteLine(writer, indent, "ToScalar(Vector128s<Int64>.Demo):\t{0}", Vector128.ToScalar(Vector128s<Int64>.Demo));
                WriteLine(writer, indent, "ToScalar(Vector128s<UInt64>.Demo):\t{0}", Vector128.ToScalar(Vector128s<UInt64>.Demo));

                // TryCopyTo<T>(Vector128<T>, Span<T>)	
                // Tries to copy a Vector<T> to a given span.
                // Ignore.

                // Widen(Vector128<Byte>)	
                // Widens a Vector128<T> into writero Vector128<T>.
                // Widen(Vector128<Int16>)	
                // Widens a Vector128<T> into writero Vector128<T>.
                // Widen(Vector128<Int32>)	
                // Widens a Vector128<T> into writero Vector128<T>.
                // Widen(Vector128<SByte>)	
                // Widens a Vector128<T> into writero Vector128<T>.
                // Widen(Vector128<Single>)	
                // Widens a Vector128<T> into writero Vector128<T>.
                // Widen(Vector128<UInt16>)	
                // Widens a Vector128<T> into writero Vector128<T>.
                // Widen(Vector128<UInt32>)	
                // Widens a Vector128<T> into writero Vector128<T>.
                if (true) {
                    (var low, var high) = Vector128.Widen(Vector128s<Single>.Demo);
                    WriteLine(writer, indent, "Widen(Vector128s<Single>.Demo):\t{0}, {1}", low, high);
                }
                if (true) {
                    (var low, var high) = Vector128.Widen(Vector128s<SByte>.Demo);
                    WriteLine(writer, indent, "Widen(Vector128s<SByte>.Demo):\t{0}, {1}", low, high);
                }
                if (true) {
                    (var low, var high) = Vector128.Widen(Vector128s<Byte>.Demo);
                    WriteLine(writer, indent, "Widen(Vector128s<Byte>.Demo):\t{0}, {1}", low, high);
                }
                if (true) {
                    (var low, var high) = Vector128.Widen(Vector128s<Int16>.Demo);
                    WriteLine(writer, indent, "Widen(Vector128s<Int16>.Demo):\t{0}, {1}", low, high);
                }
                if (true) {
                    (var low, var high) = Vector128.Widen(Vector128s<UInt16>.Demo);
                    WriteLine(writer, indent, "Widen(Vector128s<UInt16>.Demo):\t{0}, {1}", low, high);
                }
                if (true) {
                    (var low, var high) = Vector128.Widen(Vector128s<Int32>.Demo);
                    WriteLine(writer, indent, "Widen(Vector128s<Int32>.Demo):\t{0}, {1}", low, high);
                }
                if (true) {
                    (var low, var high) = Vector128.Widen(Vector128s<UInt32>.Demo);
                    WriteLine(writer, indent, "Widen(Vector128s<UInt32>.Demo):\t{0}, {1}", low, high);
                }

                // WithElement<T>(Vector128<T>, Int32, T)	
                // Creates a new Vector128<T> with the element at the specified index set to the specified value and the remaining elements set to the same value as that in the given vector.
                if (true) {
                    shift = 1;
                    WriteLine(writer, indent, "shift:\t{0}", shift);
                    WriteLine(writer, indent, "WithElement(Vector128s<Single>.Demo, shift):\t{0}", Vector128.WithElement(Vector128s<Single>.Demo, shift, Scalars<Single>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<Double>.Demo, shift, Scalars<Single>.V1):\t{0}", Vector128.WithElement(Vector128s<Double>.Demo, shift, Scalars<Single>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<SByte>.Demo, shift, Scalars<SByte>.V1):\t{0}", Vector128.WithElement(Vector128s<SByte>.Demo, shift, Scalars<SByte>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<Byte>.Demo, shift, Scalars<Byte>.V1):\t{0}", Vector128.WithElement(Vector128s<Byte>.Demo, shift, Scalars<Byte>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<Int16>.Demo, shift, Scalars<Int16>.V1):\t{0}", Vector128.WithElement(Vector128s<Int16>.Demo, shift, Scalars<Int16>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<UInt16>.Demo, shift, Scalars<UInt16>.V1):\t{0}", Vector128.WithElement(Vector128s<UInt16>.Demo, shift, Scalars<UInt16>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<Int32>.Demo, shift, Scalars<Int32>.V1):\t{0}", Vector128.WithElement(Vector128s<Int32>.Demo, shift, Scalars<Int32>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<UInt32>.Demo, shift, Scalars<UInt32>.V1):\t{0}", Vector128.WithElement(Vector128s<UInt32>.Demo, shift, Scalars<UInt32>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<Int64>.Demo, shift, Scalars<Int64>.V1):\t{0}", Vector128.WithElement(Vector128s<Int64>.Demo, shift, Scalars<Int64>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<UInt64>.Demo, shift, Scalars<UInt64>.V1):\t{0}", Vector128.WithElement(Vector128s<UInt64>.Demo, shift, Scalars<UInt64>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<IntPtr>.Demo, shift, Scalars<IntPtr>.V1):\t{0}", Vector128.WithElement(Vector128s<IntPtr>.Demo, shift, Scalars<IntPtr>.V1));
                    WriteLine(writer, indent, "WithElement(Vector128s<UIntPtr>.Demo, shift, Scalars<UIntPtr>.V1):\t{0}", Vector128.WithElement(Vector128s<UIntPtr>.Demo, shift, Scalars<UIntPtr>.V1));
                }

                // WithLower<T>(Vector128<T>, Vector64<T>)	
                // Creates a new Vector128<T> with the lower 64 bits set to the specified value and the upper 64 bits set to the same value as that in the given vector.
                WriteLine(writer, indent, "WithLower(Vector128s<Single>.Demo, Vector64s<Single>.V2):\t{0}", Vector128.WithLower(Vector128s<Single>.Demo, Vector64s<Single>.V2));
                WriteLine(writer, indent, "WithLower(Vector128s<Double>.Demo, Vector64s<Double>.V2):\t{0}", Vector128.WithLower(Vector128s<Double>.Demo, Vector64s<Double>.V2));
                WriteLine(writer, indent, "WithLower(Vector128s<SByte>.Demo, Vector64s<SByte>.V2):\t{0}", Vector128.WithLower(Vector128s<SByte>.Demo, Vector64s<SByte>.V2));
                WriteLine(writer, indent, "WithLower(Vector128s<Byte>.Demo, Vector64s<Byte>.V2):\t{0}", Vector128.WithLower(Vector128s<Byte>.Demo, Vector64s<Byte>.V2));
                WriteLine(writer, indent, "WithLower(Vector128s<Int16>.Demo, Vector64s<Int16>.V2):\t{0}", Vector128.WithLower(Vector128s<Int16>.Demo, Vector64s<Int16>.V2));
                WriteLine(writer, indent, "WithLower(Vector128s<UInt16>.Demo, Vector64s<UInt16>.V2):\t{0}", Vector128.WithLower(Vector128s<UInt16>.Demo, Vector64s<UInt16>.V2));
                WriteLine(writer, indent, "WithLower(Vector128s<Int32>.Demo, Vector64s<Int32>.V2):\t{0}", Vector128.WithLower(Vector128s<Int32>.Demo, Vector64s<Int32>.V2));
                WriteLine(writer, indent, "WithLower(Vector128s<UInt32>.Demo, Vector64s<UInt32>.V2):\t{0}", Vector128.WithLower(Vector128s<UInt32>.Demo, Vector64s<UInt32>.V2));
                WriteLine(writer, indent, "WithLower(Vector128s<Int64>.Demo, Vector64s<Int64>.V2):\t{0}", Vector128.WithLower(Vector128s<Int64>.Demo, Vector64s<Int64>.V2));
                WriteLine(writer, indent, "WithLower(Vector128s<UInt64>.Demo, Vector64s<UInt64>.V2):\t{0}", Vector128.WithLower(Vector128s<UInt64>.Demo, Vector64s<UInt64>.V2));

                // WithUpper<T>(Vector128<T>, Vector64<T>)	
                // Creates a new Vector128<T> with the upper 64 bits set to the specified value and the lower 64 bits set to the same value as that in the given vector.
                WriteLine(writer, indent, "WithUpper(Vector128s<Single>.Demo, Vector64s<Single>.V2):\t{0}", Vector128.WithUpper(Vector128s<Single>.Demo, Vector64s<Single>.V2));
                WriteLine(writer, indent, "WithUpper(Vector128s<Double>.Demo, Vector64s<Double>.V2):\t{0}", Vector128.WithUpper(Vector128s<Double>.Demo, Vector64s<Double>.V2));
                WriteLine(writer, indent, "WithUpper(Vector128s<SByte>.Demo, Vector64s<SByte>.V2):\t{0}", Vector128.WithUpper(Vector128s<SByte>.Demo, Vector64s<SByte>.V2));
                WriteLine(writer, indent, "WithUpper(Vector128s<Byte>.Demo, Vector64s<Byte>.V2):\t{0}", Vector128.WithUpper(Vector128s<Byte>.Demo, Vector64s<Byte>.V2));
                WriteLine(writer, indent, "WithUpper(Vector128s<Int16>.Demo, Vector64s<Int16>.V2):\t{0}", Vector128.WithUpper(Vector128s<Int16>.Demo, Vector64s<Int16>.V2));
                WriteLine(writer, indent, "WithUpper(Vector128s<UInt16>.Demo, Vector64s<UInt16>.V2):\t{0}", Vector128.WithUpper(Vector128s<UInt16>.Demo, Vector64s<UInt16>.V2));
                WriteLine(writer, indent, "WithUpper(Vector128s<Int32>.Demo, Vector64s<Int32>.V2):\t{0}", Vector128.WithUpper(Vector128s<Int32>.Demo, Vector64s<Int32>.V2));
                WriteLine(writer, indent, "WithUpper(Vector128s<UInt32>.Demo, Vector64s<UInt32>.V2):\t{0}", Vector128.WithUpper(Vector128s<UInt32>.Demo, Vector64s<UInt32>.V2));
                WriteLine(writer, indent, "WithUpper(Vector128s<Int64>.Demo, Vector64s<Int64>.V2):\t{0}", Vector128.WithUpper(Vector128s<Int64>.Demo, Vector64s<Int64>.V2));
                WriteLine(writer, indent, "WithUpper(Vector128s<UInt64>.Demo, Vector64s<UInt64>.V2):\t{0}", Vector128.WithUpper(Vector128s<UInt64>.Demo, Vector64s<UInt64>.V2));

                // Xor<T>(Vector128<T>, Vector128<T>)	
                // Computes the exclusive-or of writero vectors.
                WriteLine(writer, indent, "Xor(Vector128s<Single>.Demo, Vector128s<Single>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<Single>.Demo, Vector128s<Single>.XyzwWMask));
                WriteLine(writer, indent, "Xor(Vector128s<Double>.Demo, Vector128s<Double>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<Double>.Demo, Vector128s<Double>.XyzwWMask));
                WriteLine(writer, indent, "Xor(Vector128s<SByte>.Demo, Vector128s<SByte>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<SByte>.Demo, Vector128s<SByte>.XyzwWMask));
                WriteLine(writer, indent, "Xor(Vector128s<Byte>.Demo, Vector128s<Byte>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<Byte>.Demo, Vector128s<Byte>.XyzwWMask));
                WriteLine(writer, indent, "Xor(Vector128s<Int16>.Demo, Vector128s<Int16>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<Int16>.Demo, Vector128s<Int16>.XyzwWMask));
                WriteLine(writer, indent, "Xor(Vector128s<UInt16>.Demo, Vector128s<UInt16>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<UInt16>.Demo, Vector128s<UInt16>.XyzwWMask));
                WriteLine(writer, indent, "Xor(Vector128s<Int32>.Demo, Vector128s<Int32>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<Int32>.Demo, Vector128s<Int32>.XyzwWMask));
                WriteLine(writer, indent, "Xor(Vector128s<UInt32>.Demo, Vector128s<UInt32>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<UInt32>.Demo, Vector128s<UInt32>.XyzwWMask));
                WriteLine(writer, indent, "Xor(Vector128s<Int64>.Demo, Vector128s<Int64>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<Int64>.Demo, Vector128s<Int64>.XyzwWMask));
                WriteLine(writer, indent, "Xor(Vector128s<UInt64>.Demo, Vector128s<UInt64>.XyzwWMask):\t{0}", Vector128.Xor(Vector128s<UInt64>.Demo, Vector128s<UInt64>.XyzwWMask));
            }

#else
            // none.
#endif // NET7_0_OR_GREATER
            return writer.GetStringBuilder().Length;
        }

        [Obsolete]
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void Tip_Delegate(Delegate d) {
            if (null!= d) {
                // no do.
            }
        }

        public static class Tip {

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void Ceiling<T>() {
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void ExtractMostSignificantBits<T>() {
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void Floor<T>() {
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void Narrow<T>() {
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void ShiftLeft<T>() {
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void ShiftRightArithmetic<T>() {
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void ShiftRightLogical<T>() {
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void Shuffle<T>() {
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void Sum<T>() {
            }

        }

    }
}
