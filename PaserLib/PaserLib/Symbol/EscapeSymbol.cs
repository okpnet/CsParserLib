using PaserLib.Symbol.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserLib.Symbol
{
    public class EscapeSymbol(char value) : SymbolBase(value), IEscapeSymbol
    {
    }
}
