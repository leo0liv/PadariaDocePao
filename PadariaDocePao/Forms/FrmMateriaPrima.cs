using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class FrmMateriaPrima: Form
    {
        public FrmMateriaPrima()
        {
            InitializeComponent();
        }

        private void pBoxPadariaDocePao_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.Show();
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            this.Close();
            frmTelaPrincipal.Show();
        }

        private void matériasPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMateriaPrima frmMateriaPrima = new FrmMateriaPrima();
            frmMateriaPrima.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEncomendas frmEncomendas = new FrmEncomendas();
            frmEncomendas.Show();
        }
    }
}
