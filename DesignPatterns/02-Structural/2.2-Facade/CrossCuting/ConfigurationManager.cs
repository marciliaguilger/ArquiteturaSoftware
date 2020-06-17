using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns._02_Structural._2._2_Facade.CrossCuting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string node)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

    }
}
