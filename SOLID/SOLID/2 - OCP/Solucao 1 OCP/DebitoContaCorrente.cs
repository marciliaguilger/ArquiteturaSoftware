using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___OCP.Solucao_1_OCP
{
    public class DebitoContaCorrente : DebitoConta
    {

        public override string Debitar(decimal valor, string conta)
        {
            //Debitar conta corrente
            return FormatarTransacao();
        }
        
    }
}
