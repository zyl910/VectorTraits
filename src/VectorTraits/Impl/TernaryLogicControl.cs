using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Control codes for ternary logic (三元逻辑的控制码)
    /// </summary>
    /// <remarks>
    /// <para>For member naming conventions, use Prefix Expression (Polish Notation) (对于成员的命名规范, 采用前缀表达式(波兰式) ).</para>
    /// <list type="bullet">
    /// <item>NotA: <c>~A</c></item>
    /// <item>Or_And_A_B_And_NotA_C: <c>(A&amp;B)|(~A&amp;C)</c></item>
    /// <item>...</item>
    /// </list>
    /// </remarks>
    /// <seealso cref="Avx512F.TernaryLogic(Vector512{int}, Vector512{int}, Vector512{int}, byte)"/>
    public static class TernaryLogicControl {
        /// <summary>0xF0: <c>A</c></summary>
        public const byte A = 0xF0;
        /// <summary>0xCC: <c>B</c></summary>
        public const byte B = 0xCC;
        /// <summary>0xAA: <c>C</c></summary>
        public const byte C = 0xAA;

        /// <summary>0x00: <c>0</c></summary>
        public const byte All0 = 0x00;
        /// <summary>0xFF: <c>1</c></summary>
        public const byte All1 = 0xFF;

        /// <summary>0x0F: <c>~A</c></summary>
        public const byte NotA = unchecked((byte)~A);
        /// <summary>0x33: <c>~B</c></summary>
        public const byte NotB = unchecked((byte)~B);
        /// <summary>0x55: <c>~C</c></summary>
        public const byte NotC = unchecked((byte)~C);

        /// <summary>0xCA: <c>(A&amp;B)|(~A&amp;C)</c></summary>
        public const byte Or_And_A_B_And_NotA_C = unchecked((A & B) | (~A & C));
        /// <summary>0xF3: <c>A | ~B</c></summary>
        public const byte Or_A_NotB = unchecked(A | (byte)~B);

    }

}
