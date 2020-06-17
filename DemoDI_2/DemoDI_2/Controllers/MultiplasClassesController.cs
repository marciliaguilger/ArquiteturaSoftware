using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI_2.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI_2.Controllers
{
    public class MultiplasClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAccessor;
        
        public MultiplasClassesController(Func<string, IService> serviceAccessor)
        {
            _serviceAccessor = serviceAccessor;
        }
        
        public string Index()
        {
            return _serviceAccessor("A").Retorno();
        }
    }
}