using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI_2.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI_2.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] IClienteServices clienteServices)
        {
            clienteServices.AdicionarCliente(new Cliente());
        }
    }
}