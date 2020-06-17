using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___LSP.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura)
            :base (altura,largura)
            {
                if (altura != largura)
                    throw new ArgumentException("Os dois lados não são iguais.");
            }

    }
}
