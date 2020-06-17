using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SOLID._1___SRP.SRP_VIOLAÇÃO
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
            {
                return "Email inválido";
            }
            if (CPF.Length != 11)
                return "CPF Inválido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                //persistir no banco
            }

            //código para enviar e-mail


            return "Cliente cadastrado com sucesso";

            //neste codigo se ocorrer erro e o cliente nao for cadastrado, nao eh possível saber onde ocorreu o erro

        }
    }
}
