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
        }

        private void bnt_salvar_Click(object sender, EventArgs e)
        {

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

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

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
    }
}
