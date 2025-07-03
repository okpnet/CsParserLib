using PaserLib.Symbol.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserLib.Symbol
{
    public class SymbolVisiter
    {
        readonly ISymbolModel _symbolModel;

        bool _isEscape = false;
        

        public void Visit(string buffer)
        {
            var enumrator = buffer.GetEnumerator();
            var list=new Queue<ISymbol>();

            while (enumrator.MoveNext())
            {
                var current= enumrator.Current;
                list.TryPeek(out var queee);

                if (_symbolModel.Separate.Contains(current) && queee is not ISeparateSymbol)
                {
                    list.Enqueue(new SeparateSymbol(current));
                    continue;
                }

                if (_symbolModel.Escapes.Contains(current) && queee is not IEscapeSymbol)
                {
                    list.Enqueue(new EscapeSymbol(current));
                    continue;
                }

                if (_symbolModel.Strings.Contains(current) && queee is not EscapeSymbol )
                {
                    list.Enqueue(new StringSymbol(current,list.LastOrDefault(t => t is IStringSymbol) is IStringSymbol stringSymbol && !stringSymbol.IsClose));
                    continue;
                }

                if(_symbolModel.Opens.Contains(current) && 


                var current = Walk(enumrator);
                if (current == null)
                    continue;
                if (char.IsWhiteSpace(current[0]))
                {
                    // Handle whitespace
                    continue;
                }
                // Process the current symbol
                Console.WriteLine($"Processing symbol: {current}");
            }
        }

        private void SeparateCeck(char value)
        {
            _symbolModel.
        }

        private char Walk(CharEnumerator enumrator)
        {
            var current = enumrator.Current;
            
            if(_symbolModel.Ignores.Contains(current))
            {
                enumrator.MoveNext();
                return Walk(enumrator);
            }
            return current;
        }
    }
}
