namespace Agenda.PL
{
    partial class CONSULTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONSULTA));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Botao_Editar = new System.Windows.Forms.ToolStripButton();
            this.Botao_Excluir = new System.Windows.Forms.ToolStripButton();
            this.Botao_Filtrar = new System.Windows.Forms.ToolStripButton();
            this.GRID = new System.Windows.Forms.DataGridView();
            this.Botao_Cadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltroNome = new System.Windows.Forms.TextBox();
            this.txtFiltroContato = new System.Windows.Forms.TextBox();
            this.ColunaID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.GRID);
            this.panel1.Controls.Add(this.Botao_Cadastrar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 687);
            this.panel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Botao_Editar,
            this.Botao_Excluir,
            this.Botao_Filtrar});
            this.toolStrip1.Location = new System.Drawing.Point(1, 475);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(187, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            // Botao_Filtrar
            // 
            this.Botao_Filtrar.Image = ((System.Drawing.Image)(resources.GetObject("Botao_Filtrar.Image")));
            this.Botao_Filtrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Botao_Filtrar.Name = "Botao_Filtrar";
            this.Botao_Filtrar.Size = new System.Drawing.Size(57, 22);
            this.Botao_Filtrar.Text = "Filtrar";
            this.Botao_Filtrar.Click += new System.EventHandler(this.Botao_Filtrar_Click);
            // 
            // GRID
            // 
            this.GRID.AllowUserToAddRows = false;
            this.GRID.AllowUserToDeleteRows = false;
            this.GRID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(213)))), ((int)(((byte)(87)))));
            this.GRID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID.DefaultCellStyle = dataGridViewCellStyle7;
            this.GRID.Location = new System.Drawing.Point(0, 500);
            this.GRID.Name = "GRID";
            this.GRID.ReadOnly = true;
            this.GRID.Size = new System.Drawing.Size(534, 187);
            this.GRID.TabIndex = 3;
            // 
            // Botao_Cadastrar
            // 
            this.Botao_Cadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Cadastrar.BackgroundImage")));
            this.Botao_Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Botao_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Cadastrar.FlatAppearance.BorderSize = 0;
            this.Botao_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Cadastrar.Location = new System.Drawing.Point(72, 56);
            this.Botao_Cadastrar.Name = "Botao_Cadastrar";
            this.Botao_Cadastrar.Size = new System.Drawing.Size(162, 44);
            this.Botao_Cadastrar.TabIndex = 1;
            this.Botao_Cadastrar.UseVisualStyleBackColor = true;
            this.Botao_Cadastrar.Click += new System.EventHandler(this.Botao_Cadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltroNome);
            this.groupBox1.Controls.Add(this.txtFiltroContato);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(191, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 35);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFiltroNome.Location = new System.Drawing.Point(9, 14);
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.Size = new System.Drawing.Size(150, 20);
            this.txtFiltroNome.TabIndex = 8;
            this.txtFiltroNome.Text = "Nome";
            this.txtFiltroNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroNome.Click += new System.EventHandler(this.txtFiltroNome_Click);
            this.txtFiltroNome.TextChanged += new System.EventHandler(this.txtFiltroNome_TextChanged);
            // 
            // txtFiltroContato
            // 
            this.txtFiltroContato.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFiltroContato.Location = new System.Drawing.Point(165, 14);
            this.txtFiltroContato.Name = "txtFiltroContato";
            this.txtFiltroContato.Size = new System.Drawing.Size(163, 20);
            this.txtFiltroContato.TabIndex = 7;
            this.txtFiltroContato.Text = "Contato";
            this.txtFiltroContato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroContato.Click += new System.EventHandler(this.txtFiltroContato_Click);
            this.txtFiltroContato.TextChanged += new System.EventHandler(this.txtFiltroContato_TextChanged);
            // 
            // ColunaID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.ColunaID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColunaID.HeaderText = "  ID";
            this.ColunaID.Name = "ColunaID";
            this.ColunaID.ReadOnly = true;
            this.ColunaID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColunaID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColunaID.Width = 40;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "            NOME";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 118;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "       SOBRENOME";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "     CONTATO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "          CEP";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 93;
            // 
            // CONSULTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 687);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(551, 735);
            this.MinimumSize = new System.Drawing.Size(551, 726);
            this.Name = "CONSULTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Botao_Cadastrar;
        private System.Windows.Forms.DataGridView GRID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Botao_Filtrar;
        private System.Windows.Forms.ToolStripButton Botao_Editar;
        private System.Windows.Forms.ToolStripButton Botao_Excluir;
        private System.Windows.Forms.TextBox txtFiltroContato;
        private System.Windows.Forms.TextBox txtFiltroNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewButtonColumn ColunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}