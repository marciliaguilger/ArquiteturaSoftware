//using SOLID._1___SRP.SRP_SOLUÇÃO;
using SOLID._5___DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5___DIP.Solucao
{
    public class ClienteServices : IClienteService
    {
        
        //INTERFACES IMPLEMENTADAS COMO PROPRIEDADE
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailService _emailServices;
        
        //injeção de dependencia
        //no construtor vc recebe a instancia do objeto qe implementa as interfaces
        //aqui vc depende apenas da abstração (interface) mas sera recebido o objeto que implementa o contrato da interface
        public ClienteServices(
            IEmailService emailServices,
            IClienteRepository clienteRepository)
        {
            _emailServices = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);
            _emailServices.Enviar("empresa@empresa", cliente.Email.Endereco,"Sucesso", "Sucesso no cadastro");

            return "Cliente cadastrado";

        }

    }

    public class TesteDip
    {
        public TesteDip()
        {
            // ESTA INSTANCIAÇÃO É POSSÍVEL PQ EmailService é uma implementação do  IEmailService (obrigatório no contrato da injeção de dependencia de ClienteServices
            var cliService = new ClienteServices(new EmailService(), new ClienteRepository());
            
            var cliService2 = new ClienteServices(new EmailService(), new ClienteRepository2());
        }
    }
}
