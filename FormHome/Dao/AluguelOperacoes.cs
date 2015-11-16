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
            ConnectionStrings[@"FormHome.Properties.Settings.masterimovelConnectionString1"].
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


        public static Aluguel Consultar(int codigo)
        {
            Aluguel aluguel = new Aluguel(); // Instancia a classe Cargos. 
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados.
            string comando = "select * from aluguel where IDCargo = " + // Instrucao SQL a ser executada.
            codigo.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instrucao SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            // Cria um objeto Sq1DataReader pars ler os registros retornados pela consulta. 
            SqlDataReader dr = sql.ExecuteReader();
            dr.Read(); // La os registros retornados pela consulta. 
                       // Obtem o valor do campo "Cedigo" da linha selecionada no DataGridView e
                       // atribui este valor ao atributo "id" da classe Cargos.
            aluguel.Id = dr.GetInt32(0); // Obtem o valor do campo "Nome do Cargo" da linha selecionada no DataGridView e
                                         // atribui este valor ao atributo "nome" da classe Cargos. 
            aluguel.Corretor.Id = dr.GetInt32(1); // Obtem o valor do campo "Departamento" da linha selecionada no DataGridView e 
                                                  // atribui este valor ao atributo "depto" da classe Cargos.
            aluguel.Inquilino.Id = dr.GetInt32(2);
            aluguel.Imovel.Id = dr.GetInt32(2);
            dr.Close(); // Fecha o objeto Sq1DataReader.
            conexao.Close(); // Fecha a conexao com o banco de dados.
            return (aluguel);
            // Retorna o objeto cargos contendo os valores dos tras campos. 

        }

    }
}
