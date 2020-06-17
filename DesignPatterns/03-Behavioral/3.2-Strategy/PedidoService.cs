using DesignPatterns._02_Structural._2._2_Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03_Behavioral._3._2_Strategy
{
    //Esta classe representa a estatégia abstrata que vai delegar a estratégia concreta 
    public class PedidoService
    {
        
        private readonly IPagamento _pagamento;
        public PedidoService(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }
        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            return _pagamento.RealizarPagamento(pedido, pagamento);
        }
    }
}
