namespace CobrancaCaixa
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Botao_IncluirProduto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Botao_Apagar = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Link_Voltar = new System.Windows.Forms.LinkLabel();
            this.Botao_Verificar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtIngrediente.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIngrediente.Location = new System.Drawing.Point(3, 12);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(229, 17);
            this.txtIngrediente.TabIndex = 4;
            this.txtIngrediente.Text = "Obrigatorio";
            this.txtIngrediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIngrediente.Click += new System.EventHandler(this.txtIngrediente_Click);
            this.txtIngrediente.TextChanged += new System.EventHandler(this.txtIngrediente_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.txtValor);
            this.groupBox5.Location = new System.Drawing.Point(74, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(89, 30);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VALOR";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtValor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtValor.Location = new System.Drawing.Point(10, 13);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(68, 13);
            this.txtValor.TabIndex = 5;
            this.txtValor.Text = "00,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.Click += new System.EventHandler(this.txtValor_Click);
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cadastrar Produtos";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cadastre um produto novo ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(199, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(110, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de ";
            // 
            // Botao_IncluirProduto
            // 
            this.Botao_IncluirProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Botao_IncluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_IncluirProduto.Location = new System.Drawing.Point(86, 276);
            this.Botao_IncluirProduto.Name = "Botao_IncluirProduto";
            this.Botao_IncluirProduto.Size = new System.Drawing.Size(122, 35);
            this.Botao_IncluirProduto.TabIndex = 7;
            this.Botao_IncluirProduto.Text = "Incluir Produto";
            this.Botao_IncluirProduto.UseVisualStyleBackColor = true;
            this.Botao_IncluirProduto.Click += new System.EventHandler(this.Botao_IncluirProduto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Botao_Apagar);
            this.groupBox1.Controls.Add(this.txtNomeProduto);
            this.groupBox1.Location = new System.Drawing.Point(73, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 37);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome do Produto";
            // 
            // Botao_Apagar
            // 
            this.Botao_Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Apagar.FlatAppearance.BorderSize = 0;
            this.Botao_Apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Apagar.ForeColor = System.Drawing.Color.Red;
            this.Botao_Apagar.Location = new System.Drawing.Point(216, 12);
            this.Botao_Apagar.Name = "Botao_Apagar";
            this.Botao_Apagar.Size = new System.Drawing.Size(11, 18);
            this.Botao_Apagar.TabIndex = 21;
            this.Botao_Apagar.Text = "X";
            this.Botao_Apagar.UseVisualStyleBackColor = true;
            this.Botao_Apagar.Click += new System.EventHandler(this.Botao_Apagar_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNomeProduto.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeProduto.Location = new System.Drawing.Point(3, 12);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(229, 17);
            this.txtNomeProduto.TabIndex = 1;
            this.txtNomeProduto.Text = "Obrigatorio";
            this.txtNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeProduto.Click += new System.EventHandler(this.txtNomeProduto_Click);
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Controls.Add(this.Link_Voltar);
            this.panel5.Controls.Add(this.Botao_Verificar);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtCategoria);
            this.panel5.Controls.Add(this.groupBox5);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.Botao_IncluirProduto);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Location = new System.Drawing.Point(110, 60);
            this.panel5.MaximumSize = new System.Drawing.Size(380, 430);
            this.panel5.MinimumSize = new System.Drawing.Size(380, 430);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 430);
            this.panel5.TabIndex = 0;
            // 
            // Link_Voltar
            // 
            this.Link_Voltar.AutoSize = true;
            this.Link_Voltar.Location = new System.Drawing.Point(272, 321);
            this.Link_Voltar.Name = "Link_Voltar";
            this.Link_Voltar.Size = new System.Drawing.Size(34, 13);
            this.Link_Voltar.TabIndex = 14;
            this.Link_Voltar.TabStop = true;
            this.Link_Voltar.Text = "Voltar";
            this.Link_Voltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Voltar_LinkClicked);
            // 
            // Botao_Verificar
            // 
            this.Botao_Verificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Botao_Verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Verificar.Location = new System.Drawing.Point(214, 276);
            this.Botao_Verificar.Name = "Botao_Verificar";
            this.Botao_Verificar.Size = new System.Drawing.Size(64, 35);
            this.Botao_Verificar.TabIndex = 13;
            this.Botao_Verificar.Text = "Ver Todos";
            this.Botao_Verificar.UseVisualStyleBackColor = true;
            this.Botao_Verificar.Click += new System.EventHandler(this.Botao_Verificar_Click);
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
            this.txtCategoria.Location = new System.Drawing.Point(169, 230);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(123, 24);
            this.txtCategoria.TabIndex = 12;
            this.txtCategoria.Text = "Categoria";
            this.txtCategoria.SelectedIndexChanged += new System.EventHandler(this.txtCategoria_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtIngrediente);
            this.groupBox4.Location = new System.Drawing.Point(73, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 37);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ingredientes";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(216, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(11, 18);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 740);
            this.panel1.TabIndex = 17;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 740);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 726);
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdicionar";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Botao_IncluirProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Botao_Verificar;
        private System.Windows.Forms.LinkLabel Link_Voltar;
        private System.Windows.Forms.Button Botao_Apagar;
        private System.Windows.Forms.Button button1;
    }
}