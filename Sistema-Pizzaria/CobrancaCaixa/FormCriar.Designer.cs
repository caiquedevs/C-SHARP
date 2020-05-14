namespace CobrancaCaixa
{
    partial class FormCriar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCriar));
            this.GRID_Produtos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxNome = new System.Windows.Forms.GroupBox();
            this.Apagar1 = new System.Windows.Forms.Button();
            this.txtPizza1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ComboQTD = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Apagar2 = new System.Windows.Forms.Button();
            this.txtPizza2 = new System.Windows.Forms.TextBox();
            this.Botao_ProcurarPizza = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Botao_Escolher = new System.Windows.Forms.ToolStripButton();
            this.Botao_Finalizar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Produtos)).BeginInit();
            this.BoxNome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRID_Produtos
            // 
            this.GRID_Produtos.AllowUserToAddRows = false;
            this.GRID_Produtos.AllowUserToDeleteRows = false;
            this.GRID_Produtos.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Coluna_Nome,
            this.Column3,
            this.Coluna_Valor});
            this.GRID_Produtos.Location = new System.Drawing.Point(12, 139);
            this.GRID_Produtos.Name = "GRID_Produtos";
            this.GRID_Produtos.ReadOnly = true;
            this.GRID_Produtos.Size = new System.Drawing.Size(593, 216);
            this.GRID_Produtos.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "CATEGORIA";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Coluna_Nome
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Nome.DefaultCellStyle = dataGridViewCellStyle3;
            this.Coluna_Nome.HeaderText = "NOME";
            this.Coluna_Nome.Name = "Coluna_Nome";
            this.Coluna_Nome.ReadOnly = true;
            this.Coluna_Nome.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "INGREDIENTES";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Coluna_Valor
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Valor.DefaultCellStyle = dataGridViewCellStyle5;
            this.Coluna_Valor.HeaderText = "VALOR";
            this.Coluna_Valor.Name = "Coluna_Valor";
            this.Coluna_Valor.ReadOnly = true;
            this.Coluna_Valor.Width = 65;
            // 
            // BoxNome
            // 
            this.BoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxNome.Controls.Add(this.Apagar1);
            this.BoxNome.Controls.Add(this.txtPizza1);
            this.BoxNome.Location = new System.Drawing.Point(6, 18);
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.Size = new System.Drawing.Size(174, 37);
            this.BoxNome.TabIndex = 33;
            this.BoxNome.TabStop = false;
            this.BoxNome.Text = "Pizza 1";
            // 
            // Apagar1
            // 
            this.Apagar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Apagar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Apagar1.FlatAppearance.BorderSize = 0;
            this.Apagar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apagar1.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apagar1.ForeColor = System.Drawing.Color.Red;
            this.Apagar1.Location = new System.Drawing.Point(160, 15);
            this.Apagar1.Name = "Apagar1";
            this.Apagar1.Size = new System.Drawing.Size(13, 21);
            this.Apagar1.TabIndex = 43;
            this.Apagar1.Text = "X";
            this.Apagar1.UseVisualStyleBackColor = false;
            this.Apagar1.Click += new System.EventHandler(this.Apagar1_Click);
            // 
            // txtPizza1
            // 
            this.txtPizza1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPizza1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPizza1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtPizza1.ForeColor = System.Drawing.Color.Black;
            this.txtPizza1.Location = new System.Drawing.Point(1, 15);
            this.txtPizza1.Name = "txtPizza1";
            this.txtPizza1.ReadOnly = true;
            this.txtPizza1.Size = new System.Drawing.Size(159, 21);
            this.txtPizza1.TabIndex = 1;
            this.txtPizza1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.BoxNome);
            this.groupBox1.Location = new System.Drawing.Point(108, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 98);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Pizza";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.ComboQTD);
            this.groupBox4.Controls.Add(this.txtValor);
            this.groupBox4.Location = new System.Drawing.Point(6, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 37);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valor Final";
            // 
            // ComboQTD
            // 
            this.ComboQTD.FormattingEnabled = true;
            this.ComboQTD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboQTD.Location = new System.Drawing.Point(135, 16);
            this.ComboQTD.Name = "ComboQTD";
            this.ComboQTD.Size = new System.Drawing.Size(38, 21);
            this.ComboQTD.TabIndex = 44;
            this.ComboQTD.Text = "1";
            this.ComboQTD.SelectedIndexChanged += new System.EventHandler(this.ComboQTD_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.BackColor = System.Drawing.SystemColors.Control;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(1, 15);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(166, 21);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtProduto);
            this.groupBox3.Location = new System.Drawing.Point(186, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 37);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProduto.BackColor = System.Drawing.Color.White;
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduto.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtProduto.ForeColor = System.Drawing.Color.Silver;
            this.txtProduto.Location = new System.Drawing.Point(3, 11);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(166, 21);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.Text = "Produto";
            this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProduto.Click += new System.EventHandler(this.txtProduto_Click);
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Apagar2);
            this.groupBox2.Controls.Add(this.txtPizza2);
            this.groupBox2.Location = new System.Drawing.Point(186, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 37);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza 2";
            // 
            // Apagar2
            // 
            this.Apagar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Apagar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Apagar2.FlatAppearance.BorderSize = 0;
            this.Apagar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apagar2.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apagar2.ForeColor = System.Drawing.Color.Red;
            this.Apagar2.Location = new System.Drawing.Point(160, 15);
            this.Apagar2.Name = "Apagar2";
            this.Apagar2.Size = new System.Drawing.Size(13, 21);
            this.Apagar2.TabIndex = 43;
            this.Apagar2.Text = "X";
            this.Apagar2.UseVisualStyleBackColor = false;
            this.Apagar2.Click += new System.EventHandler(this.Apagar2_Click);
            // 
            // txtPizza2
            // 
            this.txtPizza2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPizza2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPizza2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtPizza2.ForeColor = System.Drawing.Color.Black;
            this.txtPizza2.Location = new System.Drawing.Point(1, 15);
            this.txtPizza2.Name = "txtPizza2";
            this.txtPizza2.ReadOnly = true;
            this.txtPizza2.Size = new System.Drawing.Size(159, 21);
            this.txtPizza2.TabIndex = 1;
            this.txtPizza2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Botao_ProcurarPizza
            // 
            this.Botao_ProcurarPizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_ProcurarPizza.BackgroundImage")));
            this.Botao_ProcurarPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_ProcurarPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_ProcurarPizza.FlatAppearance.BorderSize = 0;
            this.Botao_ProcurarPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_ProcurarPizza.Location = new System.Drawing.Point(484, 96);
            this.Botao_ProcurarPizza.Name = "Botao_ProcurarPizza";
            this.Botao_ProcurarPizza.Size = new System.Drawing.Size(27, 27);
            this.Botao_ProcurarPizza.TabIndex = 40;
            this.Botao_ProcurarPizza.UseVisualStyleBackColor = true;
            this.Botao_ProcurarPizza.Click += new System.EventHandler(this.Botao_ProcurarPizza_Click_1);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Botao_Escolher,
            this.Botao_Finalizar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(616, 25);
            this.toolStrip2.TabIndex = 43;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Botao_Escolher
            // 
            this.Botao_Escolher.Image = ((System.Drawing.Image)(resources.GetObject("Botao_Escolher.Image")));
            this.Botao_Escolher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Botao_Escolher.Name = "Botao_Escolher";
            this.Botao_Escolher.Size = new System.Drawing.Size(71, 22);
            this.Botao_Escolher.Text = "Escolher";
            this.Botao_Escolher.Click += new System.EventHandler(this.Botao_Escolher_Click);
            // 
            // Botao_Finalizar
            // 
            this.Botao_Finalizar.Image = ((System.Drawing.Image)(resources.GetObject("Botao_Finalizar.Image")));
            this.Botao_Finalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Botao_Finalizar.Name = "Botao_Finalizar";
            this.Botao_Finalizar.Size = new System.Drawing.Size(70, 22);
            this.Botao_Finalizar.Text = "Finalizar";
            this.Botao_Finalizar.Click += new System.EventHandler(this.Botao_Finalizar_Click_1);
            // 
            // FormCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 367);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.Botao_ProcurarPizza);
            this.Controls.Add(this.GRID_Produtos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCriar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Produtos)).EndInit();
            this.BoxNome.ResumeLayout(false);
            this.BoxNome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRID_Produtos;
        private System.Windows.Forms.GroupBox BoxNome;
        private System.Windows.Forms.TextBox txtPizza1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPizza2;
        private System.Windows.Forms.Button Botao_ProcurarPizza;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Valor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button Apagar1;
        private System.Windows.Forms.Button Apagar2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Botao_Escolher;
        private System.Windows.Forms.ToolStripButton Botao_Finalizar;
        private System.Windows.Forms.ComboBox ComboQTD;
    }
}