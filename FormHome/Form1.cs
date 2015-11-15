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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImovel FormImovel = new FormImovel();
            FormImovel.ShowDialog(this);
        }

        private void inquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInquilino FormInquilino = new FormInquilino();
            FormInquilino.ShowDialog(this);
        }

        private void proprietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProprietario FormProprietario = new FormProprietario();
            FormProprietario.ShowDialog(this);
        }

        private void corretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCorretor FormCorretor = new FormCorretor();
            FormCorretor.ShowDialog(this);
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluguel FormAluguel = new FormAluguel();
            FormAluguel.ShowDialog(this);

        }
    }
}
