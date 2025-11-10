namespace PadariaDocePao
{
    partial class FrmCadastrarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpBoxCasatrarProduto = new System.Windows.Forms.GroupBox();
            this.nudProduçãoDiaria = new System.Windows.Forms.NumericUpDown();
            this.inputPrecoProduto = new System.Windows.Forms.TextBox();
            this.inputNomeProduto = new System.Windows.Forms.TextBox();
            this.lbProduçãoDiaria = new System.Windows.Forms.Label();
            this.lbPreçoProduto = new System.Windows.Forms.Label();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.dataTabelaCadastroProduto = new System.Windows.Forms.DataGridView();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.gpBoxCasatrarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProduçãoDiaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaCadastroProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoxCasatrarProduto
            // 
            this.gpBoxCasatrarProduto.Controls.Add(this.nudProduçãoDiaria);
            this.gpBoxCasatrarProduto.Controls.Add(this.inputPrecoProduto);
            this.gpBoxCasatrarProduto.Controls.Add(this.inputNomeProduto);
            this.gpBoxCasatrarProduto.Controls.Add(this.lbProduçãoDiaria);
            this.gpBoxCasatrarProduto.Controls.Add(this.lbPreçoProduto);
            this.gpBoxCasatrarProduto.Controls.Add(this.lbNomeProduto);
            this.gpBoxCasatrarProduto.Location = new System.Drawing.Point(12, 23);
            this.gpBoxCasatrarProduto.Name = "gpBoxCasatrarProduto";
            this.gpBoxCasatrarProduto.Size = new System.Drawing.Size(776, 146);
            this.gpBoxCasatrarProduto.TabIndex = 0;
            this.gpBoxCasatrarProduto.TabStop = false;
            this.gpBoxCasatrarProduto.Text = "Cadastrar Produto";
            // 
            // nudProduçãoDiaria
            // 
            this.nudProduçãoDiaria.Location = new System.Drawing.Point(418, 51);
            this.nudProduçãoDiaria.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProduçãoDiaria.Name = "nudProduçãoDiaria";
            this.nudProduçãoDiaria.Size = new System.Drawing.Size(286, 20);
            this.nudProduçãoDiaria.TabIndex = 5;
            // 
            // inputPrecoProduto
            // 
            this.inputPrecoProduto.Location = new System.Drawing.Point(31, 93);
            this.inputPrecoProduto.Name = "inputPrecoProduto";
            this.inputPrecoProduto.Size = new System.Drawing.Size(311, 20);
            this.inputPrecoProduto.TabIndex = 4;
            // 
            // inputNomeProduto
            // 
            this.inputNomeProduto.Location = new System.Drawing.Point(31, 51);
            this.inputNomeProduto.Name = "inputNomeProduto";
            this.inputNomeProduto.Size = new System.Drawing.Size(311, 20);
            this.inputNomeProduto.TabIndex = 3;
            // 
            // lbProduçãoDiaria
            // 
            this.lbProduçãoDiaria.AutoSize = true;
            this.lbProduçãoDiaria.Location = new System.Drawing.Point(415, 35);
            this.lbProduçãoDiaria.Name = "lbProduçãoDiaria";
            this.lbProduçãoDiaria.Size = new System.Drawing.Size(112, 13);
            this.lbProduçãoDiaria.TabIndex = 2;
            this.lbProduçãoDiaria.Text = "Produção Diária (Qtd):";
            // 
            // lbPreçoProduto
            // 
            this.lbPreçoProduto.AutoSize = true;
            this.lbPreçoProduto.Location = new System.Drawing.Point(28, 77);
            this.lbPreçoProduto.Name = "lbPreçoProduto";
            this.lbPreçoProduto.Size = new System.Drawing.Size(93, 13);
            this.lbPreçoProduto.TabIndex = 1;
            this.lbPreçoProduto.Text = "Preço do Produto:";
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Location = new System.Drawing.Point(28, 35);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(93, 13);
            this.lbNomeProduto.TabIndex = 0;
            this.lbNomeProduto.Text = "Nome do Produto:";
            // 
            // dataTabelaCadastroProduto
            // 
            this.dataTabelaCadastroProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabelaCadastroProduto.Location = new System.Drawing.Point(12, 175);
            this.dataTabelaCadastroProduto.Name = "dataTabelaCadastroProduto";
            this.dataTabelaCadastroProduto.Size = new System.Drawing.Size(776, 212);
            this.dataTabelaCadastroProduto.TabIndex = 1;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(227, 399);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(183, 39);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(605, 399);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(183, 39);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(416, 399);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(183, 39);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FrmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dataTabelaCadastroProduto);
            this.Controls.Add(this.gpBoxCasatrarProduto);
            this.Name = "FrmCadastrarProduto";
            this.Text = "FrmCadastrarProduto";
            this.Load += new System.EventHandler(this.FrmCadastrarProduto_Load);
            this.gpBoxCasatrarProduto.ResumeLayout(false);
            this.gpBoxCasatrarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProduçãoDiaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaCadastroProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxCasatrarProduto;
        private System.Windows.Forms.DataGridView dataTabelaCadastroProduto;
        private System.Windows.Forms.NumericUpDown nudProduçãoDiaria;
        private System.Windows.Forms.TextBox inputPrecoProduto;
        private System.Windows.Forms.TextBox inputNomeProduto;
        private System.Windows.Forms.Label lbProduçãoDiaria;
        private System.Windows.Forms.Label lbPreçoProduto;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
    }
}