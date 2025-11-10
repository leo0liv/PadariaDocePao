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
    public partial class FrmMateriaPrima : Form
    {
        public FrmMateriaPrima()
        {
            InitializeComponent();
        }

        private void FrmMateriaPrima_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        // --- MÉTODOS AUXILIARES ---
        private void AtualizarGrid()
        {
            try
            {
                using (SqlConnection con = ConexaoBD.ObterConexao())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MateriaPrima ORDER BY Nome", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataTabelaMateriaPrima.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao listar: " + ex.Message); }
        }

        private void LimparCampos()
        {
            inputNomeMateriaPrima.Clear();
            comboBoxUnidade.SelectedIndex = -1;
            nudQtdEstoque.Value = 0;
            inputNomeMateriaPrima.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputNomeMateriaPrima.Text) || comboBoxUnidade.Text == "")
            {
                MessageBox.Show("Preencha o Nome e a Unidade de Medida.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexaoBD.ObterConexao())
                {
                    con.Open();
                    string sql = "INSERT INTO MateriaPrima (Nome, UnidadeMedida, EstoqueAtual) VALUES (@nome, @unidade, @estoque)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nome", inputNomeMateriaPrima.Text.Trim());
                    cmd.Parameters.AddWithValue("@unidade", comboBoxUnidade.Text);
                    cmd.Parameters.AddWithValue("@estoque", nudQtdEstoque.Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ingrediente salvo!");
                LimparCampos();
                AtualizarGrid();
            }
            catch (Exception ex) { MessageBox.Show("Erro ao salvar: " + ex.Message); }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataTabelaMateriaPrima.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item na lista para excluir.");
                return;
            }

            string nome = dataTabelaMateriaPrima.CurrentRow.Cells["Nome"].Value.ToString();
            int id = Convert.ToInt32(dataTabelaMateriaPrima.CurrentRow.Cells["Id"].Value);

            if (MessageBox.Show("Excluir '" + nome + "' do estoque?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool flowControl = NewMethod();
                if (!flowControl)
                {
                    return;
                }
            }

            bool NewMethod()
            {
                {
                    try
                    {
                        using (SqlConnection con = ConexaoBD.ObterConexao())
                        {
                            con.Open();
                            // Verifica se está em uso em alguma receita antes de excluir
                            SqlCommand cmdVerifica = new SqlCommand("SELECT COUNT(*) FROM FichaTecnica WHERE Id_MateriaPrima = @id", con);
                            cmdVerifica.Parameters.AddWithValue("@id", id);
                            int uso = (int)cmdVerifica.ExecuteScalar();

                            if (uso > 0)
                            {
                                MessageBox.Show("Não é possível excluir: este ingrediente já faz parte de uma receita.");
                                return false;
                            }

                            SqlCommand cmdDelete = new SqlCommand("DELETE FROM MateriaPrima WHERE Id = @id", con);
                            cmdDelete.Parameters.AddWithValue("@id", id);
                            cmdDelete.ExecuteNonQuery();
                        }
                        AtualizarGrid();
                    }
                    catch (Exception ex) { MessageBox.Show("Erro ao excluir: " + ex.Message); }
                }

                return true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataTabelaMateriaPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
