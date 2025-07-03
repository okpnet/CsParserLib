using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserLib.Symbol.Core
{
    public interface ISymbolModel
    {
        char[] EndOfblocks { get; }

        char[] Ignores { get; }

        char[] Escapes { get; }

        char[] Opens { get; }

        char[] Closes { get; }

        char[] Literal { get; }

        char[] Separate { get; }

        char[] Strings { get; }
    }
}
