namespace PadariaDocePao
{
    partial class FrmEditarCliente
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
            this.components = new System.ComponentModel.Container();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.inputEnderecoCliente = new System.Windows.Forms.TextBox();
            this.lbEnderecoCliente = new System.Windows.Forms.Label();
            this.lbEstoque = new System.Windows.Forms.Label();
            this.lbTelefoneCliente = new System.Windows.Forms.Label();
            this.inputObsCliente = new System.Windows.Forms.TextBox();
            this.inputTelefoneCliente = new System.Windows.Forms.TextBox();
            this.inputNomeCliente = new System.Windows.Forms.TextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.pBoxPadariaDocePao = new System.Windows.Forms.PictureBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dataTabelaCliente2 = new System.Windows.Forms.DataGridView();
            this.padariaDocePaoDataSet = new PadariaDocePao.PadariaDocePaoDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new PadariaDocePao.PadariaDocePaoDataSetTableAdapters.ClienteTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPadariaDocePao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaCliente2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDocePaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Location = new System.Drawing.Point(636, 34);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(87, 13);
            this.lbObservacao.TabIndex = 39;
            this.lbObservacao.Text = "OBSERVAÇÕES";
            // 
            // inputEnderecoCliente
            // 
            this.inputEnderecoCliente.Location = new System.Drawing.Point(155, 100);
            this.inputEnderecoCliente.Name = "inputEnderecoCliente";
            this.inputEnderecoCliente.Size = new System.Drawing.Size(416, 20);
            this.inputEnderecoCliente.TabIndex = 38;
            // 
            // lbEnderecoCliente
            // 
            this.lbEnderecoCliente.AutoSize = true;
            this.lbEnderecoCliente.Location = new System.Drawing.Point(290, 84);
            this.lbEnderecoCliente.Name = "lbEnderecoCliente";
            this.lbEnderecoCliente.Size = new System.Drawing.Size(134, 13);
            this.lbEnderecoCliente.TabIndex = 37;
            this.lbEnderecoCliente.Text = "ENDEREÇO DO CLIENTE";
            // 
            // lbEstoque
            // 
            this.lbEstoque.AutoSize = true;
            this.lbEstoque.Location = new System.Drawing.Point(608, 34);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(0, 13);
            this.lbEstoque.TabIndex = 36;
            // 
            // lbTelefoneCliente
            // 
            this.lbTelefoneCliente.AutoSize = true;
            this.lbTelefoneCliente.Location = new System.Drawing.Point(407, 34);
            this.lbTelefoneCliente.Name = "lbTelefoneCliente";
            this.lbTelefoneCliente.Size = new System.Drawing.Size(111, 13);
            this.lbTelefoneCliente.TabIndex = 35;
            this.lbTelefoneCliente.Text = "TELEFONE CLIENTE";
            // 
            // inputObsCliente
            // 
            this.inputObsCliente.Location = new System.Drawing.Point(577, 50);
            this.inputObsCliente.Multiline = true;
            this.inputObsCliente.Name = "inputObsCliente";
            this.inputObsCliente.Size = new System.Drawing.Size(205, 70);
            this.inputObsCliente.TabIndex = 34;
            // 
            // inputTelefoneCliente
            // 
            this.inputTelefoneCliente.Location = new System.Drawing.Point(366, 50);
            this.inputTelefoneCliente.Name = "inputTelefoneCliente";
            this.inputTelefoneCliente.Size = new System.Drawing.Size(205, 20);
            this.inputTelefoneCliente.TabIndex = 33;
            // 
            // inputNomeCliente
            // 
            this.inputNomeCliente.Location = new System.Drawing.Point(155, 50);
            this.inputNomeCliente.Name = "inputNomeCliente";
            this.inputNomeCliente.Size = new System.Drawing.Size(205, 20);
            this.inputNomeCliente.TabIndex = 32;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(203, 34);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(106, 13);
            this.lbNomeCliente.TabIndex = 31;
            this.lbNomeCliente.Text = "NOME DO CLIENTE";
            // 
            // pBoxPadariaDocePao
            // 
            this.pBoxPadariaDocePao.Image = global::PadariaDocePao.Properties.Resources.Paodoce;
            this.pBoxPadariaDocePao.Location = new System.Drawing.Point(39, 24);
            this.pBoxPadariaDocePao.Name = "pBoxPadariaDocePao";
            this.pBoxPadariaDocePao.Size = new System.Drawing.Size(105, 98);
            this.pBoxPadariaDocePao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPadariaDocePao.TabIndex = 30;
            this.pBoxPadariaDocePao.TabStop = false;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(270, 383);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(133, 36);
            this.btSalvar.TabIndex = 41;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Location = new System.Drawing.Point(409, 383);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(133, 36);
            this.btCancelar.TabIndex = 40;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // dataTabelaCliente2
            // 
            this.dataTabelaCliente2.AutoGenerateColumns = false;
            this.dataTabelaCliente2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabelaCliente2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
            this.dataTabelaCliente2.DataSource = this.clienteBindingSource;
            this.dataTabelaCliente2.Location = new System.Drawing.Point(39, 157);
            this.dataTabelaCliente2.Name = "dataTabelaCliente2";
            this.dataTabelaCliente2.Size = new System.Drawing.Size(743, 184);
            this.dataTabelaCliente2.TabIndex = 42;
            // 
            // padariaDocePaoDataSet
            // 
            this.padariaDocePaoDataSet.DataSetName = "PadariaDocePaoDataSet";
            this.padariaDocePaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.padariaDocePaoDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTabelaCliente2);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbObservacao);
            this.Controls.Add(this.inputEnderecoCliente);
            this.Controls.Add(this.lbEnderecoCliente);
            this.Controls.Add(this.lbEstoque);
            this.Controls.Add(this.lbTelefoneCliente);
            this.Controls.Add(this.inputObsCliente);
            this.Controls.Add(this.inputTelefoneCliente);
            this.Controls.Add(this.inputNomeCliente);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.pBoxPadariaDocePao);
            this.Name = "FrmEditarCliente";
            this.Text = "FrmEditarCliente";
            this.Load += new System.EventHandler(this.FrmEditarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPadariaDocePao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaCliente2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDocePaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.TextBox inputEnderecoCliente;
        private System.Windows.Forms.Label lbEnderecoCliente;
        private System.Windows.Forms.Label lbEstoque;
        private System.Windows.Forms.Label lbTelefoneCliente;
        private System.Windows.Forms.TextBox inputObsCliente;
        private System.Windows.Forms.TextBox inputTelefoneCliente;
        private System.Windows.Forms.TextBox inputNomeCliente;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.PictureBox pBoxPadariaDocePao;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridView dataTabelaCliente2;
        private PadariaDocePaoDataSet padariaDocePaoDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private PadariaDocePaoDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
    }
}