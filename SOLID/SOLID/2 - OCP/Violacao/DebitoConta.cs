using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Corrente)
            {
                //DÉBITO CONTA CORRENTE
            }

            if(tipoConta == TipoConta.Poupanca)
            {
                //VALIDA ANIVERSARIO DA CONTA
                //DEBITA CONTA POUPANCA
            }
        }
    }
}
