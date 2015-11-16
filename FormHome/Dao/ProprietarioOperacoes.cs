using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHome.controle
{
    class ProprietarioOperacoes
    {
        private static string stringConexao = ConfigurationManager.
           ConnectionStrings[@"FormHome.Properties.Settings.masterimovelConnectionString1"].
           ConnectionString;

        public static void Incluir(Proprietario proprietario)
        {

            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"insert into proprietario
           (nome
           , email
           , endereco
           , cpf
           , rg
           , telefone) values (" + // Instruc5o SQL a ser executada.
            proprietario.Nome + "'," +
            proprietario.Endereco + "'," +
            proprietario.Cpf + "'," +
            proprietario.Rg + "'," +
            proprietario.Telefone + "')";
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instruc5o SQL e a string de conexio a ser usada. 
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucio SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Alterar(Proprietario proprietario)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"update proprietario set " + // Instrucao SQL a ser executada. 
                "nome = '" + proprietario.Nome + "', " +
                "email = '" + proprietario.Email + "', " +
                "endereco = '" + proprietario.Endereco + "', " +
                "endereco = '" + proprietario.Endereco + "', " +
                "cpf = '" + proprietario.Cpf + "'" +
                "rg = '" + proprietario.Rg + "', " +
                "telefone = '" + proprietario.Telefone + "', " +
                "where id = " + proprietario.Id;
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instrucao SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Excluir(Proprietario proprietario)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados.
            string comando = @"delete from aluguel where id = " +  // Instrucao SQL a ser executada. 
                proprietario.Id.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instruc5o SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }
    }
}
