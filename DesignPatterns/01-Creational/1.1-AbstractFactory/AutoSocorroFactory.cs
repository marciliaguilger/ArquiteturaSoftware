using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational._1._1_AbstractFactory
{
   
    //ABSTRACT FACTORY
    // EU CRIO DOIS PRODUTOS QUE TEM INTERAÇÕES ENTRE SI
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
   
    }
}
