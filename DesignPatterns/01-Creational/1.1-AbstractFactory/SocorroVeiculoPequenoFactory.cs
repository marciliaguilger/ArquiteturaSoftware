﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational._1._1_AbstractFactory
{
    //Concrete factory
    class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
