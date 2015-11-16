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

        public static Inquilino Consultar(int codigo)
        {
            Inquilino inquilino = new Inquilino(); // Instancia a classe Cargos. 
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
            inquilino.Id = dr.GetInt32(0); // Obtem o valor do campo "Nome do Cargo" da linha selecionada no DataGridView e
                                           // atribui este valor ao atributo "nome" da classe Cargos. 
            inquilino.Id = dr.GetInt32(1); // Obtem o valor do campo "Departamento" da linha selecionada no DataGridView e 
                                           // atribui este valor ao atributo "depto" da classe Cargos.
            inquilino.Nome = dr.GetString(2);
            inquilino.Email = dr.GetString(3);
            inquilino.Endereco = dr.GetString(4);
            inquilino.Cpf = dr.GetString(5);
            inquilino.Rg = dr.GetString(6);
            inquilino.Telefone = dr.GetString(6);
            dr.Close(); // Fecha o objeto Sq1DataReader.
            conexao.Close(); // Fecha a conexao com o banco de dados.
            return (inquilino);
            // Retorna o objeto cargos contendo os valores dos tras campos. 

        }


    }
}
