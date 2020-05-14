using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobrancaCaixa
{
    public partial class FormOperacional : Form
    {
        public FormOperacional()
        {
            InitializeComponent();
        }

        

        private void Botao_EditarCliente_Click(object sender, EventArgs e)
        {
            FormClientesEDIT NovoEdit = new FormClientesEDIT();
            NovoEdit.Show();
        }

        private void Botao_CancelarPedido_Click(object sender, EventArgs e)
        {
            FormPedidoEDIT NewForm = new FormPedidoEDIT();
            NewForm.Show();
        }

        private void Botao_ConsultarProdutos_Click(object sender, EventArgs e)
        {
            FormProdutosEDIT NovoForm = new FormProdutosEDIT(); 
            NovoForm.Show();
        }

        private void Botao_ConsultarClientes_Click(object sender, EventArgs e)
        {
            FormClientesEDIT NovoForm = new FormClientesEDIT();
            NovoForm.Show();
        }
    }
}
