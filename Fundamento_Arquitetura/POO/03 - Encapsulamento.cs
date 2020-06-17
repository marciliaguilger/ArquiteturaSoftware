using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamento_Arquitetura.POO
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}
