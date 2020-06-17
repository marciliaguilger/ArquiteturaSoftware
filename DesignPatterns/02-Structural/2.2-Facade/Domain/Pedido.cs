using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._2_Facade.Domain
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
