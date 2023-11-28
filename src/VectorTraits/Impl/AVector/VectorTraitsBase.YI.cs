using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector {

    partial class VectorTraitsBase {

        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsAllTrue{T}(Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector<T> value) where T : struct {
                Vector<int> allBitsSet = Vectors<int>.AllBitsSet;
                return Vector.EqualsAll(value.AsInt32(), allBitsSet);
            }


            /// <inheritdoc cref="IVectorTraits.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsAnyTrue{T}(Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector<T> value) where T : struct {
                Vector<byte> allBitsSet = Vectors<byte>.AllBitsSet; // Must use byte.
                return Vector.EqualsAny(value.AsByte(), allBitsSet);
            }

        }
    }
}
