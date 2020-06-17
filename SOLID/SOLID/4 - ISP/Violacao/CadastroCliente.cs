using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___ISP.Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void ValidarDados()
        {
            //validar cpf, email
        }

        public void SalvarBanco()
        {
            //insert na tabela cliente
        }

        public void EnviarEmail()
        {
            //enviar email para o cliente
        }
    }
}
