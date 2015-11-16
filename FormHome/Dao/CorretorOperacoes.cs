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
                "nome = '" + corretor.Nome + "', " +
                "email = '" + corretor.Email + "', " +
                "endereco = '" + corretor.Endereco + "', " +
                "cpf = '" + corretor.Cpf + "'" +
                "rg = '" + corretor.Rg + "', " +
                "telefone = '" + corretor.Telefone + "', " +
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
            string comando = @"delete from aluguel where id = " +  // Instrucao SQL a ser executada. 
                corretor.Id.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instruc5o SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static Corretor Consultar(int codigo)
        {
            Corretor corretor = new Corretor(); // Instancia a classe Cargos. 
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
            corretor.Id = dr.GetInt32(0); // Obtem o valor do campo "Nome do Cargo" da linha selecionada no DataGridView e
                                          // atribui este valor ao atributo "nome" da classe Cargos. 
            corretor.Id = dr.GetInt32(1); // Obtem o valor do campo "Departamento" da linha selecionada no DataGridView e 
                                                   // atribui este valor ao atributo "depto" da classe Cargos.
            corretor.Nome = dr.GetString(2);
            corretor.Email = dr.GetString(3);
            corretor.Endereco = dr.GetString(4);
            corretor.Cpf = dr.GetString(5);
            corretor.Rg = dr.GetString(6);
            corretor.Telefone = dr.GetString(6);
            dr.Close(); // Fecha o objeto Sq1DataReader.
            conexao.Close(); // Fecha a conexao com o banco de dados.
            return (corretor);
            // Retorna o objeto cargos contendo os valores dos tras campos. 

        }



    }
}
