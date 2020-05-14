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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();  
        }

//EVENTOS DO FORM PEDIDO------------------------------------------------------------------------------------------------

        //Botao Form Pedido
        private void Botao_Pedido_Click(object sender, EventArgs e)
        {
            FormPedido NovoPedido = new FormPedido();
            this.Hide();
            NovoPedido.Show();
        }

        //Botao Form Cadastrar Cliente
        private void Botao_CadastrarCliente_Click(object sender, EventArgs e)
        {
            Opacidade.BackColor = Color.FromArgb(150, 0, 0, 0);
            Opacidade.Visible = true;

            FormCadastrar NovoCadastro = new FormCadastrar();
            var result = NovoCadastro.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
            if (result == DialogResult.Cancel)
            {
                Opacidade.Visible = false;
            }

        }

        //Botao Form Cadastrar Produto
        private void Botao_CadastrarProduto_Click(object sender, EventArgs e)
        {
            Opacidade.BackColor = Color.FromArgb(150, 0, 0, 0);
            Opacidade.Visible = true;

            FormProdutos NovoProdruto = new FormProdutos();
            var result = NovoProdruto.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Opacidade.BackColor = Color.FromArgb(0, 0, 0, 0);
                Opacidade.Visible = false;
            }

        }

        //Botao Form Operacional
        private void Botao_Operacional_Click(object sender, EventArgs e)
        {
            FormOperacional Operacional = new FormOperacional();
            Operacional.ShowDialog();
        }

//---------------------------------------------------------------------------------------------------------------------

    }

    
}
