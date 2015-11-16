using FormHome.controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHome
{
    public partial class FormCorretorManutencao : Form
    {
        private int codigo; // armazena o codigo da classe selecionado no DataGridView 
        private string operacao; //armazena a operacao a ser realizada(inclusao ou alteração /exclusao).

        //Construdo chamado quando o usuario clica no botao "Novo **classe"(inclusão)
        public FormCorretorManutencao()
        {
            InitializeComponent();
            this.operacao = "inc";
        }

        //construdo chamado quando o usuario dá duplo clique em uma linha  do datagridView (alteração ou exclusao).
        public FormCorretorManutencao(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.operacao = "alt-exc";
            Carrega();

        }

        private void bnt_salvar_Click(object sender, EventArgs e)
        {
            Corretor corretor = new Corretor(); // Instancia a classe Cargos. 
                                                // Atribui o valor do campo "Nome do Cargo" ao atributo "nome" da classe Cargos. 
            corretor.Nome = txtb_nome.Text; // Atribui o valor do campo "Departamento" ao atributo "depto" da classe Cargos. 
            corretor.Endereco = txtb_endereco.Text;
            corretor.Cpf = txtb_cpf.Text;
            corretor.Rg = txtb_rg.Text;
            corretor.Email = txtb_email.Text;
            corretor.Telefone = txtb_telefone.Text;

            if (operacao == "inc")
            { // Se operacao for de inclusao. 
              // Chama o metodo Incluir da classe CargosOperacoes, passando como argumento
              // contendo os dados do cargo a ser incluido. 
                CorretorOperacoes.Incluir(corretor);
            }
            else
            { // Se operacao for de alteracao. 
              // Atribui o valor do campo "Cadigo" (recebido pelo construtor) ao atributo ' 
                corretor.Id = codigo; // Chama o metodo Alterar da classe CargosOperacoes, passando como argumento
                                      // contendo os dados do cargo a ser alterado. 
                CorretorOperacoes.Alterar(corretor);
            }
            this.Close(); // Fecha o formulario de manutencao apps salvar. 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtb_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {


            // Emite uma mensagem para confirmacao da exclus5o. 
            if (MessageBox.Show("Confirma a exclusgo deste cargo?", "Atencão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Chama o metodo Excluir da classe CargosOperacoes,
                // passando como argumento o cedigo do cargo a ser excluido.
                CorretorOperacoes.Excluir(codigo);
                this.Close(); // Fecha o formulario de manutenc5o apes excluir. 
            }

        }

        private void txtb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtb_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_rg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Carrega()
        {
            Corretor cor = CorretorOperacoes.Consultar(codigo);
            txtb_nome.Text = cor.Nome.ToString();
            txtb_endereco.Text = cor.Endereco.ToString();
            txtb_cpf.Text = cor.Cpf.ToString();
            txtb_rg.Text = cor.Rg.ToString();
            txtb_email.Text = cor.Email.ToString();
            txtb_telefone.Text = cor.Telefone.ToString();

        }

    }
}
