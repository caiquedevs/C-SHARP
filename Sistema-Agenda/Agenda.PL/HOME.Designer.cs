namespace Agenda.PL
{
    partial class HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.Botao_Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Botao_Home
            // 
            this.Botao_Home.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Home.BackgroundImage")));
            this.Botao_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Botao_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Home.FlatAppearance.BorderSize = 0;
            this.Botao_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Botao_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Botao_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Home.ForeColor = System.Drawing.Color.Transparent;
            this.Botao_Home.Location = new System.Drawing.Point(111, 343);
            this.Botao_Home.Name = "Botao_Home";
            this.Botao_Home.Size = new System.Drawing.Size(182, 59);
            this.Botao_Home.TabIndex = 0;
            this.Botao_Home.UseVisualStyleBackColor = false;
            this.Botao_Home.Click += new System.EventHandler(this.Botao_Home_Click);
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(372, 436);
            this.Controls.Add(this.Botao_Home);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 475);
            this.MinimumSize = new System.Drawing.Size(388, 475);
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Botao_Home;
    }
}

