using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___LSP.Solucao
{
    class CalculoArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo area triangulo");
            Console.WriteLine();

        }

        public static void Calcular()
        {
            var quad = new Quadrado(10, 5);
            var ret = new Retangulo(10, 5);

            ObterAreaParalelogramo(quad);
        }
    }
}
