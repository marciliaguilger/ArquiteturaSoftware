using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI_2.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI_2.Controllers
{
    public class VidaRealController : Controller
    {
        private readonly IClienteServices _clienteServices;

        public VidaRealController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }
        public void Index()
        {
            _clienteServices.AdicionarCliente(new Cliente());
        }
    }
}