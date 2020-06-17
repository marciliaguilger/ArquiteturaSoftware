using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._2_Facade.CrossCuting
{
    public interface IPayPalGateway
    {

        public string GetPayPalServiceKey(string apiKey, string encriptionKey);
        public string GetCardHashKey(string apiKey, string tipoPagamento);
        public bool CommitTransaction(string cardHasKey, string id, decimal valor);


    }
}
