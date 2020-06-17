using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5___DIP.Solucao.Interfaces
{
    public interface IEmailService
    {
        void Enviar(string de, string para, string assunto, string menssagem);
    }
}
