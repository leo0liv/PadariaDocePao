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
    public partial class FrmRelatorios: Form
    {
        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaPrincipal telaPrincipal = new FrmTelaPrincipal();
            telaPrincipal.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.Show();
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

        private void planejamentoDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanejamentoProdução frmPlanejamentoProdução = new FrmPlanejamentoProdução();
            frmPlanejamentoProdução.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
