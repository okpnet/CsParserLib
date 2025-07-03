using PaserLib.Symbol.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserLib.Symbol
{
    public class StringSymbol(char value,bool isClose) : SymbolBase(value), IStringSymbol
    {
        public bool IsClose { get; }=isClose;

    }
}
