using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.BLL;
using Agenda.DTO;

namespace Agenda.PL
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void Botao_Home_Click(object sender, EventArgs e)
        {
            FormAgenda newForm = new FormAgenda();
            this.Hide();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
