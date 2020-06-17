﻿using DesignPatterns._01_Creational._1._1_AbstractFactory;
using DesignPatterns._01_Creational._1._2_FactoryMethod;
using DesignPatterns._01_Creational._1._3_Singleton;
using DesignPatterns._02_Structural._2._1_Adapter;
using DesignPatterns._02_Structural._2._2_Facade;
using DesignPatterns._02_Structural._2._3_Composite;
using DesignPatterns._03_Behavioral._3._1_Command;
using DesignPatterns._03_Behavioral._3._2_Strategy;
using DesignPatterns._03_Behavioral._3._3_Observable;
using System;

namespace DesignPatterns
{
    class Program
    {
        public static object ExecucaoStategy { get; private set; }

        static void Main()
        {
            Console.WriteLine("Escola a opção:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Creational Pattern");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Strategy");
            Console.WriteLine("9 - Observer");
            Console.WriteLine("------------------------------------");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '2':
                    ExecucaoFactoryMethod.Executar();
                    break;
                case '3':
                    Singleton.Executar();
                    break;
                case '4':
                    ExecucaoAdapter.Executar();
                    break;
                case '5':
                    ExecucaoFacade.Executar();
                    break;
                case '6':
                    ExecucaoComposite.Executar();
                    break;
                case '7':
                    ExecucaoCommand.Executar();
                    break;
                case '8':
                    ExecucaoStrategy.Executar();
                    break;
                case '9':
                    ExecucaoObserver.Executar();
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
