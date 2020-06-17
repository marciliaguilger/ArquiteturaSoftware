using SOLID._5___DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SOLID._5___DIP.Solucao
{
    public class ClienteRepository : IClienteRepository
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
