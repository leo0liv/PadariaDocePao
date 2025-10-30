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
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuPadariaDocePao_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fecha o menu atual
            this.Hide();

            // Reabre o formulário de login
            FrmTelaLogin frmTelaLogin = new FrmTelaLogin();
            frmTelaLogin.Show();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.Show();
        }

        private void btMateriaPrima_Click(object sender, EventArgs e)
        {
            FrmMateriaPrima frmMateriaPrima = new FrmMateriaPrima();
            frmMateriaPrima.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEncomendas frmEncomendas = new FrmEncomendas();
            frmEncomendas.Show();
        }

        private void btEncomendas_Click(object sender, EventArgs e)
        {
            FrmEncomendas frmEncomendas = new FrmEncomendas();
            frmEncomendas.Show();
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.Show();
        }
    }
}
