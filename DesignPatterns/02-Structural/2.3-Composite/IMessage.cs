using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._3_Composite
{
    public interface IMessage
    {
        public string Nome { get; set; }
        void ExibirMensagens(int sub);
    }
}
