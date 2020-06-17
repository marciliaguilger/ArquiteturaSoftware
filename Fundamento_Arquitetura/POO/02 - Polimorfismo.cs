using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamento_Arquitetura.POO
{
    //POLIMORFISMO - MULTIPLOS COMPORTAMENTOS
    public class CafeteiraEspressa : Eletrodomestico
    {
        //CONSTRUTOR OBRIGATÓRIO
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem) { }

        //CONSTRUTOR SEM PARAMETROS PADRÃO
        public CafeteiraEspressa()
            :base("Padrao", 220) { }

        //MÉTODOS PRIVADOS 
        private static void AquecerAgua() { }

        private static void MoerGraos() { } 

        public void PrepararCafe()
        {
            Testar(); // >> Só é possível sobrescrever se for virtual ou abstract na classe base
            //MÉTODO QUE VAI DE FATO ORQUESTRAR AS "ATIVIDADES"
            AquecerAgua();
            MoerGraos();

        }
        
        //SOBRESCRITA DO COMPORTAMENTO DA CLASSE BASE
        //NESTE CASO É OBRIGATÓRIO POIS ESTÁ DECLARADO NA CLASSE BASE
        public override void Ligar()
        {

        }

        public override void Desligar()
        {

        }


    }
}
