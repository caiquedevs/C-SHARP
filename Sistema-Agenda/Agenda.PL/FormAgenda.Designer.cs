namespace Agenda.PL
{
    partial class FormAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Check_Contatos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Botao_Agenda = new System.Windows.Forms.Button();
            this.Botao_Editar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Botao_Add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Botao_Excluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Check_Contatos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 30);
            this.panel1.TabIndex = 1;
            // 
            // Check_Contatos
            // 
            this.Check_Contatos.AutoSize = true;
            this.Check_Contatos.Location = new System.Drawing.Point(12, 8);
            this.Check_Contatos.Name = "Check_Contatos";
            this.Check_Contatos.Size = new System.Drawing.Size(15, 14);
            this.Check_Contatos.TabIndex = 1;
            this.Check_Contatos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(295, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contatos";
            // 
            // Botao_Agenda
            // 
            this.Botao_Agenda.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Agenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Agenda.BackgroundImage")));
            this.Botao_Agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Botao_Agenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Agenda.FlatAppearance.BorderSize = 0;
            this.Botao_Agenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Botao_Agenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Botao_Agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Agenda.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Agenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Botao_Agenda.Location = new System.Drawing.Point(1, 3);
            this.Botao_Agenda.Name = "Botao_Agenda";
            this.Botao_Agenda.Size = new System.Drawing.Size(120, 26);
            this.Botao_Agenda.TabIndex = 6;
            this.Botao_Agenda.Text = "Agenda";
            this.Botao_Agenda.UseVisualStyleBackColor = false;
            this.Botao_Agenda.Click += new System.EventHandler(this.Botao_Agenda_Click);
            // 
            // Botao_Editar
            // 
            this.Botao_Editar.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Editar.BackgroundImage")));
            this.Botao_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Botao_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Editar.FlatAppearance.BorderSize = 0;
            this.Botao_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Botao_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Botao_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Editar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Botao_Editar.Location = new System.Drawing.Point(125, 3);
            this.Botao_Editar.Name = "Botao_Editar";
            this.Botao_Editar.Size = new System.Drawing.Size(120, 26);
            this.Botao_Editar.TabIndex = 7;
            this.Botao_Editar.Text = "Editar";
            this.Botao_Editar.UseVisualStyleBackColor = false;
            this.Botao_Editar.Click += new System.EventHandler(this.Botao_Editar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Botao_Add);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Botao_Agenda);
            this.panel2.Controls.Add(this.Botao_Editar);
            this.panel2.Controls.Add(this.Botao_Excluir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 436);
            this.panel2.TabIndex = 9;
            // 
            // Botao_Add
            // 
            this.Botao_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Botao_Add.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Add.BackgroundImage")));
            this.Botao_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Botao_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Botao_Add.FlatAppearance.BorderSize = 0;
            this.Botao_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Botao_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Botao_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Add.Location = new System.Drawing.Point(318, 388);
            this.Botao_Add.Name = "Botao_Add";
            this.Botao_Add.Size = new System.Drawing.Size(45, 45);
            this.Botao_Add.TabIndex = 3;
            this.Botao_Add.UseVisualStyleBackColor = false;
            this.Botao_Add.Click += new System.EventHandler(this.Botao_Add_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 30);
            this.panel3.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(40, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caique  * (13) 98835-0353";
            // 
            // Botao_Excluir
            // 
            this.Botao_Excluir.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Excluir.BackgroundImage")));
            this.Botao_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Botao_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Excluir.FlatAppearance.BorderSize = 0;
            this.Botao_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Botao_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Botao_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Excluir.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Botao_Excluir.Location = new System.Drawing.Point(251, 3);
            this.Botao_Excluir.Name = "Botao_Excluir";
            this.Botao_Excluir.Size = new System.Drawing.Size(120, 26);
            this.Botao_Excluir.TabIndex = 8;
            this.Botao_Excluir.Text = "Excluir";
            this.Botao_Excluir.UseVisualStyleBackColor = false;
            this.Botao_Excluir.Click += new System.EventHandler(this.Botao_Excluir_Click);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 436);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 475);
            this.MinimumSize = new System.Drawing.Size(388, 475);
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastre-se";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Botao_Agenda;
        private System.Windows.Forms.Button Botao_Editar;
        private System.Windows.Forms.CheckBox Check_Contatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Botao_Add;
        private System.Windows.Forms.Button Botao_Excluir;
    }
}