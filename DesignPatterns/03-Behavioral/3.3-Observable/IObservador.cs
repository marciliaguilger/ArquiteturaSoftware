using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03_Behavioral._3._3_Observable
{
    public interface IObservador
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
