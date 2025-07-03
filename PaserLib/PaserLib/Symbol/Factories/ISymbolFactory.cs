using PaserLib.Symbol.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserLib.Symbol.Factories
{
    public interface ISymbolFactory
    {
        ISymbol Create(char buffer);
    }
}
