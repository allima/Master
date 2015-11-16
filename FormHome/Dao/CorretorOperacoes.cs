using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHome.controle
{
    class CorretorOperacoes
    {
        private static string stringConexao = ConfigurationManager.
           ConnectionStrings[@"FormHome.Properties.Settings.masterimovelConnectionString1"].
           ConnectionString;

        public static void Incluir(Corretor corretor)
        {

            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"insert into corretor
           (nome
           , email
           , endereco
           , cpf
           , rg
           , telefone) values (" + // Instruc5o SQL a ser executada.
            corretor.Nome + "'," +
            corretor.Endereco + "'," +
            corretor.Cpf + "'," +
            corretor.Rg + "'," +
            corretor.Telefone + "')";
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instruc5o SQL e a string de conexio a ser usada. 
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucio SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Alterar(Corretor corretor)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"update corretor set " + // Instrucao SQL a ser executada. 
                "id_imovel = '" + corretor.Nome + "', " +
                
                
                "id_inquilino = '" + corretor.Telefone + "'" +
                "id_corretor = '" + corretor.Rg + "', " +

                "where id = " + corretor.Id;
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instrucao SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Excluir(Corretor corretor)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados.
            string comando = "delete from aluguel where id = " +  // Instrucao SQL a ser executada. 
                corretor.Id.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instruc5o SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }
    }
}
