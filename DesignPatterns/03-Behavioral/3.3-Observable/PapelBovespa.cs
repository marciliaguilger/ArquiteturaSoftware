using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03_Behavioral._3._3_Observable
{
    //concrete subject 
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal preco) : base(simbolo, preco)
        {

        }
    }
}
