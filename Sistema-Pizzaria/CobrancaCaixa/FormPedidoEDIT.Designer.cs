namespace CobrancaCaixa
{
    partial class FormPedidoEDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidoEDIT));
            this.GRID_Pedidos = new System.Windows.Forms.DataGridView();
            this.Coluna_ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Categoria_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Nome_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Ingredientes_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Valor_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Botao_Editar = new System.Windows.Forms.ToolStripButton();
            this.Botao_Excluir = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Botao_Filtrar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Pedidos)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRID_Pedidos
            // 
            this.GRID_Pedidos.AllowUserToAddRows = false;
            this.GRID_Pedidos.AllowUserToDeleteRows = false;
            this.GRID_Pedidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GRID_Pedidos.BackgroundColor = System.Drawing.Color.White;
            this.GRID_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_ID_Cliente,
            this.Coluna_Categoria_Produtos,
            this.Coluna_Nome_Produtos,
            this.Column1,
            this.Coluna_Ingredientes_Produto,
            this.Coluna_Valor_Produtos});
            this.GRID_Pedidos.Location = new System.Drawing.Point(12, 46);
            this.GRID_Pedidos.Name = "GRID_Pedidos";
            this.GRID_Pedidos.ReadOnly = true;
            this.GRID_Pedidos.Size = new System.Drawing.Size(822, 266);
            this.GRID_Pedidos.TabIndex = 55;
            this.GRID_Pedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_Clientes_CellContentClick);
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
            this.Coluna_Categoria_Produtos.Width = 200;
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
            // Column1
            // 
            this.Column1.HeaderText = "CATEGORIA";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Coluna_Ingredientes_Produto
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Ingredientes_Produto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Coluna_Ingredientes_Produto.HeaderText = "NOME PRODUTO";
            this.Coluna_Ingredientes_Produto.Name = "Coluna_Ingredientes_Produto";
            this.Coluna_Ingredientes_Produto.ReadOnly = true;
            this.Coluna_Ingredientes_Produto.Width = 200;
            // 
            // Coluna_Valor_Produtos
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coluna_Valor_Produtos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Coluna_Valor_Produtos.HeaderText = "VALOR";
            this.Coluna_Valor_Produtos.Name = "Coluna_Valor_Produtos";
            this.Coluna_Valor_Produtos.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Botao_Editar,
            this.Botao_Excluir});
            this.toolStrip2.Location = new System.Drawing.Point(9, 18);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(142, 25);
            this.toolStrip2.TabIndex = 59;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Botao_Editar
            // 
            this.Botao_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Botao_Editar.Image")));
            this.Botao_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Botao_Editar.Name = "Botao_Editar";
            this.Botao_Editar.Size = new System.Drawing.Size(57, 22);
            this.Botao_Editar.Text = "Editar";
            // 
            // Botao_Excluir
            // 
            this.Botao_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Botao_Excluir.Image")));
            this.Botao_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Botao_Excluir.Name = "Botao_Excluir";
            this.Botao_Excluir.Size = new System.Drawing.Size(73, 22);
            this.Botao_Excluir.Text = "Cancelar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Contato Cliente";
            // 
            // Botao_Filtrar
            // 
            this.Botao_Filtrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Filtrar.BackgroundImage")));
            this.Botao_Filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Filtrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Filtrar.FlatAppearance.BorderSize = 0;
            this.Botao_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Filtrar.Location = new System.Drawing.Point(443, 18);
            this.Botao_Filtrar.Name = "Botao_Filtrar";
            this.Botao_Filtrar.Size = new System.Drawing.Size(24, 24);
            this.Botao_Filtrar.TabIndex = 58;
            this.Botao_Filtrar.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(307, 20);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(130, 20);
            this.txtFiltro.TabIndex = 57;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(661, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 60;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormPedidoEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 324);
            this.Controls.Add(this.GRID_Pedidos);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Botao_Filtrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.linkLabel1);
            this.Name = "FormPedidoEDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedidoEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Pedidos)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRID_Pedidos;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Botao_Editar;
        private System.Windows.Forms.ToolStripButton Botao_Excluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Botao_Filtrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Categoria_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Nome_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Ingredientes_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Valor_Produtos;
    }
}