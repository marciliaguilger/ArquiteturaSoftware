﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5___DIP.Violacao
{
    public class Cpf
    {
        public string Numero { get; set; }
        public bool Validar()
        {
            return Numero.Length == 11;
        }
    }
}
