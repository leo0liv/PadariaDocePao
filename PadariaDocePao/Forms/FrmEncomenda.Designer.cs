namespace PadariaDocePao
{
    partial class FrmEncomenda
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
            this.gpBoxCliente = new System.Windows.Forms.GroupBox();
            this.inputMaskedTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.lbTelefoneCliente = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.inputNomeCliente = new System.Windows.Forms.TextBox();
            this.gpBoxPedido = new System.Windows.Forms.GroupBox();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.lbQtd = new System.Windows.Forms.Label();
            this.inputObservacao = new System.Windows.Forms.TextBox();
            this.nudQtdPedido = new System.Windows.Forms.NumericUpDown();
            this.lbEscolherProduto = new System.Windows.Forms.Label();
            this.lbDataPedido = new System.Windows.Forms.Label();
            this.dateTimePickerPedido = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEscolherProduto = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.button1 = new System.Windows.Forms.Button();
            this.gpBoxCliente.SuspendLayout();
            this.gpBoxPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoxCliente
            // 
            this.gpBoxCliente.Controls.Add(this.inputMaskedTelefoneCliente);
            this.gpBoxCliente.Controls.Add(this.lbTelefoneCliente);
            this.gpBoxCliente.Controls.Add(this.lbNomeCliente);
            this.gpBoxCliente.Controls.Add(this.inputNomeCliente);
            this.gpBoxCliente.Location = new System.Drawing.Point(12, 12);
            this.gpBoxCliente.Name = "gpBoxCliente";
            this.gpBoxCliente.Size = new System.Drawing.Size(208, 355);
            this.gpBoxCliente.TabIndex = 0;
            this.gpBoxCliente.TabStop = false;
            this.gpBoxCliente.Text = "Cliente:";
            // 
            // inputMaskedTelefoneCliente
            // 
            this.inputMaskedTelefoneCliente.Location = new System.Drawing.Point(9, 103);
            this.inputMaskedTelefoneCliente.Name = "inputMaskedTelefoneCliente";
            this.inputMaskedTelefoneCliente.Size = new System.Drawing.Size(183, 20);
            this.inputMaskedTelefoneCliente.TabIndex = 3;
            // 
            // lbTelefoneCliente
            // 
            this.lbTelefoneCliente.AutoSize = true;
            this.lbTelefoneCliente.Location = new System.Drawing.Point(6, 87);
            this.lbTelefoneCliente.Name = "lbTelefoneCliente";
            this.lbTelefoneCliente.Size = new System.Drawing.Size(102, 13);
            this.lbTelefoneCliente.TabIndex = 2;
            this.lbTelefoneCliente.Text = "Telefone do Cliente:";
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(6, 35);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(88, 13);
            this.lbNomeCliente.TabIndex = 0;
            this.lbNomeCliente.Text = "Nome do Cliente:";
            this.lbNomeCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNomeCliente
            // 
            this.inputNomeCliente.Location = new System.Drawing.Point(9, 51);
            this.inputNomeCliente.Name = "inputNomeCliente";
            this.inputNomeCliente.Size = new System.Drawing.Size(183, 20);
            this.inputNomeCliente.TabIndex = 1;
            // 
            // gpBoxPedido
            // 
            this.gpBoxPedido.Controls.Add(this.lbObservacao);
            this.gpBoxPedido.Controls.Add(this.lbQtd);
            this.gpBoxPedido.Controls.Add(this.inputObservacao);
            this.gpBoxPedido.Controls.Add(this.nudQtdPedido);
            this.gpBoxPedido.Controls.Add(this.lbEscolherProduto);
            this.gpBoxPedido.Controls.Add(this.lbDataPedido);
            this.gpBoxPedido.Controls.Add(this.dateTimePickerPedido);
            this.gpBoxPedido.Controls.Add(this.comboBoxEscolherProduto);
            this.gpBoxPedido.Location = new System.Drawing.Point(246, 12);
            this.gpBoxPedido.Name = "gpBoxPedido";
            this.gpBoxPedido.Size = new System.Drawing.Size(530, 355);
            this.gpBoxPedido.TabIndex = 1;
            this.gpBoxPedido.TabStop = false;
            this.gpBoxPedido.Text = "Pedido:";
            this.gpBoxPedido.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Location = new System.Drawing.Point(168, 216);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(73, 13);
            this.lbObservacao.TabIndex = 7;
            this.lbObservacao.Text = "Observações:";
            // 
            // lbQtd
            // 
            this.lbQtd.AutoSize = true;
            this.lbQtd.Location = new System.Drawing.Point(168, 151);
            this.lbQtd.Name = "lbQtd";
            this.lbQtd.Size = new System.Drawing.Size(65, 13);
            this.lbQtd.TabIndex = 6;
            this.lbQtd.Text = "Quantidade:";
            // 
            // inputObservacao
            // 
            this.inputObservacao.Location = new System.Drawing.Point(171, 232);
            this.inputObservacao.Multiline = true;
            this.inputObservacao.Name = "inputObservacao";
            this.inputObservacao.Size = new System.Drawing.Size(200, 90);
            this.inputObservacao.TabIndex = 5;
            this.inputObservacao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nudQtdPedido
            // 
            this.nudQtdPedido.Location = new System.Drawing.Point(171, 167);
            this.nudQtdPedido.Name = "nudQtdPedido";
            this.nudQtdPedido.Size = new System.Drawing.Size(200, 20);
            this.nudQtdPedido.TabIndex = 4;
            // 
            // lbEscolherProduto
            // 
            this.lbEscolherProduto.AutoSize = true;
            this.lbEscolherProduto.Location = new System.Drawing.Point(168, 90);
            this.lbEscolherProduto.Name = "lbEscolherProduto";
            this.lbEscolherProduto.Size = new System.Drawing.Size(91, 13);
            this.lbEscolherProduto.TabIndex = 3;
            this.lbEscolherProduto.Text = "Escolher Produto:";
            // 
            // lbDataPedido
            // 
            this.lbDataPedido.AutoSize = true;
            this.lbDataPedido.Location = new System.Drawing.Point(168, 26);
            this.lbDataPedido.Name = "lbDataPedido";
            this.lbDataPedido.Size = new System.Drawing.Size(116, 13);
            this.lbDataPedido.TabIndex = 2;
            this.lbDataPedido.Text = "Data/Hora da Entrega:";
            // 
            // dateTimePickerPedido
            // 
            this.dateTimePickerPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPedido.Location = new System.Drawing.Point(171, 42);
            this.dateTimePickerPedido.MaxDate = new System.DateTime(2025, 11, 10, 0, 0, 0, 0);
            this.dateTimePickerPedido.Name = "dateTimePickerPedido";
            this.dateTimePickerPedido.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPedido.TabIndex = 1;
            this.dateTimePickerPedido.Value = new System.DateTime(2025, 11, 10, 0, 0, 0, 0);
            // 
            // comboBoxEscolherProduto
            // 
            this.comboBoxEscolherProduto.FormattingEnabled = true;
            this.comboBoxEscolherProduto.Location = new System.Drawing.Point(171, 106);
            this.comboBoxEscolherProduto.Name = "comboBoxEscolherProduto";
            this.comboBoxEscolherProduto.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEscolherProduto.TabIndex = 0;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(347, 386);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(183, 39);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(535, 386);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(183, 39);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Consultar Encomendas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEncomenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gpBoxPedido);
            this.Controls.Add(this.gpBoxCliente);
            this.Name = "FrmEncomenda";
            this.Text = "FrmEncomenda";
            this.Load += new System.EventHandler(this.FrmEncomenda_Load);
            this.gpBoxCliente.ResumeLayout(false);
            this.gpBoxCliente.PerformLayout();
            this.gpBoxPedido.ResumeLayout(false);
            this.gpBoxPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxCliente;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbTelefoneCliente;
        private System.Windows.Forms.TextBox inputNomeCliente;
        private System.Windows.Forms.MaskedTextBox inputMaskedTelefoneCliente;
        private System.Windows.Forms.GroupBox gpBoxPedido;
        private System.Windows.Forms.Label lbDataPedido;
        private System.Windows.Forms.DateTimePicker dateTimePickerPedido;
        private System.Windows.Forms.ComboBox comboBoxEscolherProduto;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.Label lbQtd;
        private System.Windows.Forms.TextBox inputObservacao;
        private System.Windows.Forms.NumericUpDown nudQtdPedido;
        private System.Windows.Forms.Label lbEscolherProduto;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button button1;
    }
}