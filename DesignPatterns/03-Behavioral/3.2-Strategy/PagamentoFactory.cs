using DesignPatterns._02_Structural._2._2_Facade.CrossCuting;
using DesignPatterns._02_Structural._2._2_Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03_Behavioral._3._2_Strategy
{
    public class PagamentoFactory
    {
        //NESTE CASO SERIA NECESSÁRIO USAR UM TIPO DE SERVICE LOCATOR
        //OU INJETAR TODAS AS INSTANCIAS PARA RETORNAR APENAS UMA

        public static IPagamento CreatePagamento(MeioPagamento meioPagamento)
        {
            switch(meioPagamento)
            {
                case MeioPagamento.CartaoCredito:
                    return new PagamentoCartaoCreditoService(
                        new PagamentoCartaoCreditoFacade(
                            new PayPalGateway(),
                            new ConfigurationManager()));
                case MeioPagamento.Boleto:
                    return new PagamentoBoletoService(new PagamentoBoletoFacade());
                case MeioPagamento.TransferenciaBancaria:
                    return new PagamentoTransferenciaService(new PagamentoTransferenciaFacade());
                default:
                    throw new ApplicationException("Meio de Pagamento não conhecido");

            }
        }
    }
}
