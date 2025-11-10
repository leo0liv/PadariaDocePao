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
            this.gpBoxMateriaPrima = new System.Windows.Forms.GroupBox();
            this.nudQtdEstoque = new System.Windows.Forms.NumericUpDown();
            this.inputNomeMateriaPrima = new System.Windows.Forms.TextBox();
            this.lbQtdEstoque = new System.Windows.Forms.Label();
            this.lbUnidadeMateriaPrima = new System.Windows.Forms.Label();
            this.lbNomeMateriaPrima = new System.Windows.Forms.Label();
            this.dataTabelaMateriaPrima = new System.Windows.Forms.DataGridView();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.comboBoxUnidade = new System.Windows.Forms.ComboBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.gpBoxMateriaPrima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoxMateriaPrima
            // 
            this.gpBoxMateriaPrima.Controls.Add(this.comboBoxUnidade);
            this.gpBoxMateriaPrima.Controls.Add(this.nudQtdEstoque);
            this.gpBoxMateriaPrima.Controls.Add(this.inputNomeMateriaPrima);
            this.gpBoxMateriaPrima.Controls.Add(this.lbQtdEstoque);
            this.gpBoxMateriaPrima.Controls.Add(this.lbUnidadeMateriaPrima);
            this.gpBoxMateriaPrima.Controls.Add(this.lbNomeMateriaPrima);
            this.gpBoxMateriaPrima.Location = new System.Drawing.Point(12, 23);
            this.gpBoxMateriaPrima.Name = "gpBoxMateriaPrima";
            this.gpBoxMateriaPrima.Size = new System.Drawing.Size(776, 146);
            this.gpBoxMateriaPrima.TabIndex = 1;
            this.gpBoxMateriaPrima.TabStop = false;
            this.gpBoxMateriaPrima.Text = "Matérias Primas:";
            // 
            // nudQtdEstoque
            // 
            this.nudQtdEstoque.DecimalPlaces = 3;
            this.nudQtdEstoque.Location = new System.Drawing.Point(418, 51);
            this.nudQtdEstoque.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQtdEstoque.Name = "nudQtdEstoque";
            this.nudQtdEstoque.Size = new System.Drawing.Size(286, 20);
            this.nudQtdEstoque.TabIndex = 5;
            // 
            // inputNomeMateriaPrima
            // 
            this.inputNomeMateriaPrima.Location = new System.Drawing.Point(31, 51);
            this.inputNomeMateriaPrima.Name = "inputNomeMateriaPrima";
            this.inputNomeMateriaPrima.Size = new System.Drawing.Size(311, 20);
            this.inputNomeMateriaPrima.TabIndex = 3;
            // 
            // lbQtdEstoque
            // 
            this.lbQtdEstoque.AutoSize = true;
            this.lbQtdEstoque.Location = new System.Drawing.Point(415, 35);
            this.lbQtdEstoque.Name = "lbQtdEstoque";
            this.lbQtdEstoque.Size = new System.Drawing.Size(141, 13);
            this.lbQtdEstoque.TabIndex = 2;
            this.lbQtdEstoque.Text = "Quatidade em Estoque(Qtd):";
            // 
            // lbUnidadeMateriaPrima
            // 
            this.lbUnidadeMateriaPrima.AutoSize = true;
            this.lbUnidadeMateriaPrima.Location = new System.Drawing.Point(28, 77);
            this.lbUnidadeMateriaPrima.Name = "lbUnidadeMateriaPrima";
            this.lbUnidadeMateriaPrima.Size = new System.Drawing.Size(88, 13);
            this.lbUnidadeMateriaPrima.TabIndex = 1;
            this.lbUnidadeMateriaPrima.Text = "Unidade Medida:";
            // 
            // lbNomeMateriaPrima
            // 
            this.lbNomeMateriaPrima.AutoSize = true;
            this.lbNomeMateriaPrima.Location = new System.Drawing.Point(28, 35);
            this.lbNomeMateriaPrima.Name = "lbNomeMateriaPrima";
            this.lbNomeMateriaPrima.Size = new System.Drawing.Size(109, 13);
            this.lbNomeMateriaPrima.TabIndex = 0;
            this.lbNomeMateriaPrima.Text = "Nome do Ingrediente:";
            // 
            // dataTabelaMateriaPrima
            // 
            this.dataTabelaMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabelaMateriaPrima.Location = new System.Drawing.Point(12, 188);
            this.dataTabelaMateriaPrima.Name = "dataTabelaMateriaPrima";
            this.dataTabelaMateriaPrima.Size = new System.Drawing.Size(776, 201);
            this.dataTabelaMateriaPrima.TabIndex = 2;
            this.dataTabelaMateriaPrima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabelaMateriaPrima_CellContentClick);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(498, 395);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(183, 39);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(120, 395);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(183, 39);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // comboBoxUnidade
            // 
            this.comboBoxUnidade.FormattingEnabled = true;
            this.comboBoxUnidade.Items.AddRange(new object[] {
            "KG",
            "LT",
            "UN",
            "G",
            "ML"});
            this.comboBoxUnidade.Location = new System.Drawing.Point(31, 93);
            this.comboBoxUnidade.Name = "comboBoxUnidade";
            this.comboBoxUnidade.Size = new System.Drawing.Size(311, 21);
            this.comboBoxUnidade.TabIndex = 6;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(309, 395);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(183, 39);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FrmMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dataTabelaMateriaPrima);
            this.Controls.Add(this.gpBoxMateriaPrima);
            this.Name = "FrmMateriaPrima";
            this.Text = "FrmMateriaPrima";
            this.Load += new System.EventHandler(this.FrmMateriaPrima_Load);
            this.gpBoxMateriaPrima.ResumeLayout(false);
            this.gpBoxMateriaPrima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaMateriaPrima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxMateriaPrima;
        private System.Windows.Forms.NumericUpDown nudQtdEstoque;
        private System.Windows.Forms.TextBox inputNomeMateriaPrima;
        private System.Windows.Forms.Label lbQtdEstoque;
        private System.Windows.Forms.Label lbUnidadeMateriaPrima;
        private System.Windows.Forms.Label lbNomeMateriaPrima;
        private System.Windows.Forms.DataGridView dataTabelaMateriaPrima;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox comboBoxUnidade;
        private System.Windows.Forms.Button btExcluir;
    }
}