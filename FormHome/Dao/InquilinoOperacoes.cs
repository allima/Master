using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHome.controle
{
    class InquilinoOperacoes
    {

        private static string stringConexao = ConfigurationManager.
           ConnectionStrings[@"FormHome.Properties.Settings.masterimovelConnectionString1"].
           ConnectionString;

        public static void Incluir(Inquilino inquilino)
        {

            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"insert into inquilino
           (nome
           , email
           , endereco
           , cpf
           , rg
           , telefone) values (" + // Instruc5o SQL a ser executada.
            inquilino.Nome + "'," +
            inquilino.Endereco + "'," +
            inquilino.Cpf + "'," +
            inquilino.Rg + "'," +
            inquilino.Telefone + "')";
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instruc5o SQL e a string de conexio a ser usada. 
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucio SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Alterar(Inquilino inquilino)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"update inquilino set " + // Instrucao SQL a ser executada. 
                "nome = '" + inquilino.Nome + "', " +
                "email = '" + inquilino.Email + "', " +
                "endereco = '" + inquilino.Endereco + "', " +
                "endereco = '" + inquilino.Endereco + "', " +
                "cpf = '" + inquilino.Cpf + "'" +
                "rg = '" + inquilino.Rg + "', " +
                "telefone = '" + inquilino.Telefone + "', " +
                "where id = " + inquilino.Id;
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instrucao SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Excluir(Inquilino inquilino)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados.
            string comando = @"delete from inquilino where id = " +  // Instrucao SQL a ser executada. 
                inquilino.Id.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instruc5o SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }
    }
}
