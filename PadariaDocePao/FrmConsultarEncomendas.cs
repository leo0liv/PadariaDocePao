using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class FrmConsultarEncomendas : Form
    {
        public FrmConsultarEncomendas()
        {
            InitializeComponent();
        }

        private void FrmConsultarEncomendas_Load(object sender, EventArgs e)
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
                        GROUP BY p.Nome, p.ProducaoDiariaFixa
                        ORDER BY p.Nome";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.SelectCommand.Parameters.AddWithValue("@data", dataFiltro);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
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
                    dataGridView1.DataSource = dt;

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
            if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma encomenda na lista abaixo primeiro.");
                return;
            }

            try
            {
                // Pega o ID da linha selecionada (assumindo que é a primeira coluna [Cód])
                int idEncomenda = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

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

        private void btRetirada_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar que o cliente JÁ RETIROU o pedido?", "Finalizar Pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AlterarStatusEncomenda("Retirada");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se tem linha selecionada
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma encomenda para excluir.");
                return;
            }

            // Pergunta de segurança crítica
            if (MessageBox.Show("ATENÇÃO: Isso apagará o pedido PERMANENTEMENTE do histórico.\n\nDeseja continuar?",
                                "Confirmar Exclusão",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int idEncomenda = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    using (SqlConnection con = ConexaoBD.ObterConexao())
                    {
                        con.Open();
                        string sql = "DELETE FROM Encomenda WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", idEncomenda);
                        cmd.ExecuteNonQuery();
                    }

                    AtualizarTelas(dateTimePicker1.Value); // Recarrega tudo
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }
        private void ConfigurarCoresGrid()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Situação"].Value != null)
                {
                    string status = row.Cells["Situação"].Value.ToString();

                    if (status == "Pronto") row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else if (status == "Retirada") row.DefaultCellStyle.BackColor = Color.LightGray; // Nova cor
                    else if (status == "Cancelado") row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    else row.DefaultCellStyle.BackColor = Color.White; // Pendente
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
