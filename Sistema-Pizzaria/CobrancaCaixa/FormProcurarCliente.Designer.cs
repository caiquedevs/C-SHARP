namespace CobrancaCaixa
{
    partial class FormProcurarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcurarCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Botao_ProcurarCliente = new System.Windows.Forms.Button();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GRID_Procurar = new System.Windows.Forms.DataGridView();
            this.Botao_Inserir = new System.Windows.Forms.Button();
            this.Coluna_ID_Procurar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Contato_Procurar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Procurar)).BeginInit();
            this.SuspendLayout();
            // 
            // Botao_ProcurarCliente
            // 
            this.Botao_ProcurarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_ProcurarCliente.BackgroundImage")));
            this.Botao_ProcurarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_ProcurarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_ProcurarCliente.FlatAppearance.BorderSize = 0;
            this.Botao_ProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_ProcurarCliente.Location = new System.Drawing.Point(451, 12);
            this.Botao_ProcurarCliente.Name = "Botao_ProcurarCliente";
            this.Botao_ProcurarCliente.Size = new System.Drawing.Size(27, 27);
            this.Botao_ProcurarCliente.TabIndex = 35;
            this.Botao_ProcurarCliente.UseVisualStyleBackColor = true;
            this.Botao_ProcurarCliente.Click += new System.EventHandler(this.Botao_ProcurarCliente_Click);
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(315, 14);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(130, 20);
            this.txtContato.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Contato";
            // 
            // GRID_Procurar
            // 
            this.GRID_Procurar.AllowUserToAddRows = false;
            this.GRID_Procurar.AllowUserToDeleteRows = false;
            this.GRID_Procurar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GRID_Procurar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Procurar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_ID_Procurar,
            this.Coluna_Nome,
            this.Coluna_Contato_Procurar,
            this.Coluna_Endereco,
            this.Coluna_Cep,
            this.Coluna_Numero,
            this.Coluna_Complemento});
            this.GRID_Procurar.Location = new System.Drawing.Point(16, 45);
            this.GRID_Procurar.Name = "GRID_Procurar";
            this.GRID_Procurar.ReadOnly = true;
            this.GRID_Procurar.Size = new System.Drawing.Size(737, 210);
            this.GRID_Procurar.TabIndex = 36;
            // 
            // Botao_Inserir
            // 
            this.Botao_Inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Inserir.Location = new System.Drawing.Point(679, 6);
            this.Botao_Inserir.Name = "Botao_Inserir";
            this.Botao_Inserir.Size = new System.Drawing.Size(55, 35);
            this.Botao_Inserir.TabIndex = 37;
            this.Botao_Inserir.Text = "Inserir";
            this.Botao_Inserir.UseVisualStyleBackColor = true;
            this.Botao_Inserir.Click += new System.EventHandler(this.Botao_Inserir_Click);
            // 
            // Coluna_ID_Procurar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_ID_Procurar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Coluna_ID_Procurar.HeaderText = "ID";
            this.Coluna_ID_Procurar.Name = "Coluna_ID_Procurar";
            this.Coluna_ID_Procurar.ReadOnly = true;
            this.Coluna_ID_Procurar.Width = 35;
            // 
            // Coluna_Nome
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.Coluna_Nome.HeaderText = "        NOME";
            this.Coluna_Nome.Name = "Coluna_Nome";
            this.Coluna_Nome.ReadOnly = true;
            // 
            // Coluna_Contato_Procurar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Contato_Procurar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Coluna_Contato_Procurar.HeaderText = "      CONTATO";
            this.Coluna_Contato_Procurar.Name = "Coluna_Contato_Procurar";
            this.Coluna_Contato_Procurar.ReadOnly = true;
            // 
            // Coluna_Endereco
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Endereco.DefaultCellStyle = dataGridViewCellStyle4;
            this.Coluna_Endereco.HeaderText = "                      ENDERECO";
            this.Coluna_Endereco.Name = "Coluna_Endereco";
            this.Coluna_Endereco.ReadOnly = true;
            this.Coluna_Endereco.Width = 200;
            // 
            // Coluna_Cep
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Cep.DefaultCellStyle = dataGridViewCellStyle5;
            this.Coluna_Cep.HeaderText = "       CEP";
            this.Coluna_Cep.Name = "Coluna_Cep";
            this.Coluna_Cep.ReadOnly = true;
            this.Coluna_Cep.Width = 80;
            // 
            // Coluna_Numero
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Numero.DefaultCellStyle = dataGridViewCellStyle6;
            this.Coluna_Numero.HeaderText = "NUMERO";
            this.Coluna_Numero.Name = "Coluna_Numero";
            this.Coluna_Numero.ReadOnly = true;
            this.Coluna_Numero.Width = 60;
            // 
            // Coluna_Complemento
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Complemento.DefaultCellStyle = dataGridViewCellStyle7;
            this.Coluna_Complemento.HeaderText = "COMPLEMENTO";
            this.Coluna_Complemento.Name = "Coluna_Complemento";
            this.Coluna_Complemento.ReadOnly = true;
            // 
            // FormProcurarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 263);
            this.Controls.Add(this.Botao_Inserir);
            this.Controls.Add(this.GRID_Procurar);
            this.Controls.Add(this.Botao_ProcurarCliente);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(783, 302);
            this.MinimumSize = new System.Drawing.Size(783, 302);
            this.Name = "FormProcurarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Procurar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botao_ProcurarCliente;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GRID_Procurar;
        private System.Windows.Forms.Button Botao_Inserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_ID_Procurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Contato_Procurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Complemento;
    }
}