namespace CobrancaCaixa
{
    partial class FormProdutosEDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutosEDIT));
            this.GRID_Produtos = new System.Windows.Forms.DataGridView();
            this.Coluna_ID_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Categoria_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Nome_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Ingredientes_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Valor_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Botao_Filtrar = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Botao_Editar = new System.Windows.Forms.ToolStripButton();
            this.Botao_Excluir = new System.Windows.Forms.ToolStripButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.Botao_Apagar = new System.Windows.Forms.Button();
            this.Botao_IncluirProduto = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Link_Voltar = new System.Windows.Forms.LinkLabel();
            this.GroupEdit = new System.Windows.Forms.GroupBox();
            this.Opacidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Produtos)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRID_Produtos
            // 
            this.GRID_Produtos.AllowUserToAddRows = false;
            this.GRID_Produtos.AllowUserToDeleteRows = false;
            this.GRID_Produtos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GRID_Produtos.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_ID_Produto,
            this.Coluna_Categoria_Produtos,
            this.Coluna_Nome_Produtos,
            this.Coluna_Ingredientes_Produto,
            this.Coluna_Valor_Produtos});
            this.GRID_Produtos.Location = new System.Drawing.Point(13, 48);
            this.GRID_Produtos.Name = "GRID_Produtos";
            this.GRID_Produtos.ReadOnly = true;
            this.GRID_Produtos.Size = new System.Drawing.Size(651, 194);
            this.GRID_Produtos.TabIndex = 11;
            this.GRID_Produtos.Visible = false;
            // 
            // Coluna_ID_Produto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_ID_Produto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Coluna_ID_Produto.HeaderText = "ID";
            this.Coluna_ID_Produto.Name = "Coluna_ID_Produto";
            this.Coluna_ID_Produto.ReadOnly = true;
            this.Coluna_ID_Produto.Width = 30;
            // 
            // Coluna_Categoria_Produtos
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Categoria_Produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Coluna_Categoria_Produtos.HeaderText = "CATEGORIA";
            this.Coluna_Categoria_Produtos.Name = "Coluna_Categoria_Produtos";
            this.Coluna_Categoria_Produtos.ReadOnly = true;
            this.Coluna_Categoria_Produtos.Width = 80;
            // 
            // Coluna_Nome_Produtos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Nome_Produtos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Coluna_Nome_Produtos.HeaderText = "   NOME PRODUTO";
            this.Coluna_Nome_Produtos.Name = "Coluna_Nome_Produtos";
            this.Coluna_Nome_Produtos.ReadOnly = true;
            this.Coluna_Nome_Produtos.Width = 130;
            // 
            // Coluna_Ingredientes_Produto
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Ingredientes_Produto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Coluna_Ingredientes_Produto.HeaderText = "                           INGREDIENTES";
            this.Coluna_Ingredientes_Produto.Name = "Coluna_Ingredientes_Produto";
            this.Coluna_Ingredientes_Produto.ReadOnly = true;
            this.Coluna_Ingredientes_Produto.Width = 290;
            // 
            // Coluna_Valor_Produtos
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Valor_Produtos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Coluna_Valor_Produtos.HeaderText = " VALOR";
            this.Coluna_Valor_Produtos.Name = "Coluna_Valor_Produtos";
            this.Coluna_Valor_Produtos.ReadOnly = true;
            this.Coluna_Valor_Produtos.Width = 60;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(284, 18);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(130, 20);
            this.txtFiltro.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nome do Produto";
            // 
            // Botao_Filtrar
            // 
            this.Botao_Filtrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Filtrar.BackgroundImage")));
            this.Botao_Filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Filtrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Filtrar.FlatAppearance.BorderSize = 0;
            this.Botao_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Filtrar.Location = new System.Drawing.Point(420, 16);
            this.Botao_Filtrar.Name = "Botao_Filtrar";
            this.Botao_Filtrar.Size = new System.Drawing.Size(24, 24);
            this.Botao_Filtrar.TabIndex = 40;
            this.Botao_Filtrar.UseVisualStyleBackColor = true;
            this.Botao_Filtrar.Click += new System.EventHandler(this.Botao_Filtrar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Botao_Editar,
            this.Botao_Excluir});
            this.toolStrip2.Location = new System.Drawing.Point(13, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(130, 25);
            this.toolStrip2.TabIndex = 41;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Botao_Editar
            // 
            this.Botao_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Botao_Editar.Image")));
            this.Botao_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Botao_Editar.Name = "Botao_Editar";
            this.Botao_Editar.Size = new System.Drawing.Size(57, 22);
            this.Botao_Editar.Text = "Editar";
            this.Botao_Editar.Click += new System.EventHandler(this.Botao_Editar_Click);
            // 
            // Botao_Excluir
            // 
            this.Botao_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Botao_Excluir.Image")));
            this.Botao_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Botao_Excluir.Name = "Botao_Excluir";
            this.Botao_Excluir.Size = new System.Drawing.Size(61, 22);
            this.Botao_Excluir.Text = "Excluir";
            this.Botao_Excluir.Click += new System.EventHandler(this.Botao_Excluir_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(606, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtIngrediente);
            this.groupBox4.Location = new System.Drawing.Point(21, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 40);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ingredientes";
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngrediente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtIngrediente.ForeColor = System.Drawing.Color.Black;
            this.txtIngrediente.Location = new System.Drawing.Point(3, 16);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(229, 21);
            this.txtIngrediente.TabIndex = 4;
            this.txtIngrediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIngrediente.Click += new System.EventHandler(this.txtIngrediente_Click);
            this.txtIngrediente.TextChanged += new System.EventHandler(this.txtIngrediente_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(216, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(11, 18);
            this.button1.TabIndex = 45;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Botao_Apagar);
            this.groupBox2.Controls.Add(this.txtNomeProduto);
            this.groupBox2.Location = new System.Drawing.Point(21, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 40);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtNomeProduto.ForeColor = System.Drawing.Color.Black;
            this.txtNomeProduto.Location = new System.Drawing.Point(3, 16);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(229, 21);
            this.txtNomeProduto.TabIndex = 1;
            this.txtNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeProduto.Click += new System.EventHandler(this.txtNomeProduto_Click);
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            // 
            // Botao_Apagar
            // 
            this.Botao_Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Apagar.FlatAppearance.BorderSize = 0;
            this.Botao_Apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Apagar.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Apagar.ForeColor = System.Drawing.Color.Red;
            this.Botao_Apagar.Location = new System.Drawing.Point(216, 15);
            this.Botao_Apagar.Name = "Botao_Apagar";
            this.Botao_Apagar.Size = new System.Drawing.Size(11, 18);
            this.Botao_Apagar.TabIndex = 45;
            this.Botao_Apagar.Text = "X";
            this.Botao_Apagar.UseVisualStyleBackColor = true;
            this.Botao_Apagar.Click += new System.EventHandler(this.Botao_Apagar_Click);
            // 
            // Botao_IncluirProduto
            // 
            this.Botao_IncluirProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Botao_IncluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_IncluirProduto.Location = new System.Drawing.Point(70, 190);
            this.Botao_IncluirProduto.Name = "Botao_IncluirProduto";
            this.Botao_IncluirProduto.Size = new System.Drawing.Size(122, 35);
            this.Botao_IncluirProduto.TabIndex = 16;
            this.Botao_IncluirProduto.Text = "Salvar Alteração";
            this.Botao_IncluirProduto.UseVisualStyleBackColor = true;
            this.Botao_IncluirProduto.Click += new System.EventHandler(this.Botao_IncluirProduto_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.txtValor);
            this.groupBox5.Location = new System.Drawing.Point(22, 149);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(89, 30);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VALOR";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(10, 13);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(68, 15);
            this.txtValor.TabIndex = 5;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.Click += new System.EventHandler(this.txtValor_Click);
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Items.AddRange(new object[] {
            "Pizza",
            "Bebida"});
            this.txtCategoria.Location = new System.Drawing.Point(117, 155);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(123, 24);
            this.txtCategoria.TabIndex = 17;
            this.txtCategoria.Text = "Categoria";
            this.txtCategoria.SelectedIndexChanged += new System.EventHandler(this.txtCategoria_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 40);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(3, 16);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(229, 21);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Link_Voltar
            // 
            this.Link_Voltar.AutoSize = true;
            this.Link_Voltar.Location = new System.Drawing.Point(220, 225);
            this.Link_Voltar.Name = "Link_Voltar";
            this.Link_Voltar.Size = new System.Drawing.Size(43, 16);
            this.Link_Voltar.TabIndex = 43;
            this.Link_Voltar.TabStop = true;
            this.Link_Voltar.Text = "Voltar";
            this.Link_Voltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Voltar_LinkClicked);
            // 
            // GroupEdit
            // 
            this.GroupEdit.Controls.Add(this.Link_Voltar);
            this.GroupEdit.Controls.Add(this.groupBox1);
            this.GroupEdit.Controls.Add(this.txtCategoria);
            this.GroupEdit.Controls.Add(this.groupBox5);
            this.GroupEdit.Controls.Add(this.Botao_IncluirProduto);
            this.GroupEdit.Controls.Add(this.groupBox2);
            this.GroupEdit.Controls.Add(this.groupBox4);
            this.GroupEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupEdit.Location = new System.Drawing.Point(201, 4);
            this.GroupEdit.Name = "GroupEdit";
            this.GroupEdit.Size = new System.Drawing.Size(272, 245);
            this.GroupEdit.TabIndex = 42;
            this.GroupEdit.TabStop = false;
            this.GroupEdit.Text = "Editar ";
            this.GroupEdit.Visible = false;
            // 
            // Opacidade
            // 
            this.Opacidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Opacidade.BackColor = System.Drawing.Color.Transparent;
            this.Opacidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Opacidade.FlatAppearance.BorderSize = 0;
            this.Opacidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Opacidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Opacidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Opacidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Opacidade.Location = new System.Drawing.Point(0, 4);
            this.Opacidade.Name = "Opacidade";
            this.Opacidade.Size = new System.Drawing.Size(681, 265);
            this.Opacidade.TabIndex = 18;
            this.Opacidade.UseVisualStyleBackColor = false;
            this.Opacidade.Visible = false;
            // 
            // FormProdutosEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 261);
            this.Controls.Add(this.GroupEdit);
            this.Controls.Add(this.Opacidade);
            this.Controls.Add(this.GRID_Produtos);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Botao_Filtrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(696, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(696, 300);
            this.Name = "FormProdutosEDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Produtos)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupEdit.ResumeLayout(false);
            this.GroupEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRID_Produtos;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Botao_Filtrar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Botao_Editar;
        private System.Windows.Forms.ToolStripButton Botao_Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_ID_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Categoria_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Nome_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Ingredientes_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Valor_Produtos;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Botao_Apagar;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button Botao_IncluirProduto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.LinkLabel Link_Voltar;
        private System.Windows.Forms.GroupBox GroupEdit;
        private System.Windows.Forms.Button Opacidade;
    }
}