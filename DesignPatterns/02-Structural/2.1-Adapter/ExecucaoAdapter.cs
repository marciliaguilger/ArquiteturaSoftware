using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var pagamentoLogPadrao = new TransacaoService(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustom.RealizarTransacao();
        }

    }
}
