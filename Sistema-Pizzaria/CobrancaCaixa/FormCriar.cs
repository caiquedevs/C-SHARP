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
    public partial class FormCriar : Form
    {
        public ProdutoDTO objProduto;
        public CriaPizza objPizza;
        double VLB1;
        double VLB2;

        //Abrir Form Preenchido
        public FormCriar()
        {
            InitializeComponent();

            GRID_Produtos.DataSource = null;

            List<ProdutoDTO> LISTA = ClassBLL.BuscarPizzas();

            GRID_Produtos.Rows.Clear();

            foreach (var FORpass in LISTA)
            {
                string[] linhaContato = { FORpass.IDProduto1.ToString(), FORpass.Categoria1, FORpass.NomeProduto1,FORpass.Ingredientes1, FORpass.Valor1.ToString(), };
                GRID_Produtos.Rows.Add(linhaContato);
            }

            GRID_Produtos.Visible = true;
        }

//EVENTOS DO FORM PEDIDO------------------------------------------------------------------------------------------------
        private void Botao_Escolher_Click(object sender, EventArgs e)
        {
            string NomeLinha = GRID_Produtos.CurrentRow.Cells["Coluna_Nome"].Value.ToString();

            if (txtPizza1.Text == string.Empty && txtPizza2.Text == string.Empty || txtPizza1.Text == string.Empty && txtPizza2.Text != string.Empty)
            { txtPizza1.Text = NomeLinha; }

            else if (txtPizza1.Text != string.Empty)
            { txtPizza2.Text = NomeLinha; }

            int Mult = int.Parse(ComboQTD.Text);

            //Buscando Valor da Pizza do txt 1
            objProduto = ClassBLL.Buscar_Pizza_1Filtro_Nome(txtPizza1.Text);
            VLB1 = objProduto.Valor1 * Mult;

            //Buscando Valor da Pizza do txt 2
            objProduto = ClassBLL.Buscar_Pizza_1Filtro_Nome(txtPizza2.Text);
            VLB2 = objProduto.Valor1 * Mult;

            if (VLB1 >= VLB2)
            {
                txtValor.Text = VLB1.ToString();
            }
            if (VLB2 >= VLB1)
            {
                txtValor.Text = VLB2.ToString();
            }
        }
        //Pesquisar Pizza pelo FILTRO
        private void Botao_ProcurarPizza_Click_1(object sender, EventArgs e)
        {
             GRID_Produtos.Rows.Clear();

            string[] FiltroUser = { txtProduto.Text };

            List<ProdutoDTO> Produtos = ClassBLL.Buscar_Pizza_1Filtro_Cat(FiltroUser);

            foreach (var FORpass in Produtos)
            {
                string[] linhaContato = { FORpass.IDProduto1.ToString(), FORpass.Categoria1, FORpass.NomeProduto1, FORpass.Ingredientes1, FORpass.Valor1.ToString()};
                GRID_Produtos.Rows.Add(linhaContato);
            }
        }
        
        //Finalizar Pizza Criada
        private void Botao_Finalizar_Click_1(object sender, EventArgs e)
        {
            if(txtPizza1.Text == string.Empty || txtPizza1.Text == "" && txtPizza2.Text == string.Empty || txtPizza2.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para continuar");
                return;
            }
            //Buscando Valor da Pizza do txt 1
            objProduto = ClassBLL.Buscar_Pizza_1Filtro_Nome(txtPizza1.Text);

            int IDcria = objProduto.IDProduto1;
            string IngreCria= objProduto.Ingredientes1;
            double VL1 = objProduto.Valor1 * int.Parse(ComboQTD.Text);

            //Buscando Valor da Pizza do txt 2
            objProduto = ClassBLL.Buscar_Pizza_1Filtro_Nome(txtPizza2.Text);

            int IDcria2 = objProduto.IDProduto1;
            string IngreCria2 = objProduto.Ingredientes1;
            double VL2 = objProduto.Valor1 * int.Parse(ComboQTD.Text);

            //Popular NovaPizza com a Pizza Criada pelo valor Maior
            if (VL1 >= VL2)
            {
                objPizza = new CriaPizza();

                objPizza.ID1 = IDcria;
                objPizza.Qtd1 = int.Parse(ComboQTD.Text);
                objPizza.Nome11 = txtPizza1.Text;
                objPizza.Nome21 = txtPizza2.Text;
                objPizza.IngreCria11 = IngreCria;
                objPizza.IngreCria21 = IngreCria2;
                objPizza.Valor1 = Double.Parse(txtValor.Text);
            }
            //Popular NovaPizza com a Pizza Criada pelo valor Maior
            else if (VL2 >= VL1)
            {
                objPizza = new CriaPizza();

                objPizza.ID1 = IDcria2;
                objPizza.Qtd1 = int.Parse(ComboQTD.Text);
                objPizza.Nome11 = txtPizza1.Text;
                objPizza.Nome21 = txtPizza2.Text;
                objPizza.IngreCria11 = IngreCria;
                objPizza.IngreCria21 = IngreCria2;
                objPizza.Valor1 = Double.Parse(txtValor.Text);
            }

            /*

            int result = ClassBLL.InserirNovoCria(objCria);

            if (result == 1) { MessageBox.Show("Cadastrou !!"); }*/

            DialogResult = DialogResult.OK;

            Close();
        }

//---------------------------------------------------------------------------------------------------------------------

        //Edição dos TextBoxs
        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            txtProduto.ForeColor = Color.Black;
        }

        //Limpar TextBox do FILTRO
        private void txtProduto_Click(object sender, EventArgs e)
        {
            txtProduto.Text = ""; 
        }

        //Botao Limpar TextBox Pizza 1
        private void Apagar1_Click(object sender, EventArgs e)
        {
            txtPizza1.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        //Botao Limpar TextBox Pizza 2
        private void Apagar2_Click(object sender, EventArgs e)
        {
            txtPizza2.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        //Calculo ao Clicar no ComboBox
        private void ComboQTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Mult = int.Parse(ComboQTD.Text);

            //Buscando Valor da Pizza do txt 1
            objProduto = ClassBLL.Buscar_Pizza_1Filtro_Nome(txtPizza1.Text);
            VLB1 = objProduto.Valor1 * Mult;

            //Buscando Valor da Pizza do txt 2
            objProduto = ClassBLL.Buscar_Pizza_1Filtro_Nome(txtPizza2.Text);
            VLB2 = objProduto.Valor1 * Mult;

            if (VLB1 >= VLB2)
            {
                txtValor.Text = VLB1.ToString();
            }
            if (VLB2 >= VLB1)
            {
                txtValor.Text = VLB2.ToString();
            }
        }

        
    }
}

