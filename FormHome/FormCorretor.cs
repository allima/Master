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
    public partial class FormCorretor : Form
    {
        public FormCorretor()
        {
            InitializeComponent();
        }

        private void FormCorretor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet1.corretor' table. You can move, or remove it, as needed.
          //  this.corretorTableAdapter1.Fill(this.masterimovelDataSet1.corretor);
            // TODO: This line of code loads data into the 'masterimovelDataSet.corretor' table. You can move, or remove it, as needed.
           // this.corretorTableAdapter.Fill(this.masterimovelDataSet.corretor);

        }

        private void btn_novo_corretor_Click(object sender, EventArgs e)
        {
            FormCorretorManutencao FormCorretorManutencao = new FormCorretorManutencao();
            FormCorretorManutencao.ShowDialog(this);
        }

        private void dgv_Corretor_DoubleClick(object sender, EventArgs e)
        {
            // Obtem o codigo do do gride da linha selecionad pelo duplo clique.
            int codigo = Convert.ToInt32(dgv_Corretor.SelectedRows[0].Cells[0].Value.ToString());

            // Instancia a clesse FormeClasseManutencao enviando o codigo da classe como argumento
            FormCorretorManutencao FormCorretorManutencao = new FormCorretorManutencao(codigo);
            FormCorretorManutencao.ShowDialog(this);
        }

        private void FormCorretor_Activated(object sender, EventArgs e)
        {
            this.corretorTableAdapter1.Fill(this.masterimovelDataSet1.corretor);
        }
    }
}
