using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___SRP.SRP_SOLUÇÃO
{
    public class ClienteService
    {
        //classe de serviço de orquestração para a classe Cliente
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem vindo(a)", "Bem vinda(o)");

            return "Cliente cadastrado com sucesso";        }
    }
}
