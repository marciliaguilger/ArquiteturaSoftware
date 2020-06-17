using System;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    public class Logger : ILogger
    {
        //Target class
        public void Log(string message)
        {
            Console.WriteLine("Log padrão: "+message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Log padrão - " + exception.Message);
        }
    }
}
