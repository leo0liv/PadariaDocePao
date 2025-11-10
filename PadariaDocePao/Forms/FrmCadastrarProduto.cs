using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Essencial para falar com o SQL
using System.Configuration;  // Para ler o App.config
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class FrmCadastrarProduto : Form
    {
        string stringConexao = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.PadariaDocePaoConnectionString"].ConnectionString;
        public FrmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void FrmCadastrarProduto_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        // Função auxiliar para limpar os campos depois de salvar
        private void LimparCampos()
        {
            inputNomeProduto.Clear();
            inputPrecoProduto.Clear();
            nudProduçãoDiaria.Value = 0;
            inputNomeProduto.Focus(); // Põe o cursor de volta no primeiro campo
        }

        private void AtualizarGrid()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();
                    // Consulta simples para pegar os dados
                    string sql = "SELECT Id, Nome, Preco, ProducaoDiariaFixa FROM Produto ORDER BY Nome";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexao);
                    DataTable tabelaProdutos = new DataTable();
                    adaptador.Fill(tabelaProdutos);

                    dataTabelaCadastroProduto.DataSource = tabelaProdutos; // Liga os dados ao Grid na tela
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            // 1. Validação básica (não deixa salvar sem nome)
            if (string.IsNullOrWhiteSpace(inputNomeProduto.Text))
            {
                MessageBox.Show("Por favor, informe o Nome do Produto.");
                inputNomeProduto.Focus();
                return;
            }

            try
            {
                // 2. Prepara a conexão e o comando SQL
                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();
                    string sql = "INSERT INTO Produto (Nome, Preco, ProducaoDiariaFixa) VALUES (@nome, @preco, @producao)";

                    using (SqlCommand comando = new SqlCommand(sql, conexao))
                    {
                        // 3. Passa os valores dos campos para o comando SQL de forma segura (evita SQL Injection)
                        comando.Parameters.AddWithValue("@nome", inputNomeProduto.Text.Trim());

                        // Tenta converter o preço. Se falhar (usuário digitou letra), põe zero.
                        decimal preco;
                        decimal.TryParse(inputPrecoProduto.Text.Replace(",", "."), out preco); // Garante que vírgula ou ponto funcionem
                        comando.Parameters.AddWithValue("@preco", preco);

                        comando.Parameters.AddWithValue("@producao", (int)nudProduçãoDiaria.Value);

                        // 4. Executa o INSERT
                        comando.ExecuteNonQuery();
                    }
                }

                // 5. Sucesso!
                MessageBox.Show("Produto cadastrado com sucesso!");
                LimparCampos();  // Limpa a tela para o próximo
                AtualizarGrid(); // Atualiza a lista lá embaixo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            // 1. Verifica se tem algum produto selecionado na grid
            if (dataTabelaCadastroProduto.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto na lista abaixo para excluir.");
                return;
            }

            // 2. Pega o nome do produto para mostrar na mensagem de confirmação
            // (Assumindo que a coluna "Nome" é a segunda coluna, índice 1. Se for a primeira, use índice 0 ou o nome da coluna)
            string nomeProduto = dataTabelaCadastroProduto.CurrentRow.Cells["Nome"].Value.ToString();
            int idProduto = Convert.ToInt32(dataTabelaCadastroProduto.CurrentRow.Cells["Id"].Value);

            // 3. Pergunta de confirmação
            if (MessageBox.Show("Tem certeza que deseja excluir o produto '" + nomeProduto + "'?\nIsso pode afetar o histórico de encomendas antigas.",
                                "Confirmar Exclusão",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = ConexaoBD.ObterConexao())
                    {
                        con.Open();
                        // Verifica se já existem encomendas para este produto antes de excluir
                        // Isso evita quebrar o histórico (chave estrangeira)
                        string sqlVerifica = "SELECT COUNT(*) FROM Encomenda WHERE Id_Produto = @id";
                        SqlCommand cmdVerifica = new SqlCommand(sqlVerifica, con);
                        cmdVerifica.Parameters.AddWithValue("@id", idProduto);
                        int qtdEncomendas = (int)cmdVerifica.ExecuteScalar();

                        if (qtdEncomendas > 0)
                        {
                            MessageBox.Show("Não é possível excluir este produto pois já existem encomendas registradas para ele.\n\nSugestão: Em vez de excluir, altere o nome para 'DESATIVADO - " + nomeProduto + "'.");
                            return;
                        }

                        // Se não tiver encomendas, pode excluir
                        string sqlDelete = "DELETE FROM Produto WHERE Id = @id";
                        SqlCommand cmdDelete = new SqlCommand(sqlDelete, con);
                        cmdDelete.Parameters.AddWithValue("@id", idProduto);
                        cmdDelete.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produto excluído com sucesso!");
                    AtualizarGrid();     // Recarrega a lista
                    LimparCampos();      // Limpa os campos de texto se tiver algo escrito
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir produto: " + ex.Message);
                }
            }
        }
    }
}
