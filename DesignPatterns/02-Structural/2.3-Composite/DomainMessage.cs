using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._3_Composite
{
    public class DomainMessage : IMessage
    {
        public string Nome { get; set; }

        public DomainMessage(string name)
        {
            Nome = name;
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string ('-', sub)+Nome);
        }
    }
}
