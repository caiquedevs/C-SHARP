using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Pizzaria.BLL;
using Pizzaria.DTO;

namespace CobrancaCaixa
{
    public partial class FormProdutos : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public FormProdutos()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

//EVENTOS DO FORM PEDIDO------------------------------------------------------------------------------------------------

        //Botao Cadastrar Novo Produto
        private void Botao_IncluirProduto_Click(object sender, EventArgs e)
        {
            int Resposta;

            ProdutoDTO objNovoProduto = new ProdutoDTO
            {
                NomeProduto1 = txtNomeProduto.Text,
                Ingredientes1 = txtIngrediente.Text,
                Categoria1 = txtCategoria.Text
            };

            Resposta = ClassBLL.InserirNovoProdutoBLL(objNovoProduto, txtValor.Text);

            if (Resposta == 1){ MessageBox.Show("Produto Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            if (Resposta == -1){ MessageBox.Show("Preencha Nome do Produto !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -2) { MessageBox.Show("Preencha Ingredientes do Produto !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -3) { MessageBox.Show("Preencha Valor do Produto !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -4) { MessageBox.Show("Preencha Categoria do Produto !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            else if (Resposta != 1 && Resposta != -1 && Resposta != -2 && Resposta != -3 && Resposta != -4)
            {
                MessageBox.Show("Houve erro ao Cadastrar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Listar Produtos 
        private void Botao_Verificar_Click(object sender, EventArgs e)
        {
            FormProdutosEDIT VerTodos = new FormProdutosEDIT();
            var Resultado = VerTodos.ShowDialog();

        }

        //Link Voltar
        private void Botao_Voltar_Click(object sender, EventArgs e)
        {
            FormHome Voltar = new FormHome();
            this.Hide();
            Voltar.Show();
        }

        //Link Voltar 2
        private void Link_Voltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

//---------------------------------------------------------------------------------------------------------------------

        //Edição dos TextBoxs 

        //CLICK
        private void txtNomeProduto_Click(object sender, EventArgs e)
        {
            //Zerar textBox ao clicar
            if (txtNomeProduto.Text == "Obrigatorio") { txtNomeProduto.Text = ""; }
            if (txtValor.Text == "") { txtValor.Text = "00,00"; }
            if (txtIngrediente.Text == "" && txtCategoria.Text == "Categoria") { txtIngrediente.Text = "Obrigatorio"; txtIngrediente.ForeColor = Color.Silver;  }
            else if (txtIngrediente.Text == "" && txtCategoria.Text == "Pizza") { txtIngrediente.Text = "Ex: Mussarela e Azeitona"; txtIngrediente.ForeColor = Color.Silver; }
            else if (txtIngrediente.Text == "" && txtCategoria.Text == "Bebida") { txtIngrediente.Text = "Ex: Refrigerante ou Suco"; txtIngrediente.ForeColor = Color.Silver; }

        }

        private void txtIngrediente_Click(object sender, EventArgs e)
        {
            if (txtIngrediente.Text == "Obrigatorio" || txtIngrediente.Text == "Ex: Mussarela e Azeitona" || txtIngrediente.Text == "Ex: Refrigerante ou Suco") { txtIngrediente.Text = ""; }
            if (txtNomeProduto.Text == "") { txtNomeProduto.Text = "Obrigatorio"; txtNomeProduto.ForeColor = Color.Silver;  }
            if (txtValor.Text == "")       { txtValor.Text = "00,00";}
        }

        private void txtValor_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "00,00") { txtValor.Text = ""; }
            if (txtNomeProduto.Text == "") { txtNomeProduto.Text = "Obrigatorio"; txtNomeProduto.ForeColor = Color.Silver;  }
            if (txtIngrediente.Text == "" && txtCategoria.Text == "Categoria") { txtIngrediente.Text = "Obrigatorio"; txtIngrediente.ForeColor = Color.Silver; }
            else if (txtIngrediente.Text == "" && txtCategoria.Text == "Pizza") { txtIngrediente.Text = "Ex: Mussarela e Azeitona"; txtIngrediente.ForeColor = Color.Silver; }
            else if (txtIngrediente.Text == "" && txtCategoria.Text == "Bebida") { txtIngrediente.Text = "Ex: Refrigerante ou Suco"; txtIngrediente.ForeColor = Color.Silver; }

        }

        //CHANGE
        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            txtNomeProduto.ForeColor = Color.Black;
        }

        private void txtIngrediente_TextChanged(object sender, EventArgs e)
        {
            txtIngrediente.ForeColor = Color.Black;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.ForeColor = Color.Black;
        }

        //COMBOBOX
        private void txtCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCategoria.Text == "Bebida" && txtIngrediente.Text == "Ex: Mussarela e Azeitona" || txtIngrediente.Text == "Obrigatorio" || txtIngrediente.Text == "")
            {
                txtIngrediente.Text = "Ex: Refrigerante ou Suco"; txtIngrediente.ForeColor = Color.Silver;
            }
            if (txtCategoria.Text == "Pizza" && txtIngrediente.Text == "Ex: Refrigerante ou Suco" || txtIngrediente.Text == "Obrigatorio" || txtIngrediente.Text == "")
            {
                txtIngrediente.Text = "Ex: Mussarela e Azeitona"; txtIngrediente.ForeColor = Color.Silver;
            }
        }

        //Botao Limpar TextBox Nome Produto
        private void Botao_Apagar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Text = "Obrigatorio"; txtNomeProduto.ForeColor = Color.Silver;
        }

        //Botao Limpar TextBox Ingredientes
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Categoria")
            { txtIngrediente.Text = "Obrigatorio"; txtIngrediente.ForeColor = Color.Silver; }

            else if (txtCategoria.Text == "Pizza")
            { txtIngrediente.Text = "Ex: Mussarela e Azeitona"; txtIngrediente.ForeColor = Color.Silver; }

            else if (txtCategoria.Text == "Bebida")
            { txtIngrediente.Text = "Ex: Refrigerante ou Suco"; txtIngrediente.ForeColor = Color.Silver; }
        }
    }
}
