using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._2_Facade.CrossCuting
{
    public interface IConfigurationManager
    {
        public string GetValue(string key);
    }
}
