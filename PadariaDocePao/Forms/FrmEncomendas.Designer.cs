namespace PadariaDocePao
{
    partial class FrmEncomendas
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
            this.pBoxPadariaDocePao = new System.Windows.Forms.PictureBox();
            this.inputNivelMinimo = new System.Windows.Forms.TextBox();
            this.lbDataEntregaEncomenda = new System.Windows.Forms.Label();
            this.lbQuantidadeEncomenda = new System.Windows.Forms.Label();
            this.lbDetalhePedidoEncomenda = new System.Windows.Forms.Label();
            this.inputQtdEstoque = new System.Windows.Forms.TextBox();
            this.inputUnidadeMedida = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btImprimirComprovante = new System.Windows.Forms.Button();
            this.lbClienteEncomenda = new System.Windows.Forms.Label();
            this.inputPesquisarCliente = new System.Windows.Forms.TextBox();
            this.lbProdutoEncomenda = new System.Windows.Forms.Label();
            this.inputPesquisarProduto = new System.Windows.Forms.TextBox();
            this.menuPadariaDocePao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPadariaDocePao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuPadariaDocePao.TabIndex = 4;
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
            // pBoxPadariaDocePao
            // 
            this.pBoxPadariaDocePao.Image = global::PadariaDocePao.Properties.Resources.Paodoce;
            this.pBoxPadariaDocePao.Location = new System.Drawing.Point(23, 36);
            this.pBoxPadariaDocePao.Name = "pBoxPadariaDocePao";
            this.pBoxPadariaDocePao.Size = new System.Drawing.Size(105, 98);
            this.pBoxPadariaDocePao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPadariaDocePao.TabIndex = 5;
            this.pBoxPadariaDocePao.TabStop = false;
            // 
            // inputNivelMinimo
            // 
            this.inputNivelMinimo.Location = new System.Drawing.Point(136, 137);
            this.inputNivelMinimo.Name = "inputNivelMinimo";
            this.inputNivelMinimo.Size = new System.Drawing.Size(205, 20);
            this.inputNivelMinimo.TabIndex = 27;
            // 
            // lbDataEntregaEncomenda
            // 
            this.lbDataEntregaEncomenda.AutoSize = true;
            this.lbDataEntregaEncomenda.Location = new System.Drawing.Point(186, 121);
            this.lbDataEntregaEncomenda.Name = "lbDataEntregaEncomenda";
            this.lbDataEntregaEncomenda.Size = new System.Drawing.Size(109, 13);
            this.lbDataEntregaEncomenda.TabIndex = 26;
            this.lbDataEntregaEncomenda.Text = "DATA DA ENTREGA";
            // 
            // lbQuantidadeEncomenda
            // 
            this.lbQuantidadeEncomenda.AutoSize = true;
            this.lbQuantidadeEncomenda.Location = new System.Drawing.Point(621, 36);
            this.lbQuantidadeEncomenda.Name = "lbQuantidadeEncomenda";
            this.lbQuantidadeEncomenda.Size = new System.Drawing.Size(78, 13);
            this.lbQuantidadeEncomenda.TabIndex = 25;
            this.lbQuantidadeEncomenda.Text = "QUANTIDADE";
            this.lbQuantidadeEncomenda.Click += new System.EventHandler(this.lbQuantidade_Click);
            // 
            // lbDetalhePedidoEncomenda
            // 
            this.lbDetalhePedidoEncomenda.AutoSize = true;
            this.lbDetalhePedidoEncomenda.Location = new System.Drawing.Point(499, 121);
            this.lbDetalhePedidoEncomenda.Name = "lbDetalhePedidoEncomenda";
            this.lbDetalhePedidoEncomenda.Size = new System.Drawing.Size(120, 13);
            this.lbDetalhePedidoEncomenda.TabIndex = 24;
            this.lbDetalhePedidoEncomenda.Text = "DETALHE DO PEDIDO";
            // 
            // inputQtdEstoque
            // 
            this.inputQtdEstoque.Location = new System.Drawing.Point(558, 52);
            this.inputQtdEstoque.Name = "inputQtdEstoque";
            this.inputQtdEstoque.Size = new System.Drawing.Size(205, 20);
            this.inputQtdEstoque.TabIndex = 23;
            // 
            // inputUnidadeMedida
            // 
            this.inputUnidadeMedida.Location = new System.Drawing.Point(345, 137);
            this.inputUnidadeMedida.Name = "inputUnidadeMedida";
            this.inputUnidadeMedida.Size = new System.Drawing.Size(418, 20);
            this.inputUnidadeMedida.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 186);
            this.dataGridView1.TabIndex = 30;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSalvar.Location = new System.Drawing.Point(240, 378);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(133, 36);
            this.btSalvar.TabIndex = 33;
            this.btSalvar.Text = "Salvar Encomenda";
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btExcluir.Location = new System.Drawing.Point(657, 378);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(133, 36);
            this.btExcluir.TabIndex = 32;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAtualizar.Location = new System.Drawing.Point(518, 378);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(133, 36);
            this.btAtualizar.TabIndex = 31;
            this.btAtualizar.Text = "Editar Encomenda";
            this.btAtualizar.UseVisualStyleBackColor = false;
            // 
            // btImprimirComprovante
            // 
            this.btImprimirComprovante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btImprimirComprovante.Location = new System.Drawing.Point(379, 378);
            this.btImprimirComprovante.Name = "btImprimirComprovante";
            this.btImprimirComprovante.Size = new System.Drawing.Size(133, 36);
            this.btImprimirComprovante.TabIndex = 34;
            this.btImprimirComprovante.Text = "Imprimir Comprovante";
            this.btImprimirComprovante.UseVisualStyleBackColor = false;
            // 
            // lbClienteEncomenda
            // 
            this.lbClienteEncomenda.AutoSize = true;
            this.lbClienteEncomenda.Location = new System.Drawing.Point(212, 36);
            this.lbClienteEncomenda.Name = "lbClienteEncomenda";
            this.lbClienteEncomenda.Size = new System.Drawing.Size(52, 13);
            this.lbClienteEncomenda.TabIndex = 36;
            this.lbClienteEncomenda.Text = "CLIENTE";
            this.lbClienteEncomenda.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputPesquisarCliente
            // 
            this.inputPesquisarCliente.Location = new System.Drawing.Point(135, 52);
            this.inputPesquisarCliente.Name = "inputPesquisarCliente";
            this.inputPesquisarCliente.Size = new System.Drawing.Size(205, 20);
            this.inputPesquisarCliente.TabIndex = 35;
            // 
            // lbProdutoEncomenda
            // 
            this.lbProdutoEncomenda.AutoSize = true;
            this.lbProdutoEncomenda.Location = new System.Drawing.Point(417, 36);
            this.lbProdutoEncomenda.Name = "lbProdutoEncomenda";
            this.lbProdutoEncomenda.Size = new System.Drawing.Size(61, 13);
            this.lbProdutoEncomenda.TabIndex = 38;
            this.lbProdutoEncomenda.Text = "PRODUTO";
            // 
            // inputPesquisarProduto
            // 
            this.inputPesquisarProduto.Location = new System.Drawing.Point(347, 52);
            this.inputPesquisarProduto.Name = "inputPesquisarProduto";
            this.inputPesquisarProduto.Size = new System.Drawing.Size(205, 20);
            this.inputPesquisarProduto.TabIndex = 37;
            // 
            // FrmEncomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbProdutoEncomenda);
            this.Controls.Add(this.inputPesquisarProduto);
            this.Controls.Add(this.lbClienteEncomenda);
            this.Controls.Add(this.inputPesquisarCliente);
            this.Controls.Add(this.btImprimirComprovante);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inputNivelMinimo);
            this.Controls.Add(this.lbDataEntregaEncomenda);
            this.Controls.Add(this.lbQuantidadeEncomenda);
            this.Controls.Add(this.lbDetalhePedidoEncomenda);
            this.Controls.Add(this.inputQtdEstoque);
            this.Controls.Add(this.inputUnidadeMedida);
            this.Controls.Add(this.pBoxPadariaDocePao);
            this.Controls.Add(this.menuPadariaDocePao);
            this.Name = "FrmEncomendas";
            this.Text = "FrmEncomendas";
            this.menuPadariaDocePao.ResumeLayout(false);
            this.menuPadariaDocePao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPadariaDocePao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox inputNivelMinimo;
        private System.Windows.Forms.Label lbDataEntregaEncomenda;
        private System.Windows.Forms.Label lbQuantidadeEncomenda;
        private System.Windows.Forms.Label lbDetalhePedidoEncomenda;
        private System.Windows.Forms.TextBox inputQtdEstoque;
        private System.Windows.Forms.TextBox inputUnidadeMedida;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btImprimirComprovante;
        private System.Windows.Forms.Label lbClienteEncomenda;
        private System.Windows.Forms.TextBox inputPesquisarCliente;
        private System.Windows.Forms.Label lbProdutoEncomenda;
        private System.Windows.Forms.TextBox inputPesquisarProduto;
    }
}