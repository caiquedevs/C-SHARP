namespace CobrancaCaixa
{
    partial class FormHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.statusBar1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Botao_CadastrarCliente = new System.Windows.Forms.Button();
            this.Botao_CadastrarProduto = new System.Windows.Forms.Button();
            this.Botao_Operacional = new System.Windows.Forms.Button();
            this.Botao_Pedido = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Opacidade = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar1.BackColor = System.Drawing.Color.Navy;
            this.statusBar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar1.ForeColor = System.Drawing.Color.White;
            this.statusBar1.Location = new System.Drawing.Point(0, 659);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(980, 28);
            this.statusBar1.TabIndex = 14;
            this.statusBar1.Text = "Telefone: (13) 3467-8048    -    Whatsapp : (13) 9 8835-0453    -    Endereço: R." +
    " Capitão José Meirelhes    -    Cep: 11330-180    -    Atendimento: 18h/00h";
            this.statusBar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusBar1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Opacidade);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 655);
            this.panel1.TabIndex = 12;
            // 
            // Botao_CadastrarCliente
            // 
            this.Botao_CadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_CadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Botao_CadastrarCliente.Location = new System.Drawing.Point(3, 255);
            this.Botao_CadastrarCliente.Name = "Botao_CadastrarCliente";
            this.Botao_CadastrarCliente.Size = new System.Drawing.Size(220, 79);
            this.Botao_CadastrarCliente.TabIndex = 5;
            this.Botao_CadastrarCliente.Text = "Cadastrar Cliente";
            this.Botao_CadastrarCliente.UseVisualStyleBackColor = true;
            this.Botao_CadastrarCliente.Click += new System.EventHandler(this.Botao_CadastrarCliente_Click);
            // 
            // Botao_CadastrarProduto
            // 
            this.Botao_CadastrarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_CadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Botao_CadastrarProduto.Location = new System.Drawing.Point(3, 170);
            this.Botao_CadastrarProduto.Name = "Botao_CadastrarProduto";
            this.Botao_CadastrarProduto.Size = new System.Drawing.Size(220, 79);
            this.Botao_CadastrarProduto.TabIndex = 4;
            this.Botao_CadastrarProduto.Text = "Cadastrar Produto";
            this.Botao_CadastrarProduto.UseVisualStyleBackColor = true;
            this.Botao_CadastrarProduto.Click += new System.EventHandler(this.Botao_CadastrarProduto_Click);
            // 
            // Botao_Operacional
            // 
            this.Botao_Operacional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Operacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Botao_Operacional.Location = new System.Drawing.Point(3, 85);
            this.Botao_Operacional.Name = "Botao_Operacional";
            this.Botao_Operacional.Size = new System.Drawing.Size(220, 79);
            this.Botao_Operacional.TabIndex = 3;
            this.Botao_Operacional.Text = "Operacional";
            this.Botao_Operacional.UseVisualStyleBackColor = true;
            this.Botao_Operacional.Click += new System.EventHandler(this.Botao_Operacional_Click);
            // 
            // Botao_Pedido
            // 
            this.Botao_Pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Pedido.Location = new System.Drawing.Point(3, 0);
            this.Botao_Pedido.Name = "Botao_Pedido";
            this.Botao_Pedido.Size = new System.Drawing.Size(220, 79);
            this.Botao_Pedido.TabIndex = 2;
            this.Botao_Pedido.Text = "Fazer Pedido";
            this.Botao_Pedido.UseVisualStyleBackColor = true;
            this.Botao_Pedido.Click += new System.EventHandler(this.Botao_Pedido_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.Botao_Pedido);
            this.panel2.Controls.Add(this.Botao_Operacional);
            this.panel2.Controls.Add(this.Botao_CadastrarProduto);
            this.panel2.Controls.Add(this.Botao_CadastrarCliente);
            this.panel2.Location = new System.Drawing.Point(748, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 649);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 539);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.Opacidade.Location = new System.Drawing.Point(0, 0);
            this.Opacidade.Name = "Opacidade";
            this.Opacidade.Size = new System.Drawing.Size(743, 655);
            this.Opacidade.TabIndex = 6;
            this.Opacidade.UseVisualStyleBackColor = false;
            this.Opacidade.Visible = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(979, 686);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(979, 686);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button statusBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Botao_CadastrarCliente;
        private System.Windows.Forms.Button Botao_CadastrarProduto;
        private System.Windows.Forms.Button Botao_Operacional;
        private System.Windows.Forms.Button Botao_Pedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Opacidade;
    }
}

