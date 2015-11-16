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
    public partial class FormAluguel : Form
    {
        public FormAluguel()
        {
            InitializeComponent();
        }

        private void FormAluguel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet1.locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter1.Fill(this.masterimovelDataSet1.locacao);
            // TODO: This line of code loads data into the 'masterimovelDataSet.locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.Fill(this.masterimovelDataSet.locacao);

        }
    }
}
