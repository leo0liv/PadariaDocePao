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
    public partial class FrmReceitas : Form
    {
        public FrmReceitas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmReceitas_Load(object sender, EventArgs e)
        {
            CarregarCombos();
        }

        // 1. Carrega as listas para o usuário escolher
        private void CarregarCombos()
        {
            using (SqlConnection con = ConexaoBD.ObterConexao())
            {
                // Carrega Produtos
                SqlDataAdapter daProd = new SqlDataAdapter("SELECT Id, Nome FROM Produto ORDER BY Nome", con);
                DataTable dtProd = new DataTable();
                daProd.Fill(dtProd);
                comboBoxProduto.DisplayMember = "Nome";
                comboBoxProduto.ValueMember = "Id";
                comboBoxProduto.DataSource = dtProd;

                // Carrega Matérias-Primas
                SqlDataAdapter daMat = new SqlDataAdapter("SELECT Id, Nome FROM MateriaPrima ORDER BY Nome", con);
                DataTable dtMat = new DataTable();
                daMat.Fill(dtMat);
                comboBoxMateriaPrima.DisplayMember = "Nome";
                comboBoxMateriaPrima.ValueMember = "Id";
                comboBoxMateriaPrima.DataSource = dtMat;
            }
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduto.SelectedValue != null && int.TryParse(comboBoxProduto.SelectedValue.ToString(), out int idProduto))
            {
                CarregarReceitaDoProduto(idProduto);
            }
        }
        private void CarregarReceitaDoProduto(int idProduto)
        {
            try
            {
                using (SqlConnection con = ConexaoBD.ObterConexao())
                {
                    con.Open();
                    // Traz o nome do ingrediente e a quantidade usada nessa receita
                    string sql = @"
                        SELECT ft.Id, mp.Nome AS [Ingrediente], ft.Quantidade
                        FROM FichaTecnica ft
                        JOIN MateriaPrima mp ON ft.Id_MateriaPrima = mp.Id
                        WHERE ft.Id_Produto = @idProduto";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.SelectCommand.Parameters.AddWithValue("@idProduto", idProduto);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["Id"].Visible = false; // Esconde o ID técnico
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao carregar receita: " + ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDownQuantidade.Value <= 0)
            {
                MessageBox.Show("Informe uma quantidade maior que zero.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexaoBD.ObterConexao())
                {
                    con.Open();
                    string sql = "INSERT INTO FichaTecnica (Id_Produto, Id_MateriaPrima, Quantidade) VALUES (@idProd, @idMat, @qtd)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idProd", comboBoxProduto.SelectedValue);
                    cmd.Parameters.AddWithValue("@idMat", comboBoxMateriaPrima.SelectedValue);
                    cmd.Parameters.AddWithValue("@qtd", numericUpDownQuantidade.Value);
                    cmd.ExecuteNonQuery();
                }

                // Recarrega a grid para mostrar o novo ingrediente
                CarregarReceitaDoProduto((int)comboBoxProduto.SelectedValue);
                numericUpDownQuantidade.Value = 0; // Reseta o campo de quantidade
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar ingrediente (talvez ele já esteja na receita?): " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se tem algo selecionado na grid de receita
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um ingrediente na lista abaixo para remover.");
                return;
            }

            // Pega o ID da relação Ficha Técnica (que escondemos na grid, mas está lá)
            int idFichaTecnica = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            string nomeIngrediente = dataGridView1.CurrentRow.Cells["Ingrediente"].Value.ToString();

            if (MessageBox.Show("Remover '" + nomeIngrediente + "' desta receita?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = ConexaoBD.ObterConexao())
                    {
                        con.Open();
                        // Deleta apenas essa ligação específica
                        SqlCommand cmd = new SqlCommand("DELETE FROM FichaTecnica WHERE Id = @id", con);
                        cmd.Parameters.AddWithValue("@id", idFichaTecnica);
                        cmd.ExecuteNonQuery();
                    }

                    // Recarrega a grid para mostrar que sumiu
                    CarregarReceitaDoProduto((int)comboBoxProduto.SelectedValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao remover ingrediente: " + ex.Message);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
