using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class FrmCadastroCliente: Form
    {
        private int? _idClienteParaAlterar = null;
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        public FrmCadastroCliente(int idCadastrarCliente) : this() // O ": this()" chama o construtor padrão primeiro
        {
            _idClienteParaAlterar = idCadastrarCliente;
            CarregarDadosParaEdicao();
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            this.Close();
            frmTelaPrincipal.Show();
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void planejamentoDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanejamentoProdução frmPlanejamentoProdução = new FrmPlanejamentoProdução();
            frmPlanejamentoProdução.Show();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'padariaDocePaoDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.padariaDocePaoDataSet.Cliente);

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

        private void CarregarDadosParaEdicao()
        {
            this.Text = "Alterar Cliente"; // Muda o título do formulário
            pBoxPadariaDocePao.Text = "Alterar Cliente";// Muda o título da página lbCadastro

            string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.PadariaDocePaoConnectionString"].ConnectionString;


            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlSelect = "SELECT * FROM Cliente WHERE Id = @id";

                    using (SqlCommand comando = new SqlCommand(sqlSelect, conexao))
                    {
                        comando.Parameters.AddWithValue("@id", _idClienteParaAlterar);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Preenche os campos do formulário com os dados do banco
                                inputNomeCliente.Text = reader["Nome"].ToString();
                                inputTelefoneCliente.Text = reader["Telefone"].ToString();
                                inputEnderecoCliente.Text = reader["Endereco"].ToString();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Fecha o formulário se não conseguir carregar os dados
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            // Validação básica para garantir que os campos não estão vazios
            if (string.IsNullOrWhiteSpace(inputNomeCliente.Text) || string.IsNullOrWhiteSpace(inputTelefoneCliente.Text) || string.IsNullOrWhiteSpace(inputTelefoneCliente.Text))
            {
                MessageBox.Show("Por favor, preencha os campos Nome e telefone.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //conexão com o banco de dados
            string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.PadariaDocePaoConnectionString"].ConnectionString;

            // A lógica principal: o formulário está em modo de cadastro ou de alteração?
            if (_idClienteParaAlterar == null)
            {
                // ===================================================================
                // MODO CADASTRO (INSERT)
                // ===================================================================
                try
                {
                    string suaConnectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.PadariaDocePaoConnectionString"].ConnectionString;

                    using (SqlConnection conexao = new SqlConnection(suaConnectionString))
                    {
                        conexao.Open();// abre a conexão e insere os dados
                        string sqlInsert = @"INSERT INTO Cliente (Nome, Telefone, Endereco) VALUES (@nome, @telefone, @endereco)";

                        using (SqlCommand comando = new SqlCommand(sqlInsert, conexao))
                        {
                            comando.Parameters.AddWithValue("@Nome", inputNomeCliente.Text);
                            comando.Parameters.AddWithValue("@Telefone", inputTelefoneCliente.Text);
                            comando.Parameters.AddWithValue("@Endereco", inputEnderecoCliente.Text);

                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                inputNomeCliente.Clear();
                                inputEnderecoCliente.Clear();
                                inputTelefoneCliente.Clear();
                                this.Close();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Erro ao cadastrar: O Nome '" + inputNomeCliente.Text + "' já existe.", "Erro de Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro de banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // ===================================================================
                // MODO ALTERAÇÃO (UPDATE) - para realizar as alterações 
                // ===================================================================
                try
                {
                    using (SqlConnection conexao = new SqlConnection(connectionString))

                    {

                        conexao.Open(); // abre a conexão e altera os dados
                        string sqlUpdate = @"UPDATE Cliente 
                SET Nome = @nome, Telefone = @telefone, endereco = @endereco
                WHERE Id = @id";

                        using (SqlCommand comando = new SqlCommand(sqlUpdate, conexao))
                        {
                            comando.Parameters.AddWithValue("@nome", inputNomeCliente.Text);
                            comando.Parameters.AddWithValue("@telefone", inputTelefoneCliente.Text);
                            comando.Parameters.AddWithValue("@endereco", inputEnderecoCliente.Text);
                            comando.Parameters.AddWithValue("@id", _idClienteParaAlterar);

                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Cliente alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar um cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btEditarCliente_Click(object sender, EventArgs e)
        {
            // 1. Verificar se alguma linha foi selecionada
            if (dataTabelaCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um cliente para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obter o ID do agendamento selecionado
            int idParaAlterar = Convert.ToInt32(dataTabelaCliente.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);

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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataTabelaCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma revisão para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a revisão selecionada?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Obter o ID do veículo selecionado (ajuste o nome da coluna se for diferente)
                // É mais seguro obter o DataRowView para garantir o tipo de dado correto
                DataRowView drv = (DataRowView)dataTabelaCliente.SelectedRows[0].DataBoundItem;
                int idParaExcluir = (int)drv["Id"]; // Supondo que a coluna no banco se chama 'Id'

                // CORREÇÃO CRÍTICA DA STRING DE CONEXÃO
                string suaConnectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.PadariaDocePaoConnectionString"].ConnectionString;

                try
                {
                    using (SqlConnection conexao = new SqlConnection(suaConnectionString))
                    {
                        conexao.Open();
                        // Ajuste o nome da tabela para "Revisão", como na sua descrição
                        string sqlDelete = "DELETE FROM Cliente WHERE Id = @id";

                        using (SqlCommand comando = new SqlCommand(sqlDelete, conexao))
                        {
                            comando.Parameters.AddWithValue("@id", idParaExcluir);

                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // AQUI ESTÁ A RESPOSTA: Chame o método para atualizar a grade
                                CarregarCliente();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir um cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
