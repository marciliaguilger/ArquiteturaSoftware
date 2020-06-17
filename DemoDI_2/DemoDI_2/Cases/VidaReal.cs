using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI_2.Cases
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string  Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
    }
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }
    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            //faz algo
        }
    }

    public interface IClienteServices
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        
        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
        }
    }
}
