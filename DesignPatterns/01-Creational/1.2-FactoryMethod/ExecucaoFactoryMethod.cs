using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational._1._2_FactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlCon = DbFactory.Database(DataBase.SqlServer)
                .CreateConnector("minhaCS")
                .Connect();

            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.Database(DataBase.Oracle)
                .CreateConnector("minuaCS")
                .Connect();

            oracleCn.ExecuteCommand("select * from tbOracle");
            oracleCn.Close();
        }
    }
}
