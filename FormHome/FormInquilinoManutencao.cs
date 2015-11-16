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
    public partial class FormInquilinoManutencao : Form
    {
        private int codigo; // armazena o codigo da classe selecionado no DataGridView 
        private string operacao; //armazena a operacao a ser realizada(inclusao ou alteração /exclusao).

        public FormInquilinoManutencao()
        {
            InitializeComponent();
            this.operacao = "inc";
        }

        public FormInquilinoManutencao(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.operacao = "alt-exc";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bnt_salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
