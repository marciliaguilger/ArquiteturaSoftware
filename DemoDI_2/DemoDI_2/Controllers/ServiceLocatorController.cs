using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI_2.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI_2.Controllers
{
    public class ServiceLocatorController : Controller
    {
        //IService
        private readonly IServiceProvider _serviceProvider;
        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        
        public void Index()
        {
            //retorna null se não estiver registrado
            _serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}