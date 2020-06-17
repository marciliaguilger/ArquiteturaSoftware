using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational._1._1_AbstractFactory
{
    //ABSTRACT PRODUCT
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);

        public Porte Porte { get; set; }
    }

    //Produto concreto
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }
        public override void Socorrer(Veiculo veiculo)
        {
            //Processo de socorro
            Console.WriteLine("Socorrendo carro pequeno modelo: " + veiculo.Modelo);
        }
    }

    //Produto concreto
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }
        public override void Socorrer(Veiculo veiculo)
        {
            //Processo de socorro
            Console.WriteLine("Socorrendo carro médio modelo: " + veiculo.Modelo);
        }
    }
    //Produto concreto
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }
        public override void Socorrer(Veiculo veiculo)
        {
            //Processo de socorro
            Console.WriteLine("Socorrendo carro grande modelo: " + veiculo.Modelo);
        }
    }

    public class GuinchoCreator
    {
        //Método que devolve a instanciação da classe de acordo com o porte informado.
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);
                case Porte.Medio:
                    return new GuinchoMedio(porte);
                case Porte.Grande:
                    return new GuinchoGrande(porte);
                default:
                    throw new ApplicationException("Porte de guincho desconhecido.");
            }
        }
    }

}
