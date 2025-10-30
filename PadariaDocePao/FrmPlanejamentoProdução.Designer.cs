namespace PadariaDocePao
{
    partial class FrmPlanejamentoProdução
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
            this.dataView4 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pBoxPadariaDocePao = new System.Windows.Forms.PictureBox();
            this.btGerarOrdem = new System.Windows.Forms.Button();
            this.btImprimirListaProducao = new System.Windows.Forms.Button();
            this.menuPadariaDocePao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView4)).BeginInit();
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
            // dataView4
            // 
            this.dataView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView4.Location = new System.Drawing.Point(146, 62);
            this.dataView4.Name = "dataView4";
            this.dataView4.Size = new System.Drawing.Size(642, 322);
            this.dataView4.TabIndex = 3;
            this.dataView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(566, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // pBoxPadariaDocePao
            // 
            this.pBoxPadariaDocePao.Image = global::PadariaDocePao.Properties.Resources.Paodoce;
            this.pBoxPadariaDocePao.Location = new System.Drawing.Point(21, 36);
            this.pBoxPadariaDocePao.Name = "pBoxPadariaDocePao";
            this.pBoxPadariaDocePao.Size = new System.Drawing.Size(105, 98);
            this.pBoxPadariaDocePao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPadariaDocePao.TabIndex = 6;
            this.pBoxPadariaDocePao.TabStop = false;
            this.pBoxPadariaDocePao.Click += new System.EventHandler(this.pBoxPadariaDocePao_Click);
            // 
            // btGerarOrdem
            // 
            this.btGerarOrdem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btGerarOrdem.Location = new System.Drawing.Point(278, 390);
            this.btGerarOrdem.Name = "btGerarOrdem";
            this.btGerarOrdem.Size = new System.Drawing.Size(195, 36);
            this.btGerarOrdem.TabIndex = 37;
            this.btGerarOrdem.Text = "Gerar Ordem de Produção";
            this.btGerarOrdem.UseVisualStyleBackColor = false;
            // 
            // btImprimirListaProducao
            // 
            this.btImprimirListaProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btImprimirListaProducao.Location = new System.Drawing.Point(479, 390);
            this.btImprimirListaProducao.Name = "btImprimirListaProducao";
            this.btImprimirListaProducao.Size = new System.Drawing.Size(195, 36);
            this.btImprimirListaProducao.TabIndex = 38;
            this.btImprimirListaProducao.Text = "Imprimir Lista de Produção";
            this.btImprimirListaProducao.UseVisualStyleBackColor = false;
            // 
            // FrmPlanejamentoProdução
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btImprimirListaProducao);
            this.Controls.Add(this.btGerarOrdem);
            this.Controls.Add(this.pBoxPadariaDocePao);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataView4);
            this.Controls.Add(this.menuPadariaDocePao);
            this.Name = "FrmPlanejamentoProdução";
            this.Text = "FrmPlanejamentoProdução";
            this.menuPadariaDocePao.ResumeLayout(false);
            this.menuPadariaDocePao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView4)).EndInit();
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
        private System.Windows.Forms.DataGridView dataView4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pBoxPadariaDocePao;
        private System.Windows.Forms.Button btGerarOrdem;
        private System.Windows.Forms.Button btImprimirListaProducao;
    }
}