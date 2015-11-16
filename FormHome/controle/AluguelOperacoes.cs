using FormHome.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHome.controle
{
    class AluguelOperacoes
    {
        private static string stringConexao = ConfigurationManager.
            ConnectionStrings[@"FormHome.Properties.Settings.masterimovelConnectionString"].
            ConnectionString;

        public static void Incluir(Aluguel aluguel)
        {

            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = "insert aluguel values (" + // Instruc5o SQL a ser executada.
            aluguel.Imovel.Id + "'," +
            aluguel.Inquilino.Id + "'," +
            aluguel.Corretor.Id + "')";
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instruc5o SQL e a string de conexio a ser usada. 
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucio SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }
        
        public static void Alterar(Aluguel aluguel)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = "update aluguel set " + // Instrucao SQL a ser executada. 
                "id_imovel = '" + aluguel.Imovel.Id + "', " +
                "id_inquilino = '" + aluguel.Inquilino.Id + "'" +
                "id_corretor = '" + aluguel.Corretor.Id + "', " +
                "where id = " + aluguel.Id;
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instrucao SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Excluir(Aluguel aluguel)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados.
            string comando = "delete from aluguel where id = " +  // Instrucao SQL a ser executada. 
                aluguel.Id.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instruc5o SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
            
        }
    }
}
