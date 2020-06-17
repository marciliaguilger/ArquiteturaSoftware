using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SOLID._1___SRP.SRP_SOLUÇÃO
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConexao";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME,EMAIL,CPF, DATACADASTRO) VALUES @nome, @email,@cpf,@dataCadastro";

                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("Cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("DataCadastro", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();


            }
        }
    }
}
