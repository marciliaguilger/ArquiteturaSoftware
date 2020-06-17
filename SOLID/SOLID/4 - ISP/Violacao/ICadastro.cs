using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___ISP.Violacao
{
    public interface ICadastro
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}
