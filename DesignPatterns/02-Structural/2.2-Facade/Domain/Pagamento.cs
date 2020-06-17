using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._2_Facade.Domain
{
    public class Pagamento
    {
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public MeioPagamento MeioPagamento { get; set; }

        //possiveis meios de pagamentos implementados direto na classe pagamento pro brevidade de exemplo
        public string CartaoCredito { get; set; }
        public string  LinhaDigitavelBoleto { get; set; }
        public string ConfirmaTransferencia { get; set; }
    }
}
