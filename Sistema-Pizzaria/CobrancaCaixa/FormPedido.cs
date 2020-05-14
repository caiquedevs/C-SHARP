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
    public partial class FormPedido : Form
    {
        List<ProdutoDTO> ListaItem = new List<ProdutoDTO>();
        public ClienteDTO objCliente;
        public ProdutoDTO objProduto;
        public CriaPizza objCria;
        
        static double Valor = 0;
        static double ValorExcluso = 0;
        int IDedita = 0;
        string CNome;
        string CQTD;
        double VL;
        int Key = 0;
        int IDcliente;
        int Resposta;
        



        //Form Pedido Comum
        public FormPedido()
        {

            InitializeComponent();
            Valor = 0;
            txtContato.Text = string.Empty;

            GRID_Produtos.DataSource = null;

            List<ProdutoDTO> LISTA = ClassBLL.BuscarProdutos();

            GRID_Produtos.Rows.Clear();

            foreach (var FORpass in LISTA)
            {
                string[] linhaContato = { FORpass.IDProduto1.ToString(), FORpass.Categoria1, FORpass.NomeProduto1, FORpass.Valor1.ToString(), };
                GRID_Produtos.Rows.Add(linhaContato);
            }

            GRID_Produtos.Visible = true;


        }

        //Form Pedido Sobrecarregado Com Dados do novo Cliente
        public FormPedido(ClienteDTO DadosCliente)
        {
            
            InitializeComponent();
            Valor = 0;
            GRID_Produtos.DataSource = null;

            List<ProdutoDTO> LISTA = ClassBLL.BuscarProdutos();

            GRID_Produtos.Rows.Clear();

            foreach (var FORpass in LISTA)
            {
                string[] linhaContato = { FORpass.IDProduto1.ToString(), FORpass.Categoria1, FORpass.NomeProduto1, FORpass.Valor1.ToString(), };
                GRID_Produtos.Rows.Add(linhaContato);
            }

            GRID_Produtos.Visible = true;

            if (DadosCliente != null)
            { 
                txtContato.Visible = true;
                BoxNome.Visible = true;
                BoxEndereco.Visible = true;
                BoxCep.Visible = true;
                BoxNumero.Visible = true;
                BoxComplemento.Visible = true;
        
                txtContato.Text = DadosCliente.ContatoCliente1;
                txtNome.Text = DadosCliente.NomeCLiente1;
                txtEndereco.Text = DadosCliente.EnderecoCliente1;
                txtCep.Text = DadosCliente.CepCliente1;
                txtNumero.Text = DadosCliente.CepCliente1;
                txtComplemento.Text = DadosCliente.ComplementoCliente1;

            }
        }

//EVENTOS DO FORM PEDIDO------------------------------------------------------------------------------------------------

        //Botao Procurar Cliente Existente no Pedido
        private void Botao_ProcurarCliente_Click(object sender, EventArgs e)
        {
            FormProcurarCliente Procura = new FormProcurarCliente();
            var result = Procura.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtContato.Visible = true;
                BoxNome.Visible = true;
                BoxEndereco.Visible = true;
                BoxCep.Visible = true;
                BoxNumero.Visible = true;
                BoxComplemento.Visible = true;

                txtContato.ForeColor = Color.Black;
                txtNome.ForeColor = Color.Black;
                txtEndereco.ForeColor = Color.Black;
                txtCep.ForeColor = Color.Black;
                txtNumero.ForeColor = Color.Black;
                txtComplemento.ForeColor = Color.Black;

                txtContato.Text = Procura.objCliente.ContatoCliente1;
                txtNome.Text = Procura.objCliente.NomeCLiente1;
                txtEndereco.Text = Procura.objCliente.EnderecoCliente1;
                txtCep.Text = Procura.objCliente.CepCliente1;
                txtNumero.Text = Procura.objCliente.NumeroCliente1;
                txtComplemento.Text = Procura.objCliente.ComplementoCliente1;

            }
        }

        //Botao Filtrar Produtos no Pedido
        private void Botao_Filtrar_Click(object sender, EventArgs e)
        {
            GRID_Produtos.Rows.Clear();

            string[] FiltroUser = { txtFiltroCategoria.Text, txtFiltroProduto.Text};

            List<ProdutoDTO> Produtos = ClassBLL.BuscarProduto_2Filtros(FiltroUser);

            foreach (var FORpass in Produtos)
            {
                string[] linhaContato = { FORpass.IDProduto1.ToString(), FORpass.Categoria1, FORpass.NomeProduto1, FORpass.Valor1.ToString()};
                GRID_Produtos.Rows.Add(linhaContato);
            }
        }

        //Botao Cancelar Pedido
        private void Botao_Cancel_Click(object sender, EventArgs e)
        {
            FormHome Voltar = new FormHome();
            this.Hide();
            Voltar.Show();
        }

        //Botao Incluir Item do GRID Pedido
        private void Botao_Incluir_Click(object sender, EventArgs e)
        {
            if (txtContato.Text == string.Empty) { MessageBox.Show("Selecione um Cliente Primeiro","Opss",MessageBoxButtons.OK,MessageBoxIcon.Stop); return; }
            int IDLinha = int.Parse(GRID_Produtos.CurrentRow.Cells["Coluna_ID_Produto"].Value.ToString());

            if (IDLinha != 0)
            {
                Key = 1;

                objProduto = ClassBLL.BuscarProduto_ID(IDLinha);

                List<ProdutoDTO> LISTA = new List<ProdutoDTO>();

                LISTA.Add(objProduto);

                ListaItem.Add(objProduto);

                foreach (var FORpass in LISTA)
                {
                    string[] linhaContato = { FORpass.IDProduto1.ToString(), FORpass.NomeProduto1, FORpass.Ingredientes1, "1", FORpass.Valor1.ToString(), };
                    GRID.Rows.Add(linhaContato);
                    Valor += FORpass.Valor1;

                    TOTAL.Text = Valor.ToString();
                    RESTANTE.Text = TOTAL.Text;
                }
            }
            else
                MessageBox.Show("Produto nao encontrado para inclusao !","Opss",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            

        }

        //Botao Excluir Item do Grid Pedido
        private void Botao_ExcluirProduto_Click(object sender, EventArgs e)
        {
            if (GRID.RowCount > 0 && MessageBox.Show("Confirma a exclusão do item selecionado?", "Excluir Contato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int IDLinha = int.Parse(GRID.CurrentRow.Cells["Coluna_Venda_ID"].Value.ToString());
                
                    for (int i = 0; i <= ListaItem.Count - 1; i++)
                    {
                        if (ListaItem[i].IDProduto1 == IDLinha)
                        {
                            ListaItem.RemoveAt(i);
                        }
                    }

                
                ValorExcluso = double.Parse(GRID.CurrentRow.Cells["Coluna_Venda_Valor"].Value.ToString());
                Valor -= ValorExcluso;
                TOTAL.Text = Valor.ToString();
                RESTANTE.Text = TOTAL.Text;
                //ClassBLL.ExcluirItem(IDLinha);

                GRID.Rows.RemoveAt(GRID.CurrentRow.Index);
            }
            else if (txtContato.Text == string.Empty) { MessageBox.Show("Selecione um Cliente Primeiro", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
        }

        //Botao Criar Pizza
        private void Botao_Criar_Click(object sender, EventArgs e)
        {
            FormCriar Criar = new FormCriar();
            var Result = Criar.ShowDialog();

            if (Result == DialogResult.OK)
            {
                string JuntaNome = Criar.objPizza.Nome11 +" 1/2 "+ Criar.objPizza.Nome21;
                string JuntaIngre = Criar.objPizza.IngreCria11 + " / " + Criar.objPizza.IngreCria21;

                string[] linhaContato = { Criar.objPizza.ID1.ToString(), JuntaNome, JuntaIngre, Criar.objPizza.Qtd1.ToString(), Criar.objPizza.Valor1.ToString() };
                GRID.Rows.Add(linhaContato);

                ProdutoDTO ProdutoCria = new ProdutoDTO();
                ProdutoCria.IDProduto1 = Criar.objPizza.ID1;
                ProdutoCria.NomeProduto1 = JuntaNome;
                ProdutoCria.Ingredientes1 = JuntaIngre;
                ProdutoCria.Valor1 = Criar.objPizza.Valor1;
                ProdutoCria.Qtd = Criar.objPizza.Qtd1;

                ListaItem.Add(ProdutoCria);


                Valor += Criar.objPizza.Valor1;

                TOTAL.Text = Valor.ToString();
                RESTANTE.Text = TOTAL.Text;
                Key = 1;
            }

            
        }
        
        //Botao Salvar Alteração dos ingredientes
        private void Link_Salvar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int IDconfere = int.Parse(GRID.CurrentRow.Cells["Coluna_Venda_ID"].Value.ToString());

            if (IDconfere == IDedita)
            {
                string[] linhaContato = { IDedita.ToString(), CNome, txtEditarIngrediente.Text, CQTD, VL.ToString()};
                GRID.Rows[GRID.CurrentRow.Index].SetValues(linhaContato);
            }
            GroupEdita.Visible = false;
        }
        
        //Botao Limpar TextBox Filtro
        private void Botao_Apagar_Click(object sender, EventArgs e)
        {
            txtFiltroProduto.Text = "Produto"; txtFiltroProduto.ForeColor = Color.Silver;
        }

        //Botao Limpar TextBox Ingredientes
        private void Botao_Limpar2_Click(object sender, EventArgs e)
        {
            txtEditarIngrediente.Text = string.Empty;
        }

        //Botao Finalizar Pedido
        private void Botao_Finalizar_Click(object sender, EventArgs e)
        {
            if (txtContato.Text == string.Empty) { MessageBox.Show("Selecione um Cliente Primeiro", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            else if (GRID.RowCount == 0) { MessageBox.Show("Informe Produtos para Prosseguir", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; } //GRID_Produtos.Rows.Clear();
            else if (Key == 1 && MessageBox.Show("Confirmar Pedido ?", "Mensagem", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Buscar ID cliente
                List<ClienteDTO> BuscarIDCliente = ClassBLL.BuscarCliente_1Filtro_Contato(txtContato.Text);
                foreach (var FORpass in BuscarIDCliente)
                {
                    IDcliente = FORpass.IDCliente1;
                }

                //Buscar Data
                string Date = DateTime.Now.ToString("yyyy-MM-dd");

                //Buscar ID Produto
                foreach (var FORpass in ListaItem)
                {
                    int IDproduto = FORpass.IDProduto1;
                    Resposta = ClassBLL.InserirPedido(Date, IDcliente, IDproduto);
                }

                if (Resposta == 1)
                {
                    MessageBox.Show("Pedido Finalizado com Sucesso !", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHome Voltar = new FormHome();
                    this.Hide();
                    Voltar.Show();
                }
                if (Resposta == -1) { MessageBox.Show("Preencha Nome do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (Resposta == -2) { MessageBox.Show("Preencha Contato do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (Resposta == -3) { MessageBox.Show("Preencha Endereço do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (Resposta == -4) { MessageBox.Show("Preencha Cep do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (Resposta == -5) { MessageBox.Show("Preencha Numero da Residencia do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                else if (Resposta != 1 && Resposta != -1 && Resposta != -2 && Resposta != -3 && Resposta != -4)
                {
                    MessageBox.Show("Houve erro ao Cadastrar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return; 
            }
            
        }
//---------------------------------------------------------------------------------------------------------------------

        //Edição dos TEXTBOX
        private void txtFiltroProduto_TextChanged(object sender, EventArgs e)
        {
            txtFiltroProduto.ForeColor = Color.Black;
        }

        private void txtFiltroProduto_Click(object sender, EventArgs e)
        {
            txtFiltroProduto.Text = "";
        }

        private void txtFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFiltroProduto.Text == "") { txtFiltroProduto.Text = "Produto"; }
        }

        private void Editar_Ingredientes_Click(object sender, EventArgs e)
        {
            if (Key == 0) { MessageBox.Show("Insira um produto primeiro", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            GroupEdita.Visible = true;

            string IngreSelecionado = (GRID.CurrentRow.Cells["Coluna_Ingredientes"].Value.ToString());

            IDedita = int.Parse(GRID.CurrentRow.Cells["Coluna_Venda_ID"].Value.ToString());
            CNome = (GRID.CurrentRow.Cells["Coluna_Venda_Nome"].Value.ToString()); 
            CQTD = (GRID.CurrentRow.Cells["Coluna_Venda_Quantidade"].Value.ToString());
            VL = double.Parse(GRID.CurrentRow.Cells["Coluna_Venda_Valor"].Value.ToString());

            txtEditarIngrediente.Text = IngreSelecionado;

        }

        
    }
}
