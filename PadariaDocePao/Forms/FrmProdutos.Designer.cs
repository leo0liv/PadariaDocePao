namespace PadariaDocePao
{
    partial class FrmProdutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNomeProduto = new System.Windows.Forms.TextBox();
            this.inputCategoria = new System.Windows.Forms.TextBox();
            this.InputPrecoVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.dataView1 = new System.Windows.Forms.DataGridView();
            this.btSalvar = new System.Windows.Forms.Button();
            this.pBoxPadariaDocePao = new System.Windows.Forms.PictureBox();
            this.menuPadariaDocePao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
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
            this.menuPadariaDocePao.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME DO PRODUTO";
            // 
            // inputNomeProduto
            // 
            this.inputNomeProduto.Location = new System.Drawing.Point(136, 87);
            this.inputNomeProduto.Name = "inputNomeProduto";
            this.inputNomeProduto.Size = new System.Drawing.Size(205, 20);
            this.inputNomeProduto.TabIndex = 5;
            // 
            // inputCategoria
            // 
            this.inputCategoria.Location = new System.Drawing.Point(347, 87);
            this.inputCategoria.Name = "inputCategoria";
            this.inputCategoria.Size = new System.Drawing.Size(205, 20);
            this.inputCategoria.TabIndex = 7;
            // 
            // InputPrecoVenda
            // 
            this.InputPrecoVenda.Location = new System.Drawing.Point(558, 87);
            this.InputPrecoVenda.Name = "InputPrecoVenda";
            this.InputPrecoVenda.Size = new System.Drawing.Size(205, 20);
            this.InputPrecoVenda.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CATEGORIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "PREÇO DE VENDA";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAdicionar.Location = new System.Drawing.Point(516, 387);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(133, 36);
            this.btAdicionar.TabIndex = 12;
            this.btAdicionar.Text = "Adicionar Ingrediente";
            this.btAdicionar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btExcluir.Location = new System.Drawing.Point(655, 387);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(133, 36);
            this.btExcluir.TabIndex = 13;
            this.btExcluir.Text = "Excluir Produto";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // dataView1
            // 
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView1.Location = new System.Drawing.Point(12, 169);
            this.dataView1.Name = "dataView1";
            this.dataView1.Size = new System.Drawing.Size(776, 212);
            this.dataView1.TabIndex = 14;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSalvar.Location = new System.Drawing.Point(377, 387);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(133, 36);
            this.btSalvar.TabIndex = 15;
            this.btSalvar.Text = "Salvar Produto";
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // pBoxPadariaDocePao
            // 
            this.pBoxPadariaDocePao.Image = global::PadariaDocePao.Properties.Resources.Paodoce;
            this.pBoxPadariaDocePao.Location = new System.Drawing.Point(25, 47);
            this.pBoxPadariaDocePao.Name = "pBoxPadariaDocePao";
            this.pBoxPadariaDocePao.Size = new System.Drawing.Size(105, 98);
            this.pBoxPadariaDocePao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPadariaDocePao.TabIndex = 3;
            this.pBoxPadariaDocePao.TabStop = false;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dataView1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputPrecoVenda);
            this.Controls.Add(this.inputCategoria);
            this.Controls.Add(this.inputNomeProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBoxPadariaDocePao);
            this.Controls.Add(this.menuPadariaDocePao);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.menuPadariaDocePao.ResumeLayout(false);
            this.menuPadariaDocePao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNomeProduto;
        private System.Windows.Forms.TextBox inputCategoria;
        private System.Windows.Forms.TextBox InputPrecoVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dataView1;
        private System.Windows.Forms.Button btSalvar;
    }
}