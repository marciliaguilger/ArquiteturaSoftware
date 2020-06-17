using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID._2___OCP.Solucao_1_OCP
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        
        //MÉTODO QUE DEVERÁ SER IMPLEMENTADO NA CLASSE DERIVADA
        public abstract string Debitar(decimal valor, string conta);

        //O MÉTODO ABAIXO É UMA RESPONSABILIDADE GLOBAL PARA QUALQUER CONTA
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
