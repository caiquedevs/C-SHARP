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
    public partial class FormCadastrar : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn ( int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse );

        public FormCadastrar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

//EVENTOS DO FORM PEDIDO------------------------------------------------------------------------------------------------

        //Botao Cadastrar Novo Cliente
        private void Botao_Cadastrar_Click(object sender, EventArgs e)
        {
            int Resposta;

            if (MessageBox.Show("Confirmar Novo Cadastro ?", "Mensagem", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ClienteDTO objNovoCliente = new ClienteDTO
                {
                    NomeCLiente1 = txtNome.Text,
                    ContatoCliente1 = txtContato.Text,
                    EnderecoCliente1 = txtEndereco.Text,
                    CepCliente1 = txtCep.Text,
                    NumeroCliente1 = txtNumero.Text,
                    ComplementoCliente1 = txtComplemento.Text
                };

                Resposta = ClassBLL.InserirNovoCadastroBLL(objNovoCliente);

                if (Resposta == 1)
                {
                    FormPedido NovoPedido = new FormPedido(objNovoCliente);
                    NovoPedido.Show();
                    this.Hide();
                    DialogResult = DialogResult.OK; 
                }
                if (Resposta == -1) { MessageBox.Show("Preencha Nome do Cliente !",     "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (Resposta == -2) { MessageBox.Show("Preencha Contato do Cliente !",  "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (Resposta == -3) { MessageBox.Show("Preencha Endereço do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (Resposta == -4) { MessageBox.Show("Preencha Cep do Cliente !",      "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (Resposta == -5) { MessageBox.Show("Preencha Numero da Residencia do Cliente !", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                else if (Resposta != 1 && Resposta != -1 && Resposta != -2 && Resposta != -3 && Resposta != -4)
                {
                    MessageBox.Show("Houve erro ao Cadastrar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            
            }
            
        }

        //Link Voltar
        private void Link_Voltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

//---------------------------------------------------------------------------------------------------------------------
        
        //EDIÇÃO DOS TEXTBOX

        //CLICK
        private void txtNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Obrigatorio") { txtNome.Text = "";}
            if (txtContato.Text == "")            { txtContato.Text =     "Obrigatorio"; txtContato.ForeColor = Color.Silver; }
            if (txtEndereco.Text == "")           { txtEndereco.Text =    "Obrigatorio"; txtEndereco.ForeColor = Color.Silver; }
            if (txtCep.Text == "")                { txtCep.Text =         "Obrigatorio"; txtCep.ForeColor = Color.Silver; }
            if (txtNumero.Text == "")             { txtNumero.Text =      "Obrigatorio"; txtNumero.ForeColor = Color.Silver; }
            if (txtComplemento.Text == "")        { txtComplemento.Text = "Opcional"; txtComplemento.ForeColor = Color.Silver; }
        }

        private void txtContato_Click(object sender, EventArgs e)
        {
            if (txtContato.Text == "Obrigatorio") { txtContato.Text = "";}
            if (txtNome.Text == "")               { txtNome.Text =        "Obrigatorio"; txtNome.ForeColor = Color.Silver; }
            if (txtEndereco.Text == "")           { txtEndereco.Text =    "Obrigatorio"; txtEndereco.ForeColor = Color.Silver; }
            if (txtCep.Text == "")                { txtCep.Text =         "Obrigatorio"; txtCep.ForeColor = Color.Silver; }
            if (txtNumero.Text == "")             { txtNumero.Text =      "Obrigatorio"; txtNumero.ForeColor = Color.Silver; }
            if (txtComplemento.Text == "")        { txtComplemento.Text = "Opcional"; txtComplemento.ForeColor = Color.Silver; }
        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "Obrigatorio")  { txtEndereco.Text = ""; }
            if (txtNome.Text == "")                 { txtNome.Text =        "Obrigatorio"; txtNome.ForeColor = Color.Silver; }
            if (txtContato.Text == "")              { txtContato.Text =     "Obrigatorio"; txtContato.ForeColor = Color.Silver; }
            if (txtCep.Text == "")                  { txtCep.Text =         "Obrigatorio"; txtCep.ForeColor = Color.Silver; }
            if (txtNumero.Text == "")               { txtNumero.Text =      "Obrigatorio"; txtNumero.ForeColor = Color.Silver; }
            if (txtComplemento.Text == "")          { txtComplemento.Text = "Opcional"; txtComplemento.ForeColor = Color.Silver; }
        }

        private void txtCep_Click(object sender, EventArgs e)
        {
            if (txtCep.Text == "Obrigatorio")  { txtCep.Text = ""; }
            if (txtNome.Text == "")                 { txtNome.Text =        "Obrigatorio"; txtNome.ForeColor = Color.Silver; }
            if (txtContato.Text == "")              { txtContato.Text =     "Obrigatorio"; txtContato.ForeColor = Color.Silver; }
            if (txtEndereco.Text == "")             { txtEndereco.Text =    "Obrigatorio"; txtEndereco.ForeColor = Color.Silver; }
            if (txtNumero.Text == "")               { txtNumero.Text =      "Obrigatorio"; txtNumero.ForeColor = Color.Silver; }
            if (txtComplemento.Text == "")          { txtComplemento.Text = "Opcional"; txtComplemento.ForeColor = Color.Silver; }
        }

        private void txtNumero_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "Obrigatorio")  { txtNumero.Text = ""; }
            if (txtNome.Text == "")                 { txtNome.Text =        "Obrigatorio"; txtNome.ForeColor = Color.Silver; }
            if (txtContato.Text == "")              { txtContato.Text =     "Obrigatorio"; txtContato.ForeColor = Color.Silver; }
            if (txtEndereco.Text == "")             { txtEndereco.Text =    "Obrigatorio"; txtEndereco.ForeColor = Color.Silver; }
            if (txtCep.Text == "")                  { txtCep.Text =         "Obrigatorio"; txtCep.ForeColor = Color.Silver; }
            if (txtComplemento.Text == "")          { txtComplemento.Text = "Opcional"; txtComplemento.ForeColor = Color.Silver; }
        }

        private void txtComplemento_Click(object sender, EventArgs e)
        {
            if (txtComplemento.Text == "Opcional")  { txtComplemento.Text = ""; }
            if (txtNome.Text == "")                    { txtNome.Text =        "Obrigatorio"; txtNome.ForeColor = Color.Silver; }
            if (txtContato.Text == "")                 { txtContato.Text =     "Obrigatorio"; txtContato.ForeColor = Color.Silver; }
            if (txtEndereco.Text == "")                { txtEndereco.Text =    "Obrigatorio"; txtEndereco.ForeColor = Color.Silver; }
            if (txtCep.Text == "")                     { txtCep.Text =         "Obrigatorio"; txtCep.ForeColor = Color.Silver; }
            if (txtNumero.Text == "")                  { txtNumero.Text =      "Obrigatorio"; txtNumero.ForeColor = Color.Silver; }
        }

        private void Botao_Voltar_Click(object sender, EventArgs e)
        {
            FormHome Voltar = new FormHome();
            this.Hide();
            Voltar.Show();
        }

        //CHANGE
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.ForeColor = Color.Black;
        }

        private void txtContato_TextChanged(object sender, EventArgs e)
        {
            txtContato.ForeColor = Color.Black;
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            txtEndereco.ForeColor = Color.Black;
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            txtCep.ForeColor = Color.Black;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.ForeColor = Color.Black;
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            txtComplemento.ForeColor = Color.Black;
        }

       
    }
}
