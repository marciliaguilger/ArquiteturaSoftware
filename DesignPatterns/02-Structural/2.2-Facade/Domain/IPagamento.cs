﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._2_Facade.Domain
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
