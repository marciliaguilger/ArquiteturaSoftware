using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    public class TransacaoService
    {
        private readonly ILogger _logger;

        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }
        public void RealizarTransacao()
        {
            _logger.Log("Transação realizada");
        }
    }
}
