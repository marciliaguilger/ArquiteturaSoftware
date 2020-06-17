using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___OCP.Solucao_1_OCP
{
    public class DebitoContaInvestimento : DebitoConta
    {

        public override string Debitar(decimal valor, string conta)
        {
            //DEBITA CONTA INVESTIMENTO
            //ISENTAR TAXAS
            return FormatarTransacao();
        }
    }
}
