using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___ISP.Violacao
{
    public class CadastrarProduto : ICadastro
    {
        public void EnviarEmail()
        {
            //produto nao envia email, e agora????
            throw new NotImplementedException();
        }

        public void SalvarBanco()
        {
            //salvar produto 
        }

        public void ValidarDados()
        {
            //validar valor produto
        }
    }
}
