using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI_2.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI_2.Controllers
{
    public class GenericController : Controller
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;

        //Injeção de dependencia de um repositório genérico sendo especializado para 'cliente'
        public GenericController(IGenericRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        
        public void Index()
        {
            _clienteRepository.Adicionar(new Cliente());
        }
    }
}