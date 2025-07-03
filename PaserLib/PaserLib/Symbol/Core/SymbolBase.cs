using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserLib.Symbol.Core
{
    public abstract class SymbolBase : ISymbol
    {
        public char Value { get; }

        protected SymbolBase(char value)
        {
            Value = value;
        }
    }



}
