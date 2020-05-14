namespace CobrancaCaixa
{
    partial class FormClientesEDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientesEDIT));
            this.GRID_Clientes = new System.Windows.Forms.DataGridView();
            this.Coluna_ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Categoria_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Nome_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Ingredientes_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Valor_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Botao_Editar = new System.Windows.Forms.ToolStripButton();
            this.Botao_Excluir = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Botao_Filtrar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.GroupEdit = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Botao_Apagar3 = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Botao_Apagar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Botao_Apagar2 = new System.Windows.Forms.Button();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Botao_Apagar4 = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.Link_Voltar = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Botao_IncluirProduto = new System.Windows.Forms.Button();
            this.Opacidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Clientes)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.GroupEdit.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRID_Clientes
            // 
            this.GRID_Clientes.AllowUserToAddRows = false;
            this.GRID_Clientes.AllowUserToDeleteRows = false;
            this.GRID_Clientes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GRID_Clientes.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_ID_Cliente,
            this.Coluna_Categoria_Produtos,
            this.Coluna_Nome_Produtos,
            this.Coluna_Ingredientes_Produto,
            this.Coluna_Valor_Produtos,
            this.Column1,
            this.Column2});
            this.GRID_Clientes.Location = new System.Drawing.Point(17, 44);
            this.GRID_Clientes.Name = "GRID_Clientes";
            this.GRID_Clientes.ReadOnly = true;
            this.GRID_Clientes.Size = new System.Drawing.Size(892, 274);
            this.GRID_Clientes.TabIndex = 45;
            // 
            // Coluna_ID_Cliente
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_ID_Cliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.Coluna_ID_Cliente.HeaderText = "ID";
            this.Coluna_ID_Cliente.Name = "Coluna_ID_Cliente";
            this.Coluna_ID_Cliente.ReadOnly = true;
            this.Coluna_ID_Cliente.Width = 30;
            // 
            // Coluna_Categoria_Produtos
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Categoria_Produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Coluna_Categoria_Produtos.HeaderText = "NOME";
            this.Coluna_Categoria_Produtos.Name = "Coluna_Categoria_Produtos";
            this.Coluna_Categoria_Produtos.ReadOnly = true;
            this.Coluna_Categoria_Produtos.Width = 80;
            // 
            // Coluna_Nome_Produtos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Nome_Produtos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Coluna_Nome_Produtos.HeaderText = "CONTATO";
            this.Coluna_Nome_Produtos.Name = "Coluna_Nome_Produtos";
            this.Coluna_Nome_Produtos.ReadOnly = true;
            this.Coluna_Nome_Produtos.Width = 130;
            // 
            // Coluna_Ingredientes_Produto
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Ingredientes_Produto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Coluna_Ingredientes_Produto.HeaderText = "ENDERECO";
            this.Coluna_Ingredientes_Produto.Name = "Coluna_Ingredientes_Produto";
            this.Coluna_Ingredientes_Produto.ReadOnly = true;
            this.Coluna_Ingredientes_Produto.Width = 290;
            // 
            // Coluna_Valor_Produtos
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Valor_Produtos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Coluna_Valor_Produtos.HeaderText = "CEP";
            this.Coluna_Valor_Produtos.Name = "Coluna_Valor_Produtos";
            this.Coluna_Valor_Produtos.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NUMERO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "COMPLEMENTO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Botao_Editar,
            this.Botao_Excluir});
            this.toolStrip2.Location = new System.Drawing.Point(17, 11);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(130, 25);
            this.toolStrip2.TabIndex = 50;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Contato do Cliente";
            // 
            // Botao_Filtrar
            // 
            this.Botao_Filtrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Filtrar.BackgroundImage")));
            this.Botao_Filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Filtrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Filtrar.FlatAppearance.BorderSize = 0;
            this.Botao_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Filtrar.Location = new System.Drawing.Point(562, 7);
            this.Botao_Filtrar.Name = "Botao_Filtrar";
            this.Botao_Filtrar.Size = new System.Drawing.Size(24, 24);
            this.Botao_Filtrar.TabIndex = 49;
            this.Botao_Filtrar.UseVisualStyleBackColor = true;
            this.Botao_Filtrar.Click += new System.EventHandler(this.Botao_Filtrar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(426, 9);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(130, 20);
            this.txtFiltro.TabIndex = 48;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(749, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 52;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // GroupEdit
            // 
            this.GroupEdit.Controls.Add(this.groupBox6);
            this.GroupEdit.Controls.Add(this.groupBox5);
            this.GroupEdit.Controls.Add(this.groupBox3);
            this.GroupEdit.Controls.Add(this.groupBox2);
            this.GroupEdit.Controls.Add(this.groupBox4);
            this.GroupEdit.Controls.Add(this.groupBox7);
            this.GroupEdit.Controls.Add(this.Link_Voltar);
            this.GroupEdit.Controls.Add(this.groupBox1);
            this.GroupEdit.Controls.Add(this.Botao_IncluirProduto);
            this.GroupEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupEdit.Location = new System.Drawing.Point(294, 10);
            this.GroupEdit.Name = "GroupEdit";
            this.GroupEdit.Size = new System.Drawing.Size(272, 315);
            this.GroupEdit.TabIndex = 54;
            this.GroupEdit.TabStop = false;
            this.GroupEdit.Text = "Editar ";
            this.GroupEdit.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.txtComplemento);
            this.groupBox6.Location = new System.Drawing.Point(99, 226);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(154, 30);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplemento.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtComplemento.Location = new System.Drawing.Point(3, 13);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(148, 15);
            this.txtComplemento.TabIndex = 6;
            this.txtComplemento.Text = "Opcional";
            this.txtComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.txtNumero);
            this.groupBox5.Location = new System.Drawing.Point(19, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(74, 30);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.txtNumero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumero.Location = new System.Drawing.Point(3, 13);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 15);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.Text = "Obrigatorio";
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.Botao_Apagar3);
            this.groupBox3.Controls.Add(this.txtEndereco);
            this.groupBox3.Location = new System.Drawing.Point(19, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 37);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // Botao_Apagar3
            // 
            this.Botao_Apagar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Apagar3.FlatAppearance.BorderSize = 0;
            this.Botao_Apagar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Apagar3.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Apagar3.ForeColor = System.Drawing.Color.Red;
            this.Botao_Apagar3.Location = new System.Drawing.Point(217, 12);
            this.Botao_Apagar3.Name = "Botao_Apagar3";
            this.Botao_Apagar3.Size = new System.Drawing.Size(11, 18);
            this.Botao_Apagar3.TabIndex = 0;
            this.Botao_Apagar3.Text = "X";
            this.Botao_Apagar3.UseVisualStyleBackColor = true;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEndereco.Location = new System.Drawing.Point(3, 15);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(229, 21);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.Text = "Obrigatorio";
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Botao_Apagar);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(20, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 37);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nome";
            // 
            // Botao_Apagar
            // 
            this.Botao_Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Apagar.FlatAppearance.BorderSize = 0;
            this.Botao_Apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Apagar.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Apagar.ForeColor = System.Drawing.Color.Red;
            this.Botao_Apagar.Location = new System.Drawing.Point(216, 13);
            this.Botao_Apagar.Name = "Botao_Apagar";
            this.Botao_Apagar.Size = new System.Drawing.Size(11, 18);
            this.Botao_Apagar.TabIndex = 0;
            this.Botao_Apagar.Text = "X";
            this.Botao_Apagar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNome.Location = new System.Drawing.Point(3, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 21);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Obrigatorio";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.Botao_Apagar2);
            this.groupBox4.Controls.Add(this.txtContato);
            this.groupBox4.Location = new System.Drawing.Point(19, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 37);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contato";
            // 
            // Botao_Apagar2
            // 
            this.Botao_Apagar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Apagar2.FlatAppearance.BorderSize = 0;
            this.Botao_Apagar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Apagar2.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Apagar2.ForeColor = System.Drawing.Color.Red;
            this.Botao_Apagar2.Location = new System.Drawing.Point(217, 12);
            this.Botao_Apagar2.Name = "Botao_Apagar2";
            this.Botao_Apagar2.Size = new System.Drawing.Size(11, 18);
            this.Botao_Apagar2.TabIndex = 0;
            this.Botao_Apagar2.Text = "X";
            this.Botao_Apagar2.UseVisualStyleBackColor = true;
            // 
            // txtContato
            // 
            this.txtContato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContato.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtContato.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtContato.Location = new System.Drawing.Point(3, 15);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(229, 21);
            this.txtContato.TabIndex = 2;
            this.txtContato.Text = "Obrigatorio";
            this.txtContato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox7.Controls.Add(this.Botao_Apagar4);
            this.groupBox7.Controls.Add(this.txtCep);
            this.groupBox7.Location = new System.Drawing.Point(20, 189);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(233, 37);
            this.groupBox7.TabIndex = 47;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cep";
            // 
            // Botao_Apagar4
            // 
            this.Botao_Apagar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Apagar4.FlatAppearance.BorderSize = 0;
            this.Botao_Apagar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Apagar4.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Apagar4.ForeColor = System.Drawing.Color.Red;
            this.Botao_Apagar4.Location = new System.Drawing.Point(216, 12);
            this.Botao_Apagar4.Name = "Botao_Apagar4";
            this.Botao_Apagar4.Size = new System.Drawing.Size(11, 18);
            this.Botao_Apagar4.TabIndex = 0;
            this.Botao_Apagar4.Text = "X";
            this.Botao_Apagar4.UseVisualStyleBackColor = true;
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F);
            this.txtCep.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtCep.Location = new System.Drawing.Point(3, 15);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(229, 21);
            this.txtCep.TabIndex = 4;
            this.txtCep.Text = "Obrigatorio";
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Link_Voltar
            // 
            this.Link_Voltar.AutoSize = true;
            this.Link_Voltar.Location = new System.Drawing.Point(204, 271);
            this.Link_Voltar.Name = "Link_Voltar";
            this.Link_Voltar.Size = new System.Drawing.Size(43, 16);
            this.Link_Voltar.TabIndex = 43;
            this.Link_Voltar.TabStop = true;
            this.Link_Voltar.Text = "Voltar";
            this.Link_Voltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Voltar_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
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
            // Botao_IncluirProduto
            // 
            this.Botao_IncluirProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Botao_IncluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_IncluirProduto.Location = new System.Drawing.Point(45, 262);
            this.Botao_IncluirProduto.Name = "Botao_IncluirProduto";
            this.Botao_IncluirProduto.Size = new System.Drawing.Size(122, 35);
            this.Botao_IncluirProduto.TabIndex = 16;
            this.Botao_IncluirProduto.Text = "Salvar Alteração";
            this.Botao_IncluirProduto.UseVisualStyleBackColor = true;
            this.Botao_IncluirProduto.Click += new System.EventHandler(this.Botao_IncluirProduto_Click);
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
            this.Opacidade.Location = new System.Drawing.Point(0, -2);
            this.Opacidade.Name = "Opacidade";
            this.Opacidade.Size = new System.Drawing.Size(951, 341);
            this.Opacidade.TabIndex = 53;
            this.Opacidade.UseVisualStyleBackColor = false;
            this.Opacidade.Visible = false;
            // 
            // FormClientesEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 337);
            this.Controls.Add(this.GroupEdit);
            this.Controls.Add(this.Opacidade);
            this.Controls.Add(this.GRID_Clientes);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Botao_Filtrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.linkLabel1);
            this.MaximumSize = new System.Drawing.Size(965, 376);
            this.MinimumSize = new System.Drawing.Size(965, 376);
            this.Name = "FormClientesEDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Clientes)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.GroupEdit.ResumeLayout(false);
            this.GroupEdit.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRID_Clientes;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Botao_Editar;
        private System.Windows.Forms.ToolStripButton Botao_Excluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Botao_Filtrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox GroupEdit;
        private System.Windows.Forms.LinkLabel Link_Voltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button Botao_IncluirProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Categoria_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Nome_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Ingredientes_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Valor_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Botao_Apagar3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Botao_Apagar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Botao_Apagar2;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Botao_Apagar4;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button Opacidade;
    }
}