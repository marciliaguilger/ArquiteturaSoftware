using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___OCP.Solucao_2
{
    public static class DebitoContaCorrente
    {
        //ESTA SOLUÇÃO NÃO USA HERANÇA, E SIM EXTENSION METHOD
        
        //O MÉTODO SERÁ INTERPRETADO DENTRO DE: this DebitoConta
        
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            //LÓGICO DE NEGOCIO PARA DEBITO EM CONTA CORRENTE

            return debitoConta.FormatarTransacao();
        }
    }
}
