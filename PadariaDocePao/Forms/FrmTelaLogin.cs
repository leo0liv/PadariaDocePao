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
    public partial class FrmTelaLogin: Form
    {
        public FrmTelaLogin()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string usuario = mtbLogin.Text;
            string senha = mtbSenha.Text;

            // Exemplo de validação simples (usuário e senha fixos)
            if (usuario == "padaria" && senha == "1234")
            {
                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = "Login realizado com sucesso!";

                // Salva ou limpa o nome do usuário
                if (cbSalvarLogin.Checked)
                {
                    Properties.Settings.Default.UsuarioSalvo = usuario;
                }
                else
                {
                    Properties.Settings.Default.UsuarioSalvo = "";
                }

                // Grava as configurações
                Properties.Settings.Default.Save();

                // Exemplo: abrir novo formulário e esconder o login
                FrmTelaPrincipal telaPrincipal = new FrmTelaPrincipal();
                telaPrincipal.Show();
                this.Hide();
            }
            else
            {
                lblMensagem.ForeColor = System.Drawing.Color.Red;
                lblMensagem.Text = "Usuário ou senha incorretos!";
            }
        }

        private void FrmTelaLogin_Load(object sender, EventArgs e)
        {
            // Carrega o usuário salvo, se existir
            mtbLogin.Text = Properties.Settings.Default.UsuarioSalvo;

            // Marca o checkbox se houver um login salvo
            if (!string.IsNullOrEmpty(mtbLogin.Text))
                cbSalvarLogin.Checked = true;
        }
        private void FrmTelaLogin_Shown(object sender, EventArgs e)
        {
            mtbSenha.Text = ""; // limpa senha ao reabrir
            // 👇 Aqui garantimos o foco correto
            if (!string.IsNullOrEmpty(mtbLogin.Text))
                mtbSenha.Focus();   // Se já tem login salvo → foca senha
            else
                mtbLogin.Focus(); // Senão → foca usuário
        }
    }
}
