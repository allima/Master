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
    public partial class FormImovelManutencao : Form
    {
        private int codigo;

        public FormImovelManutencao()
        {
            InitializeComponent();
        }

        public FormImovelManutencao(int codigo)
        {
            this.codigo = codigo;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
