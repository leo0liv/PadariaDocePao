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
    }
}
