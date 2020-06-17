using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03_Behavioral._3._1_Command
{
    internal abstract class Commander
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
