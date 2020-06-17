using SOLID._5___DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SOLID._5___DIP.Solucao
{
    public class ClienteRepository2 : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            //outra forma de adicionar no banco de dados
        }
    }
}
