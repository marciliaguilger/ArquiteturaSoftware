using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI_2.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI_2.Controllers
{
    public class ServiceLocator2Controller : Controller
    {
        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            //service locator com injeção de dependencia por propriedade;
            //menos recomendado do que o anterior
            serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}