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
    public partial class FormAluguelManutencao : Form
    {
        private int codigo; // armazena o codigo da classe selecionado no DataGridView 
        private string operacao; //armazena a operacao a ser realizada(inclusao ou alteração /exclusao).

        //Construdo chamado quando o usuario clica no botao "Novo **classe"(inclusão)
        public FormAluguelManutencao()
        {
            InitializeComponent();
            this.operacao = "inc";
        }

        //construdo chamado quando o usuario dá duplo clique em uma linha  do datagridView (alteração ou exclusao).
        public FormAluguelManutencao(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.operacao = "alt-exc";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
