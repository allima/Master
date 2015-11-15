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
    public partial class FormProprietario : Form
    {
        public FormProprietario()
        {
            InitializeComponent();
        }

        private void FormProprietario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet.proprietario' table. You can move, or remove it, as needed.
            this.proprietarioTableAdapter.Fill(this.masterimovelDataSet.proprietario);

        }
    }
}
