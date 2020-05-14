using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.BLL;
using Pizzaria.DTO;

namespace CobrancaCaixa
{
    public partial class FormProdutosEDIT : Form
    {
        public ProdutoDTO objProduto;

        //Abrir o Formulario Com Grid Cheio
        public FormProdutosEDIT()
        {
            InitializeComponent();

            GRID_Produtos.DataSource = null;

            List<ProdutoDTO> LISTA = ClassBLL.BuscarProdutos();

            GRID_Produtos.Rows.Clear();

            foreach (var FORpass in LISTA)
            {
                string[] linhaContato = { FORpass.IDProduto1.ToString(), FORpass.Categoria1, FORpass.NomeProduto1, FORpass.Ingredientes1, FORpass.Valor1.ToString(), };
                GRID_Produtos.Rows.Add(linhaContato);
            }

            GRID_Produtos.Visible = true;
        }

        //Filtrar os produtos 
        private void Botao_Filtrar_Click(object sender, EventArgs e)
        {
            
            GRID_Produtos.Rows.Clear();

            string[] FiltroUser = { txtFiltro.Text };

            List<ProdutoDTO> Produtos = ClassBLL.BuscarProduto_1Filtro(FiltroUser);

            foreach (var FORpass in Produtos)
            {
                string[] linhaContato = { FORpass.IDProduto1.ToString(), FORpass.Categoria1, FORpass.NomeProduto1, FORpass.Ingredientes1, FORpass.Valor1.ToString() };
                GRID_Produtos.Rows.Add(linhaContato);
            }

            txtFiltro.Text = string.Empty;
        }

        //Editar Produto pelo ID ao selecionar com o mouse
        private void Botao_Editar_Click(object sender, EventArgs e)
        {
            GroupEdit.Visible = true;
            Opacidade.Visible = true;
            int IDLinha = int.Parse(GRID_Produtos.CurrentRow.Cells["Coluna_ID_Produto"].Value.ToString());

            if (IDLinha != 0)
            {
                objProduto = ClassBLL.BuscarProduto_ID(IDLinha);

                txtID.Text = objProduto.IDProduto1.ToString();
                txtNomeProduto.Text = objProduto.NomeProduto1;
                txtIngrediente.Text = objProduto.Ingredientes1;
                txtValor.Text = objProduto.Valor1.ToString();
                txtCategoria.Text = objProduto.Categoria1;
            }
        }

        //Salvar Edição
        private void Botao_IncluirProduto_Click(object sender, EventArgs e)
        {
            int Resposta;

            if (objProduto == null)
                objProduto = new ProdutoDTO();

            objProduto.IDProduto1 = int.Parse(txtID.Text);
            objProduto.NomeProduto1 = txtNomeProduto.Text;
            objProduto.Ingredientes1 = txtIngrediente.Text;
            objProduto.Categoria1 = txtCategoria.Text;

            Resposta = ClassBLL.AtualizarProduto(objProduto, txtValor.Text);

            if (Resposta == 1) { MessageBox.Show("Produto editado com Sucesso !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            if (Resposta == -1) { MessageBox.Show("Preencha Nome do Produto !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -2) { MessageBox.Show("Preencha Ingredientes do Produto !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -3) { MessageBox.Show("Preencha Valor do Produto !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -4) { MessageBox.Show("Preencha Categoria do Produto !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            else if (Resposta != 1 && Resposta != -1 && Resposta != -2 && Resposta != -3 && Resposta != -4)
            {
                MessageBox.Show("Houve erro ao atualizar o Produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GroupEdit.Visible = false;
            Opacidade.Visible = false;

            string[] linhaContato = { objProduto.IDProduto1.ToString(), objProduto.Categoria1, objProduto.NomeProduto1, objProduto.Ingredientes1, objProduto.Valor1.ToString(),  };

            GRID_Produtos.Rows[GRID_Produtos.CurrentRow.Index].SetValues(linhaContato);

            

        }

        //Link Voltar
        private void Link_Voltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GroupEdit.Visible = false;
            Opacidade.Visible = false;
        }

        //Exluir Produto
        private void Botao_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do contato selecionado?", "Excluir Contato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int IDLinha = int.Parse(GRID_Produtos.CurrentRow.Cells["Coluna_ID_Produto"].Value.ToString());

                int result = ClassBLL.ExcluirProduto_GRID_PEDIDO(IDLinha);

                if (result == 1)
                {
                    MessageBox.Show("Excluido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GRID_Produtos.Rows.RemoveAt(GRID_Produtos.CurrentRow.Index);
                }
                else
                    MessageBox.Show("Houve erro ao tentar Excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }



        private void Botao_Apagar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Text = "Obrigatorio"; txtNomeProduto.ForeColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Pizza")
            { txtIngrediente.Text = "Ex: Mussarela e Azeitona"; txtIngrediente.ForeColor = Color.Silver; }

            else if (txtCategoria.Text == "Bebida")
            { txtIngrediente.Text = "Ex: Refrigerante ou Suco"; txtIngrediente.ForeColor = Color.Silver; }
        }

        private void txtNomeProduto_Click(object sender, EventArgs e)
        {
            //Zerar textBox ao clicar
            if (txtNomeProduto.Text == "Obrigatorio") { txtNomeProduto.Text = ""; }
            if (txtValor.Text == "") { txtValor.Text = "00,00"; }
            else if (txtIngrediente.Text == "" && txtCategoria.Text == "Pizza") { txtIngrediente.Text = "Ex: Mussarela e Azeitona"; txtIngrediente.ForeColor = Color.Silver; }
            else if (txtIngrediente.Text == "" && txtCategoria.Text == "Bebida") { txtIngrediente.Text = "Ex: Refrigerante ou Suco"; txtIngrediente.ForeColor = Color.Silver; }

        }

        private void txtIngrediente_Click(object sender, EventArgs e)
        {
            if (txtIngrediente.Text == "Obrigatorio" || txtIngrediente.Text == "Ex: Mussarela e Azeitona" || txtIngrediente.Text == "Ex: Refrigerante ou Suco") { txtIngrediente.Text = ""; }
            if (txtNomeProduto.Text == "") { txtNomeProduto.Text = "Obrigatorio"; txtNomeProduto.ForeColor = Color.Silver; }
            if (txtValor.Text == "") { txtValor.Text = "00,00"; }
        }

        private void txtValor_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "00,00") { txtValor.Text = ""; }
            if (txtNomeProduto.Text == "") { txtNomeProduto.Text = "Obrigatorio"; txtNomeProduto.ForeColor = Color.Silver; }
            else if (txtIngrediente.Text == "" && txtCategoria.Text == "Pizza") { txtIngrediente.Text = "Ex: Mussarela e Azeitona"; txtIngrediente.ForeColor = Color.Silver; }
            else if (txtIngrediente.Text == "" && txtCategoria.Text == "Bebida") { txtIngrediente.Text = "Ex: Refrigerante ou Suco"; txtIngrediente.ForeColor = Color.Silver; }

        }

        private void txtCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Bebida" && txtIngrediente.Text == "Ex: Mussarela e Azeitona" || txtIngrediente.Text == "")
            {
                txtIngrediente.Text = "Ex: Refrigerante ou Suco"; txtIngrediente.ForeColor = Color.Silver;
            }
            if (txtCategoria.Text == "Pizza" && txtIngrediente.Text == "Ex: Refrigerante ou Suco" || txtIngrediente.Text == "")
            {
                txtIngrediente.Text = "Ex: Mussarela e Azeitona"; txtIngrediente.ForeColor = Color.Silver;
            }
        }

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
    }
}
