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
    public partial class FrmPainelProducao : Form
    {
        public FrmPainelProducao()
        {
            InitializeComponent();
        }

        private void FrmPainelProducao_Load(object sender, EventArgs e)
        {
            // Carrega tudo com a data de HOJE ao abrir
            AtualizarTelas(DateTime.Today);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizarTelas(dateTimePicker1.Value);
        }

        // Método central para atualizar as duas grids
        private void AtualizarTelas(DateTime data)
        {
            CarregarResumoProducao(data);
            CarregarListaEncomendas(data);
        }

        private void BaixarEstoque(int idProduto, int quantidadeProduzida, SqlConnection con, SqlTransaction transacao)
        {
            try
            {
                // 1. TESTE: Verifica quantas receitas existem para este produto
                string sqlVerifica = "SELECT COUNT(*) FROM FichaTecnica WHERE Id_Produto = @idProduto";
                SqlCommand cmdVerifica = new SqlCommand(sqlVerifica, con, transacao);
                cmdVerifica.Parameters.AddWithValue("@idProduto", idProduto);
                int ingredientesEncontrados = (int)cmdVerifica.ExecuteScalar();

                if (ingredientesEncontrados == 0)
                {
                    MessageBox.Show("ATENÇÃO: Nenhuma receita encontrada para o produto ID: " + idProduto + ". Nada será descontado.");
                    return;
                }

                // 2. Se encontrou, tenta fazer a baixa
                string sqlBaixa = @"
            UPDATE MateriaPrima
            SET EstoqueAtual = EstoqueAtual - (ft.Quantidade * @qtdProduzida)
            FROM MateriaPrima mp
            INNER JOIN FichaTecnica ft ON mp.Id = ft.Id_MateriaPrima
            WHERE ft.Id_Produto = @idProduto";

                SqlCommand cmdBaixa = new SqlCommand(sqlBaixa, con, transacao);
                cmdBaixa.Parameters.AddWithValue("@idProduto", idProduto);
                cmdBaixa.Parameters.AddWithValue("@qtdProduzida", quantidadeProduzida);
                int linhasAfetadas = cmdBaixa.ExecuteNonQuery();

                // 3. Conta se deu certo
                MessageBox.Show("Sucesso! Estoque atualizado para " + linhasAfetadas + " ingredientes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO CRÍTICO ao baixar estoque: " + ex.Message);
                throw; // Joga o erro pra cima para cancelar a transação
            }
        }

        // SEU MÉTODO ANTIGO (Mantivemos para ver o total)
        private void CarregarResumoProducao(DateTime dataFiltro)
        {
            try
            {
                using (SqlConnection con = ConexaoBD.ObterConexao())
                {
                    con.Open();
                    // Nota: Adicionei 'e.Status != 'Cancelado'' para não somar os cancelados na produção
                    string sql = @"
                        SELECT
                            p.Nome AS [Produto],
                            ISNULL(SUM(e.Quantidade), 0) AS [Qtd Encomenda],
                            (p.ProducaoDiariaFixa + ISNULL(SUM(CASE WHEN e.Status != 'Cancelado' THEN e.Quantidade ELSE 0 END), 0)) AS [TOTAL A PRODUZIR]
                        FROM Produto p
                        LEFT JOIN Encomenda e ON p.Id = e.Id_Produto AND CAST(e.DataEntrega AS DATE) = CAST(@data AS DATE)
                        GROUP BY p.Id, p.Nome, p.ProducaoDiariaFixa
                        ORDER BY p.Nome";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.SelectCommand.Parameters.AddWithValue("@data", dataFiltro);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = null;
                    dataGridView2.Columns.Clear(); // Apaga qualquer coluna velha que ficou "grudada"
                    dataGridView2.AutoGenerateColumns = true; // Garante que vai gerar novas
                    dataGridView2.DataSource = dt;
                    dataGridView2.AutoGenerateColumns = true; // Garante que ele crie as colunas sozinho
                    dataGridView2.Refresh(); // Força redesenhar
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro no resumo: " + ex.Message); }
        }

        // NOVO MÉTODO: Lista individual para você clicar e marcar como pronto
        private void CarregarListaEncomendas(DateTime dataFiltro)
        {
            try
            {
                using (SqlConnection con = ConexaoBD.ObterConexao())
                {
                    con.Open();
                    // Trazemos o ID (oculto) para saber qual atualizar
                    string sql = @"
                        SELECT
                            e.Id AS [Cód],
                            c.Nome AS [Cliente],
                            p.Nome AS [Produto],
                            e.Quantidade AS [Qtd],
                            e.DataEntrega AS [Hora],
                            e.Status AS [Situação]
                        FROM Encomenda e
                        JOIN Cliente c ON e.Id_Cliente = c.Id
                        JOIN Produto p ON e.Id_Produto = p.Id
                        WHERE CAST(e.DataEntrega AS DATE) = CAST(@data AS DATE)
                        ORDER BY e.DataEntrega";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.SelectCommand.Parameters.AddWithValue("@data", dataFiltro);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    dataGridView2.AutoGenerateColumns = true; // Garante que ele crie as colunas sozinho
                    dataGridView2.Refresh(); // Força redesenhar

                    // Perfumaria: Colorir as linhas dependendo do status
                    ConfigurarCoresGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro na lista: " + ex.Message); }
        }

        // Método auxiliar para mudar o status (usado pelos dois botões)
        private void AlterarStatusEncomenda(string novoStatus)
        {
            // Verifica se tem alguma linha selecionada na grid nova
            if (dataGridView2.SelectedRows.Count == 0 && dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma encomenda na lista abaixo primeiro.");
                return;
            }

            try
            {
                // Pega o ID da linha selecionada (assumindo que é a primeira coluna [Cód])
                int idEncomenda = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                using (SqlConnection con = ConexaoBD.ObterConexao())
                {
                    con.Open();
                    string sql = "UPDATE Encomenda SET Status = @status WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@status", novoStatus);
                    cmd.Parameters.AddWithValue("@id", idEncomenda);
                    cmd.ExecuteNonQuery();
                }

                // Atualiza tudo para refletir a mudança
                AtualizarTelas(dateTimePicker1.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar status: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarCoresGrid()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Situação"].Value != null)
                {
                    string status = row.Cells["Situação"].Value.ToString();
                    if (status == "Pronto") row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else if (status == "Cancelado") row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    else row.DefaultCellStyle.BackColor = Color.White; // Pendente
                }
            }
        }

        private void btPronto_Click(object sender, EventArgs e)
        {
            // 1. Validação: Tem linha selecionada?
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma encomenda primeiro.");
                return;
            }

            if (MessageBox.Show("Confirmar produção? Isso baixará o estoque.", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = ConexaoBD.ObterConexao())
                {
                    con.Open();
                    SqlTransaction transacao = con.BeginTransaction(); // Segurança: tudo ou nada

                    try
                    {
                        // 2. PEGAR OS DADOS NECESSÁRIOS DA GRID
                        // ATENÇÃO: Certifique-se que sua consulta SQL original traz essas colunas!
                        // Você pode precisar adicionar Id_Produto na sua consulta SELECT se ela não tiver.
                        int idEncomenda = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Cód"].Value);

                        // Precisamos do ID do Produto e da Quantidade para a baixa
                        // Se eles não estiverem na grid, temos que buscar no banco rapidinho:
                        SqlCommand cmdDados = new SqlCommand("SELECT Id_Produto, Quantidade FROM Encomenda WHERE Id = @id", con, transacao);
                        cmdDados.Parameters.AddWithValue("@id", idEncomenda);

                        using (SqlDataReader leitor = cmdDados.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                int idProduto = Convert.ToInt32(leitor["Id_Produto"]);
                                int quantidade = Convert.ToInt32(leitor["Quantidade"]);
                                leitor.Close(); // Fecha o leitor para poder rodar outros comandos

                                // 3. *** AQUI ESTÁ A CHAMADA DA FUNÇÃO ***
                                BaixarEstoque(idProduto, quantidade, con, transacao);
                            }
                            else
                            {
                                throw new Exception("Encomenda não encontrada no banco.");
                            }
                        }

                        // 4. Se a baixa funcionou, atualiza o status da encomenda
                        string sqlUpdate = "UPDATE Encomenda SET Status = 'Pronto' WHERE Id = @id";
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con, transacao);
                        cmdUpdate.Parameters.AddWithValue("@id", idEncomenda);
                        cmdUpdate.ExecuteNonQuery();

                        transacao.Commit(); // Confirma tudo!
                        MessageBox.Show("Pronto! Estoque atualizado.");
                        AtualizarTelas(dateTimePicker1.Value); // Recarrega a tela
                    }
                    catch (Exception ex)
                    {
                        transacao.Rollback(); // Deu erro? Desfaz tudo, inclusive a baixa de estoque.
                        MessageBox.Show("Erro ao finalizar: " + ex.Message);
                    }
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja CANCELAR este pedido?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                AlterarStatusEncomenda("Cancelado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
