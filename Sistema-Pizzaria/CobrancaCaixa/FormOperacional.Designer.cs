namespace CobrancaCaixa
{
    partial class FormOperacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperacional));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Botao_ConsultarPedidos = new System.Windows.Forms.Button();
            this.Botao_ConsultarProdutos = new System.Windows.Forms.Button();
            this.Botao_ConsultarClientes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(199, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerLoginToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.opçõesToolStripMenuItem.Text = "Ferramentas";
            // 
            // fazerLoginToolStripMenuItem
            // 
            this.fazerLoginToolStripMenuItem.Name = "fazerLoginToolStripMenuItem";
            this.fazerLoginToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fazerLoginToolStripMenuItem.Text = "Fazer Login";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Botao_ConsultarClientes);
            this.panel1.Controls.Add(this.Botao_ConsultarProdutos);
            this.panel1.Controls.Add(this.Botao_ConsultarPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 202);
            this.panel1.TabIndex = 5;
            // 
            // Botao_ConsultarPedidos
            // 
            this.Botao_ConsultarPedidos.Location = new System.Drawing.Point(36, 21);
            this.Botao_ConsultarPedidos.Name = "Botao_ConsultarPedidos";
            this.Botao_ConsultarPedidos.Size = new System.Drawing.Size(136, 51);
            this.Botao_ConsultarPedidos.TabIndex = 1;
            this.Botao_ConsultarPedidos.Text = "Consultar Pedidos";
            this.Botao_ConsultarPedidos.UseVisualStyleBackColor = true;
            this.Botao_ConsultarPedidos.Click += new System.EventHandler(this.Botao_CancelarPedido_Click);
            // 
            // Botao_ConsultarProdutos
            // 
            this.Botao_ConsultarProdutos.Location = new System.Drawing.Point(36, 78);
            this.Botao_ConsultarProdutos.Name = "Botao_ConsultarProdutos";
            this.Botao_ConsultarProdutos.Size = new System.Drawing.Size(136, 51);
            this.Botao_ConsultarProdutos.TabIndex = 2;
            this.Botao_ConsultarProdutos.Text = "Consultar Produtos";
            this.Botao_ConsultarProdutos.UseVisualStyleBackColor = true;
            this.Botao_ConsultarProdutos.Click += new System.EventHandler(this.Botao_ConsultarProdutos_Click);
            // 
            // Botao_ConsultarClientes
            // 
            this.Botao_ConsultarClientes.Location = new System.Drawing.Point(36, 135);
            this.Botao_ConsultarClientes.Name = "Botao_ConsultarClientes";
            this.Botao_ConsultarClientes.Size = new System.Drawing.Size(136, 51);
            this.Botao_ConsultarClientes.TabIndex = 3;
            this.Botao_ConsultarClientes.Text = "Consultar Clientes";
            this.Botao_ConsultarClientes.UseVisualStyleBackColor = true;
            this.Botao_ConsultarClientes.Click += new System.EventHandler(this.Botao_ConsultarClientes_Click);
            // 
            // FormOperacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 226);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOperacional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacional";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerLoginToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button Botao_ConsultarPedidos;
        private System.Windows.Forms.Button Botao_ConsultarClientes;
        private System.Windows.Forms.Button Botao_ConsultarProdutos;
    }
}