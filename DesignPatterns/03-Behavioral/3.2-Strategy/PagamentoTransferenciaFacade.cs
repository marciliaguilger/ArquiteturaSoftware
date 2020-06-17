using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns._03_Behavioral._3._2_Strategy
{
    public class PagamentoTransferenciaFacade : IPagamentoTransferenciaFacade
    {
        public string RealizarTransferencia()
        {
            //realizar transferencias
            return new string (Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXY0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
