using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.DTO;
using Pizzaria.BLL;

namespace CobrancaCaixa
{
    public partial class FormClientesEDIT : Form
    {
        public ClienteDTO objCliente;

        public FormClientesEDIT()
        {
            InitializeComponent();
            GRID_Clientes.DataSource = null;

            List<ClienteDTO> LISTA = ClassBLL.BuscarClientes();

            GRID_Clientes.Rows.Clear();

            foreach (var FORpass in LISTA)
            {
                string[] linhaContato = { FORpass.IDCliente1.ToString(), FORpass.NomeCLiente1, FORpass.ContatoCliente1, FORpass.EnderecoCliente1, FORpass.CepCliente1, FORpass.NumeroCliente1, FORpass.ComplementoCliente1 };
                GRID_Clientes.Rows.Add(linhaContato);
            }



        }

        private void Botao_Filtrar_Click(object sender, EventArgs e)
        {
            GRID_Clientes.Rows.Clear();

            string FiltroUser = txtFiltro.Text;

            List<ClienteDTO> Produtos = ClassBLL.BuscarCliente_1Filtro_Contato(FiltroUser);

            foreach (var FORpass in Produtos)
            {
                string[] linhaContato = { FORpass.IDCliente1.ToString(), FORpass.NomeCLiente1, FORpass.ContatoCliente1, FORpass.EnderecoCliente1, FORpass.CepCliente1, FORpass.NumeroCliente1, FORpass.ComplementoCliente1 };
                GRID_Clientes.Rows.Add(linhaContato);
            }

            txtFiltro.Text = string.Empty;
        }

        private void Botao_Editar_Click(object sender, EventArgs e)
        {
            GroupEdit.Visible = true;
            Opacidade.Visible = true;
            int IDLinha = int.Parse(GRID_Clientes.CurrentRow.Cells["Coluna_ID_Cliente"].Value.ToString());

            if (IDLinha != 0)
            {
                objCliente = ClassBLL.BuscarCliente_ID(IDLinha);

                txtID.Text = objCliente.IDCliente1.ToString();
                txtNome.Text = objCliente.NomeCLiente1;
                txtContato.Text = objCliente.ContatoCliente1;
                txtEndereco.Text = objCliente.EnderecoCliente1;
                txtCep.Text = objCliente.CepCliente1;
                txtNumero.Text = objCliente.NumeroCliente1;
                txtComplemento.Text = objCliente.ComplementoCliente1;
            }
        }

        private void Botao_IncluirProduto_Click(object sender, EventArgs e)
        {
            int Resposta;

            int IDLinha = int.Parse(GRID_Clientes.CurrentRow.Cells["Coluna_ID_Cliente"].Value.ToString());

            if (objCliente == null)
                objCliente = new ClienteDTO();

            objCliente.IDCliente1 = int.Parse(txtID.Text);
            objCliente.NomeCLiente1 = txtNome.Text;
            objCliente.ContatoCliente1 = txtContato.Text;
            objCliente.EnderecoCliente1 = txtEndereco.Text;
            objCliente.CepCliente1 = txtCep.Text;
            objCliente.NumeroCliente1 = txtNumero.Text;
            objCliente.ComplementoCliente1 = txtComplemento.Text;

            Resposta = ClassBLL.AtualizarCliente(objCliente, IDLinha);

            
            if (Resposta == 1) { MessageBox.Show("Cliente editado com Sucesso !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            /*if (Resposta == -1) { MessageBox.Show("Preencha Nome do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -2) { MessageBox.Show("Preencha Contato do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -3) { MessageBox.Show("Preencha Endereco do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -4) { MessageBox.Show("Preencha Cep do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (Resposta == -5) { MessageBox.Show("Preencha Numero do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            else if (Resposta != 1 && Resposta != -1 && Resposta != -2 && Resposta != -3 && Resposta != -4 && Resposta != -5)
            {
                MessageBox.Show("Houve erro ao atualizar o Produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

            GroupEdit.Visible = false;
            Opacidade.Visible = false;

            string[] linhaContato = { objCliente.IDCliente1.ToString(), objCliente.NomeCLiente1, objCliente.ContatoCliente1, objCliente.EnderecoCliente1, objCliente.CepCliente1, objCliente.NumeroCliente1, objCliente.NumeroCliente1, objCliente.ComplementoCliente1 };

            GRID_Clientes.Rows[GRID_Clientes.CurrentRow.Index].SetValues(linhaContato);
        }

        private void Botao_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do contato selecionado?", "Excluir Contato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int IDLinha = int.Parse(GRID_Clientes.CurrentRow.Cells["Coluna_ID_Cliente"].Value.ToString());

                int result = ClassBLL.ExcluirCliente_GRID_CLIENTE(IDLinha);

                if (result == 1)
                {
                    MessageBox.Show("Excluido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GRID_Clientes.Rows.RemoveAt(GRID_Clientes.CurrentRow.Index);
                }
                else
                    MessageBox.Show("Houve erro ao tentar Excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void Link_Voltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GroupEdit.Visible = false;
            Opacidade.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
