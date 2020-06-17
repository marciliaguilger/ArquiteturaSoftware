using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._3_Composite
{
    public class InputFromMessage: IMessage
    {
        public string Nome { get; set; }

        public InputFromMessage(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}
