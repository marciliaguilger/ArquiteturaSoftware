using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID._2___OCP.Solucao_2
{
    public class DebitoConta
    {

        public string NumeroTransacao { get; set; }
        public string NumeroConta { get; set; }
        public decimal Valor { get; set; }

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMOPQRSTUVXYZ123456789";
            var random = new Random();

            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            return NumeroTransacao;

        }
    }
}
