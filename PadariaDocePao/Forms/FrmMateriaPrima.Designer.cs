namespace PadariaDocePao
{
    partial class FrmMateriaPrima
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
            this.menuPadariaDocePao = new System.Windows.Forms.MenuStrip();
            this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matériasPrimasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planejamentoDeProduçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbEstoque = new System.Windows.Forms.Label();
            this.lbUnidadeMedida = new System.Windows.Forms.Label();
            this.inputQtdEstoque = new System.Windows.Forms.TextBox();
            this.inputUnidadeMedida = new System.Windows.Forms.TextBox();
            this.inputNomeIgrediente = new System.Windows.Forms.TextBox();
            this.lbIngrediente = new System.Windows.Forms.Label();
            this.lbNivelMinimo = new System.Windows.Forms.Label();
            this.inputNivelMinimo = new System.Windows.Forms.TextBox();
            this.dataView2 = new System.Windows.Forms.DataGridView();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.pBoxPadariaDocePao = new System.Windows.Forms.PictureBox();
            this.menuPadariaDocePao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPadariaDocePao)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPadariaDocePao
            // 
            this.menuPadariaDocePao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.menuPadariaDocePao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPadariaDocePao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.matériasPrimasToolStripMenuItem,
            this.eToolStripMenuItem,
            this.planejamentoDeProduçãoToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuPadariaDocePao.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuPadariaDocePao.Location = new System.Drawing.Point(0, 0);
            this.menuPadariaDocePao.Name = "menuPadariaDocePao";
            this.menuPadariaDocePao.Size = new System.Drawing.Size(800, 23);
            this.menuPadariaDocePao.TabIndex = 3;
            this.menuPadariaDocePao.Text = "menuPadariaDocePao";
            // 
            // inícioToolStripMenuItem
            // 
            this.inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            this.inícioToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.inícioToolStripMenuItem.Text = "Início";
            this.inícioToolStripMenuItem.Click += new System.EventHandler(this.inícioToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // matériasPrimasToolStripMenuItem
            // 
            this.matériasPrimasToolStripMenuItem.Name = "matériasPrimasToolStripMenuItem";
            this.matériasPrimasToolStripMenuItem.Size = new System.Drawing.Size(105, 19);
            this.matériasPrimasToolStripMenuItem.Text = "Matérias-Primas";
            this.matériasPrimasToolStripMenuItem.Click += new System.EventHandler(this.matériasPrimasToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(87, 19);
            this.eToolStripMenuItem.Text = "Encomendas";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // planejamentoDeProduçãoToolStripMenuItem
            // 
            this.planejamentoDeProduçãoToolStripMenuItem.Name = "planejamentoDeProduçãoToolStripMenuItem";
            this.planejamentoDeProduçãoToolStripMenuItem.Size = new System.Drawing.Size(162, 19);
            this.planejamentoDeProduçãoToolStripMenuItem.Text = "Planejamento de Produção";
            this.planejamentoDeProduçãoToolStripMenuItem.Click += new System.EventHandler(this.planejamentoDeProduçãoToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 19);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 19);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lbEstoque
            // 
            this.lbEstoque.AutoSize = true;
            this.lbEstoque.Location = new System.Drawing.Point(592, 36);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(152, 13);
            this.lbEstoque.TabIndex = 17;
            this.lbEstoque.Text = "QUANTIDADE EM ESTOQUE";
            // 
            // lbUnidadeMedida
            // 
            this.lbUnidadeMedida.AutoSize = true;
            this.lbUnidadeMedida.Location = new System.Drawing.Point(391, 36);
            this.lbUnidadeMedida.Name = "lbUnidadeMedida";
            this.lbUnidadeMedida.Size = new System.Drawing.Size(119, 13);
            this.lbUnidadeMedida.TabIndex = 16;
            this.lbUnidadeMedida.Text = "UNIDADE DE MEDIDA";
            // 
            // inputQtdEstoque
            // 
            this.inputQtdEstoque.Location = new System.Drawing.Point(561, 52);
            this.inputQtdEstoque.Name = "inputQtdEstoque";
            this.inputQtdEstoque.Size = new System.Drawing.Size(205, 20);
            this.inputQtdEstoque.TabIndex = 15;
            // 
            // inputUnidadeMedida
            // 
            this.inputUnidadeMedida.Location = new System.Drawing.Point(350, 52);
            this.inputUnidadeMedida.Name = "inputUnidadeMedida";
            this.inputUnidadeMedida.Size = new System.Drawing.Size(205, 20);
            this.inputUnidadeMedida.TabIndex = 14;
            // 
            // inputNomeIgrediente
            // 
            this.inputNomeIgrediente.Location = new System.Drawing.Point(139, 52);
            this.inputNomeIgrediente.Name = "inputNomeIgrediente";
            this.inputNomeIgrediente.Size = new System.Drawing.Size(205, 20);
            this.inputNomeIgrediente.TabIndex = 13;
            // 
            // lbIngrediente
            // 
            this.lbIngrediente.AutoSize = true;
            this.lbIngrediente.Location = new System.Drawing.Point(177, 36);
            this.lbIngrediente.Name = "lbIngrediente";
            this.lbIngrediente.Size = new System.Drawing.Size(135, 13);
            this.lbIngrediente.TabIndex = 12;
            this.lbIngrediente.Text = "NOME DO INGREDIENTE";
            // 
            // lbNivelMinimo
            // 
            this.lbNivelMinimo.AutoSize = true;
            this.lbNivelMinimo.Location = new System.Drawing.Point(177, 86);
            this.lbNivelMinimo.Name = "lbNivelMinimo";
            this.lbNivelMinimo.Size = new System.Drawing.Size(132, 13);
            this.lbNivelMinimo.TabIndex = 18;
            this.lbNivelMinimo.Text = "NIVEL MINIMO (ALERTA)";
            // 
            // inputNivelMinimo
            // 
            this.inputNivelMinimo.Location = new System.Drawing.Point(139, 102);
            this.inputNivelMinimo.Name = "inputNivelMinimo";
            this.inputNivelMinimo.Size = new System.Drawing.Size(205, 20);
            this.inputNivelMinimo.TabIndex = 19;
            // 
            // dataView2
            // 
            this.dataView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView2.Location = new System.Drawing.Point(12, 149);
            this.dataView2.Name = "dataView2";
            this.dataView2.Size = new System.Drawing.Size(776, 225);
            this.dataView2.TabIndex = 20;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(377, 380);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(133, 36);
            this.btSalvar.TabIndex = 23;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(655, 380);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(133, 36);
            this.btExcluir.TabIndex = 22;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAtualizar.FlatAppearance.BorderSize = 0;
            this.btAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizar.Location = new System.Drawing.Point(516, 380);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(133, 36);
            this.btAtualizar.TabIndex = 21;
            this.btAtualizar.Text = "Atualizar Estoque";
            this.btAtualizar.UseVisualStyleBackColor = false;
            // 
            // pBoxPadariaDocePao
            // 
            this.pBoxPadariaDocePao.Image = global::PadariaDocePao.Properties.Resources.Paodoce;
            this.pBoxPadariaDocePao.Location = new System.Drawing.Point(23, 26);
            this.pBoxPadariaDocePao.Name = "pBoxPadariaDocePao";
            this.pBoxPadariaDocePao.Size = new System.Drawing.Size(105, 98);
            this.pBoxPadariaDocePao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPadariaDocePao.TabIndex = 4;
            this.pBoxPadariaDocePao.TabStop = false;
            this.pBoxPadariaDocePao.Click += new System.EventHandler(this.pBoxPadariaDocePao_Click);
            // 
            // FrmMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.dataView2);
            this.Controls.Add(this.inputNivelMinimo);
            this.Controls.Add(this.lbNivelMinimo);
            this.Controls.Add(this.lbEstoque);
            this.Controls.Add(this.lbUnidadeMedida);
            this.Controls.Add(this.inputQtdEstoque);
            this.Controls.Add(this.inputUnidadeMedida);
            this.Controls.Add(this.inputNomeIgrediente);
            this.Controls.Add(this.lbIngrediente);
            this.Controls.Add(this.pBoxPadariaDocePao);
            this.Controls.Add(this.menuPadariaDocePao);
            this.Name = "FrmMateriaPrima";
            this.Text = "FrmMateriaPrima";
            this.menuPadariaDocePao.ResumeLayout(false);
            this.menuPadariaDocePao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPadariaDocePao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPadariaDocePao;
        private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matériasPrimasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planejamentoDeProduçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pBoxPadariaDocePao;
        private System.Windows.Forms.Label lbEstoque;
        private System.Windows.Forms.Label lbUnidadeMedida;
        private System.Windows.Forms.TextBox inputQtdEstoque;
        private System.Windows.Forms.TextBox inputUnidadeMedida;
        private System.Windows.Forms.TextBox inputNomeIgrediente;
        private System.Windows.Forms.Label lbIngrediente;
        private System.Windows.Forms.Label lbNivelMinimo;
        private System.Windows.Forms.TextBox inputNivelMinimo;
        private System.Windows.Forms.DataGridView dataView2;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
    }
}