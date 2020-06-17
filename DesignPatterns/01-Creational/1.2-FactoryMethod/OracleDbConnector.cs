using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational._1._2_FactoryMethod
{
    //Concrete product
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco Oracle...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }

    }
}
