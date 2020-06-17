using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    //Adaptee class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log customizado "+message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Log customizado "+exception.Message);
        }
    }
}
