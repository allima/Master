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
    public partial class FormInquilino : Form
    {
        public FormInquilino()
        {
            InitializeComponent();
        }

        private void FormInquilino_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet.inquilino' table. You can move, or remove it, as needed.
            this.inquilinoTableAdapter.Fill(this.masterimovelDataSet.inquilino);

        }

        private void dgv_inquilino_DoubleClick(object sender, EventArgs e)
        {
            // Obtem o codigo do do gride da linha selecionad pelo duplo clique.
            int codigo = Convert.ToInt32(dgv_inquilino.SelectedRows[0].Cells[0].Value.ToString());

            // Instancia a clesse FormeClasseManutencao enviando o codigo da classe como argumento
            FormInquilinoManutencao formInquilinoManutencao = new FormInquilinoManutencao(codigo);
            formInquilinoManutencao.ShowDialog(this);
        }

        private void btn_novo_inquilino_Click(object sender, EventArgs e)
        {
            FormInquilinoManutencao formInquilinoManutencao = new FormInquilinoManutencao();
            formInquilinoManutencao.ShowDialog(this);
        }
    }
}
