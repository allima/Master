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
    }
}
