using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03_Behavioral._3._3_Observable
{
    internal class Observador : IObservador
    {
        public Observador(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; }

        public void Notificar(Investimento investimento)
        {
            Console.WriteLine("Notificando {0} que {1} " +
                "teve preço alterado para {2:C}", Nome, investimento.Simbolo, investimento.Valor );
        }
    }
}
