using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128AdvSimd {

        partial class Statics {

#if NET5_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector128<T> value) where T : struct {
                // From Danila Kutenin, "Bit twiddling with Arm Neon: beating SSE movemasks, counting bits and more"
                // https://community.arm.com/arm-community-blogs/b/infrastructure-solutions-blog/posts/porting-x86-vector-bitmask-optimizations-to-arm-neon
                // const uint16x8_t equalMask = vreinterpretq_u16_u8(vceqq_u8(chunk, vdupq_n_u8(tag)));
                // const uint8x8_t res = vshrn_n_u16(equalMask, 4);
                // const uint64_t matches = vget_lane_u64(vreinterpret_u64_u8(res), 0);
                // return matches;
                Vector64<ulong> res = AdvSimd.ShiftRightLogicalNarrowingLower(value.AsUInt16(), 4).AsUInt64();
                ulong matches = res.ToScalar();
                return ulong.MaxValue == matches;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector128<T> value) where T : struct {
                Vector64<long> res = AdvSimd.ShiftRightLogicalNarrowingLower(value.AsUInt16(), 4).AsInt64();
                long matches = res.ToScalar();
                return 0 != matches;
            }

#endif // NET5_0_OR_GREATER
        }
    }
}
