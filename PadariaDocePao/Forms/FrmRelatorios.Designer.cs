namespace PadariaDocePao
{
    partial class FrmRelatorios
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuPadariaDocePao = new System.Windows.Forms.MenuStrip();
            this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matériasPrimasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planejamentoDeProduçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbTituloRelatorios = new System.Windows.Forms.Label();
            this.pBoxPadariaDocePao = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btRelatorios = new System.Windows.Forms.Button();
            this.lbEscolhaRelatorio = new System.Windows.Forms.Label();
            this.menuPadariaDocePao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPadariaDocePao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.menuPadariaDocePao.TabIndex = 5;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(464, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbTituloRelatorios
            // 
            this.lbTituloRelatorios.AutoSize = true;
            this.lbTituloRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloRelatorios.Location = new System.Drawing.Point(136, 38);
            this.lbTituloRelatorios.Name = "lbTituloRelatorios";
            this.lbTituloRelatorios.Size = new System.Drawing.Size(207, 39);
            this.lbTituloRelatorios.TabIndex = 7;
            this.lbTituloRelatorios.Text = "- Relatórios";
            this.lbTituloRelatorios.Click += new System.EventHandler(this.lb_Click);
            // 
            // pBoxPadariaDocePao
            // 
            this.pBoxPadariaDocePao.Image = global::PadariaDocePao.Properties.Resources.Paodoce;
            this.pBoxPadariaDocePao.Location = new System.Drawing.Point(25, 38);
            this.pBoxPadariaDocePao.Name = "pBoxPadariaDocePao";
            this.pBoxPadariaDocePao.Size = new System.Drawing.Size(105, 98);
            this.pBoxPadariaDocePao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPadariaDocePao.TabIndex = 21;
            this.pBoxPadariaDocePao.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 142);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 300);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // btRelatorios
            // 
            this.btRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btRelatorios.FlatAppearance.BorderSize = 0;
            this.btRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorios.Location = new System.Drawing.Point(713, 113);
            this.btRelatorios.Name = "btRelatorios";
            this.btRelatorios.Size = new System.Drawing.Size(75, 23);
            this.btRelatorios.TabIndex = 23;
            this.btRelatorios.Text = "Gerar";
            this.btRelatorios.UseVisualStyleBackColor = false;
            this.btRelatorios.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbEscolhaRelatorio
            // 
            this.lbEscolhaRelatorio.AutoSize = true;
            this.lbEscolhaRelatorio.Location = new System.Drawing.Point(326, 118);
            this.lbEscolhaRelatorio.Name = "lbEscolhaRelatorio";
            this.lbEscolhaRelatorio.Size = new System.Drawing.Size(132, 13);
            this.lbEscolhaRelatorio.TabIndex = 24;
            this.lbEscolhaRelatorio.Text = "Escolha o tipo de relatório:";
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEscolhaRelatorio);
            this.Controls.Add(this.btRelatorios);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pBoxPadariaDocePao);
            this.Controls.Add(this.lbTituloRelatorios);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuPadariaDocePao);
            this.Name = "FrmRelatorios";
            this.Text = "FrmRelatorios";
            this.menuPadariaDocePao.ResumeLayout(false);
            this.menuPadariaDocePao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPadariaDocePao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbTituloRelatorios;
        private System.Windows.Forms.PictureBox pBoxPadariaDocePao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btRelatorios;
        private System.Windows.Forms.Label lbEscolhaRelatorio;
    }
}