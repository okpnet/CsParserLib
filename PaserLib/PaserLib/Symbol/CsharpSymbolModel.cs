using PaserLib.Symbol.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserLib.Symbol
{
    public class CsharpSymbolModel : ISymbolModel
    {
        public char[] EndOfblocks { get; init; } = [];

        public char[] Ignores { get; init; } = [];

        public char[] Escapes { get; init; } = [];

        public char[] Opens { get; init; } = [];

        public char[] Closes { get; init; } = [];

        public char[] Literal { get; init; } = [];

        public char[] Separate { get; init; } = [];
    }
}
