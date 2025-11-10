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
    public partial class FrmEncomenda : Form
    {
        public FrmEncomenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void CarregarProdutosCombo()
        {
            using (SqlConnection con = ConexaoBD.ObterConexao())
            {
                // Pega só ID e Nome para o ComboBox
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nome FROM Produto ORDER BY Nome", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxEscolherProduto.DataSource = dt;
                comboBoxEscolherProduto.DisplayMember = "Nome"; // O que o usuário vê
                comboBoxEscolherProduto.ValueMember = "Id";     // O que o sistema usa (ID)
            }
        }

        private void FrmEncomenda_Load(object sender, EventArgs e)
        {
            CarregarProdutosCombo();
            // 1. Reseta os limites para evitar conflitos
            dateTimePickerPedido.MinDate = new DateTime(1753, 1, 1);
            dateTimePickerPedido.MaxDate = new DateTime(9998, 12, 31);

            // 2. Define o valor atual para HOJE (para garantir que o valor não fique fora do novo limite)
            dateTimePickerPedido.Value = DateTime.Now;

            // 3. Agora sim, bloqueia datas passadas
            dateTimePickerPedido.MinDate = DateTime.Now;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            // Validação básica
            if (string.IsNullOrWhiteSpace(inputNomeCliente.Text) || comboBoxEscolherProduto.SelectedValue == null)
            {
                MessageBox.Show("Preencha o nome do cliente e escolha um produto.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexaoBD.ObterConexao())
                {
                    con.Open();
                    // Usa uma TRANSAÇÃO: ou salva tudo (cliente e pedido), ou não salva nada se der erro.
                    SqlTransaction transacao = con.BeginTransaction();

                    try
                    {
                        // PASSO 1: Inserir Cliente e pegar o ID dele na hora
                        string sqlCliente = "INSERT INTO Cliente (Nome, Telefone) VALUES (@nome, @tel); SELECT SCOPE_IDENTITY();";
                        SqlCommand cmdCliente = new SqlCommand(sqlCliente, con, transacao);
                        cmdCliente.Parameters.AddWithValue("@nome", inputNomeCliente.Text);
                        cmdCliente.Parameters.AddWithValue("@tel", inputMaskedTelefoneCliente.Text);

                        // Executa e pega o ID gerado para o novo cliente
                        int idClienteNovo = Convert.ToInt32(cmdCliente.ExecuteScalar());

                        // PASSO 2: Inserir a Encomenda usando o ID do cliente
                        string sqlEncomenda = "INSERT INTO Encomenda (DataEntrega, Quantidade, Observacao, Id_Cliente, Id_Produto, Status) VALUES (@data, @qtd, @obs, @idCliente, @idProduto, 'Pendente')";
                        SqlCommand cmdPed = new SqlCommand(sqlEncomenda, con, transacao);
                        cmdPed.Parameters.AddWithValue("@data", dateTimePickerPedido.Value);
                        cmdPed.Parameters.AddWithValue("@qtd", (int)nudQtdPedido.Value);
                        cmdPed.Parameters.AddWithValue("@obs", inputObservacao.Text);
                        cmdPed.Parameters.AddWithValue("@idCliente", idClienteNovo);
                        cmdPed.Parameters.AddWithValue("@idProduto", (int)comboBoxEscolherProduto.SelectedValue);

                        cmdPed.ExecuteNonQuery();

                        // Se chegou até aqui, confirma tudo
                        transacao.Commit();
                        MessageBox.Show("Encomenda registrada com sucesso!");
                        this.Close(); // Fecha a tela
                    }
                    catch (Exception)
                    {
                        transacao.Rollback(); // Desfaz se deu erro no meio
                        throw; // Joga o erro pra cima para mostrar a mensagem
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar encomenda: " + ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultarEncomendas frmConsultarEncomendas = new FrmConsultarEncomendas();
            frmConsultarEncomendas.ShowDialog();
        }
    }
}
