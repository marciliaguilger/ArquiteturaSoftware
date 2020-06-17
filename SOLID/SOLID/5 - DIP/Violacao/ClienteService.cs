using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5___DIP.Violacao
{
    public class ClienteService
    {
        //classe de serviço de orquestração para a classe Cliente
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            //ESTA IMPLEMENTAÇÃO GERA ALTO ACOPLAMENTO
            //CASO O OBJ mude O CLienteService precisará se adequar
            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem vindo(a)", "Bem vinda(o)");

            return "Cliente cadastrado com sucesso";        }
    }
}
