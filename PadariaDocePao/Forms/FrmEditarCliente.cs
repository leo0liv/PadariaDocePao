using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PadariaDocePao
{
    public partial class FrmEditarCliente : Form
    {
        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        private void CarregarCliente()
        {
            try
            {
                // Esta linha busca os dados do banco e atualiza a grade
                this.clienteTableAdapter.Fill(this.padariaDocePaoDataSet.Cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os clientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            // 1. Verificar se alguma linha foi selecionada
            if (dataTabelaCliente2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um cliente para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obter o ID do agendamento selecionado
            int idParaAlterar = Convert.ToInt32(dataTabelaCliente2.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);

            // 3. Abrir o formulário de cadastro, passando o ID do veículo a ser alterado
            // Precisaremos criar um novo construtor no seu formulário de cadastro para isso
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente(idParaAlterar);
            if (!frmCadastroCliente.IsDisposed)
            {
                frmCadastroCliente.Show();
            }
            else
            {
                MessageBox.Show("O formulário já foi descartado e não pode ser reaberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //formCadastro.ShowDialog(); // ShowDialog() pausa a tela de consulta até o cadastro ser fechado

            // 4. Após o formulário de cadastro fechar, atualizamos a grade
            CarregarCliente(); // Chame o método que carrega os dados
        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'padariaDocePaoDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.padariaDocePaoDataSet.Cliente);
        }
    }
}
