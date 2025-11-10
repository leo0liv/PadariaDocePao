using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public FrmMateriaPrima(int idMateriaPrima) : this() // O ": this()" chama o construtor padrão primeiro
        {
            _idMateriaPrimaParaAlterar = idMateriaPrima;
            CarregarDadosParaEdicao();
        }

        private void CarregarDadosParaEdicao()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlSelect = "SELECT * FROM MateriaPrima WHERE Id = @id";

                    using (SqlCommand comando = new SqlCommand(sqlSelect, conexao))
                    {
                        comando.Parameters.AddWithValue("@id", _idMateriaPrimaParaAlterar);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Preenche os campos do formulário com os dados do banco
                                inputNomeIgrediente.Text = reader["Nome"].ToString();
                                inputUnidadeMedida.Text = reader["Unidade"].ToString();
                                inputQtdEstoque.Text = reader["QuantidadeEmEstoque"].ToString();
                                inputNivelMinimo.Text = reader["NivelMinimo"].ToString();

                            }
                        }
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

        private void planejamentoDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanejamentoProdução frmPlanejamentoProdução = new FrmPlanejamentoProdução();
            frmPlanejamentoProdução.Show();
        }

        private void FrmMateriaPrima_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'padariaDocePaoDataSet.MateriaPrima'. Você pode movê-la ou removê-la conforme necessário.
            this.materiaPrimaTableAdapter.Fill(this.padariaDocePaoDataSet.MateriaPrima);

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            // Validação básica para garantir que os campos não estão vazios
            if (string.IsNullOrWhiteSpace(inputNomeIgrediente.Text) || string.IsNullOrWhiteSpace(inputQtdEstoque.Text) || string.IsNullOrWhiteSpace(inputQtdEstoque.Text))
            {
                MessageBox.Show("Por favor, preencha os campos Nome Ingreditente e Quantidades.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Materia prima cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                inputNomeIgrediente.Clear();
                                inputUnidadeMedida.Clear();
                                inputQtdEstoque.Clear();
                                inputNivelMinimo.Clear();
                                this.Close();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    {
                try
                {
                    using (SqlConnection conexao = new SqlConnection(connectionString))

                    {

                        conexao.Open(); // abre a conexão e altera os dados
                        string sqlUpdate = @"UPDATE MateriaPrima 
                SET Nome = @nome, Unidade = @unidade, QuantidadeEmEstoque = @quantidade, NivelMinimo = @nivel
                WHERE Id = @id";

                        using (SqlCommand comando = new SqlCommand(sqlUpdate, conexao))
                        {
                            comando.Parameters.AddWithValue("@nome", inputNomeIgrediente.Text);
                            comando.Parameters.AddWithValue("@unidade", inputUnidadeMedida.Text);
                            comando.Parameters.AddWithValue("@quantidade", inputQtdEstoque.Text);
                            comando.Parameters.AddWithValue("@nivel", inputNivelMinimo.Text);
                            comando.Parameters.AddWithValue("@id", _idMateriaPrimaParaAlterar);

                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Materia Prima alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar materia prima: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            // 1. Verificar se alguma linha foi selecionada
            if (dataTabelaMateria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma materia prima para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obter o ID do agendamento selecionado
            int idParaAlterar = Convert.ToInt32(dataTabelaMateria.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);

            // 3. Abrir o formulário de cadastro, passando o ID do veículo a ser alterado
            // Precisaremos criar um novo construtor no seu formulário de cadastro para isso
            FrmMateriaPrima frmMateriaPrima = new FrmMateriaPrima(idParaAlterar);
            if (!frmMateriaPrima.IsDisposed)
            {
                frmMateriaPrima.Show();
            }
            else
            {
                MessageBox.Show("O formulário já foi descartado e não pode ser reaberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataTabelaMateria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma materia prima para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a materia prima selecionada?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Obter o ID do veículo selecionado (ajuste o nome da coluna se for diferente)
                // É mais seguro obter o DataRowView para garantir o tipo de dado correto
                DataRowView drv = (DataRowView)dataTabelaMateria.SelectedRows[0].DataBoundItem;
                int idParaExcluir = (int)drv["Id"]; // Supondo que a coluna no banco se chama 'Id'

                // CORREÇÃO CRÍTICA DA STRING DE CONEXÃO
                string suaConnectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.PadariaDocePaoConnectionString"].ConnectionString;

                try
                {
                    using (SqlConnection conexao = new SqlConnection(suaConnectionString))
                    {
                        conexao.Open();
                        // Ajuste o nome da tabela para "Revisão", como na sua descrição
                        string sqlDelete = "DELETE FROM MateriaPrima WHERE Id = @id";

                        using (SqlCommand comando = new SqlCommand(sqlDelete, conexao))
                        {
                            comando.Parameters.AddWithValue("@id", idParaExcluir);

                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {

        }
    }
}
