using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.DTO;
using Agenda.BLL;
using System.Text.RegularExpressions;

namespace Agenda.PL
{
    public partial class FormAdd : Form
    {
        public Contato objContato;
        
        public FormAdd()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Botao_Salvar_Click(object sender, EventArgs e)
        {
            Contato NovoContato = new Contato
            {
                Nome = txtNome.Text,
                Obs = txtObs.Text,
                Email = txtEmail.Text,
                Celular = txtDdd1.Text + txtCelular.Text,
                Telefone = txtDdd2.Text + txtTelefone.Text,
            };

            int resposta = ContatoBLL.InserirContato(NovoContato);
            if (resposta == -1) { MessageBox.Show("Preencha nome"); return; }
            if( resposta == -2) { MessageBox.Show("Preencha pelo menos um contato !"); return; }
            if (resposta == -3) { MessageBox.Show("Não podem haver letras no celular"); return; }
            if (resposta == -4) { MessageBox.Show("Preencha Celular Completamente"); return; }
            if (resposta == -5) { MessageBox.Show("Preencha Telefone Completamente"); return; }
            if (resposta == -6) { MessageBox.Show("Não podem haver letras no telefone"); return; }

        }


        //EDIÇÃO DOS TEXTBOX - DESIGN

        //TXT NOME
        private void txtNome_MouseLeave(object sender, EventArgs e)
        {
            if(txtNome.Text == "") { txtNome.Text = "Insira o nome";  txtNome.ForeColor = Color.Silver; Botao_Salvar.Focus(); }
        }
        private void txtNome_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "Insira o nome") { txtNome.Text = ""; }
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.ForeColor = Color.Black;
        }
        //TXT OBS
        private void txtObs_MouseLeave(object sender, EventArgs e)
        {
            if (txtObs.Text == "") { txtObs.Text = "informações da pessoa"; txtObs.ForeColor = Color.Silver; Botao_Salvar.Focus(); }
        }
        private void txtObs_Click(object sender, EventArgs e)
        {
            if (txtObs.Text == "informações da pessoa") { txtObs.Text = ""; }
        }
        private void txtObs_TextChanged(object sender, EventArgs e)
        {
            txtObs.ForeColor = Color.Black;
        }

        //TXT EMAIL
        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "") { txtEmail.Text = "contato@contato.com"; txtEmail.ForeColor = Color.Silver; Botao_Salvar.Focus(); }
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "contato@contato.com") { txtEmail.Text = ""; }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
        }


        // TXT CELULAR
        private void txtDdd1_Click(object sender, EventArgs e)
        {
            if(txtDdd1.Text == "(00)") { txtDdd1.Text = ""; }
        }
        private void txtDdd1_TextChanged(object sender, EventArgs e)
        {
            txtDdd1.ForeColor = Color.Black;
            txtDdd1.MaxLength = 2;
            if(txtDdd1.TextLength == 2) { txtCelular.ReadOnly = false; txtCelular.Text = string.Empty;}
            if(txtDdd1.TextLength < 2) { txtCelular.ReadOnly = true; txtCelular.Text = string.Empty; }
        }

        private void txtCelular_Click(object sender, EventArgs e)
        {
            if(txtCelular.Text == "9 0000-0000") { txtCelular.Text = String.Empty; }
        }
        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            txtCelular.ForeColor = Color.Black;
            txtCelular.MaxLength = 9;
        }

        // TXT TELEFONE
        private void txtDdd2_Click(object sender, EventArgs e)
        {
            if(txtDdd2.Text == "(00)") { txtDdd2.Text = ""; }
        }
        private void txtDdd2_TextChanged(object sender, EventArgs e)
        {
            txtDdd2.ForeColor = Color.Black;
            txtDdd2.MaxLength = 2;

            if(txtDdd2.TextLength == 2) { txtTelefone.ReadOnly = false; txtTelefone.Text = string.Empty; }
            if(txtDdd2.TextLength < 2) { txtTelefone.ReadOnly = true; txtTelefone.Text = string.Empty; }
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            if(txtTelefone.Text == "0000-0000") { txtTelefone.Text = string.Empty; }
        }
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.ForeColor = Color.Black;
            txtTelefone.MaxLength = 9;
        }

        

        

        






        /*
        //Sobrecarregando o FORM e Passando um Parametro ID da linha selecionada No Form Passado
        public FormEdita(int Idlinha)
        {
            InitializeComponent();

            //Preencher os textbox de Edição Conforme o ID escolhido
            if (Idlinha != 0)
            {
                objContato = ContatoBLL.BuscarContatoBLL(Idlinha);

                txtID.ForeColor = Color.Black;
                txtNome.ForeColor = Color.Black;
                txtSobrenome.ForeColor = Color.Black;
                txtTelefone.ForeColor = Color.Black;
                txtCelular.ForeColor = Color.Black;

                txtID.Text = objContato.Id.ToString(); 
                txtNome.Text = objContato.Nome;        
                txtSobrenome.Text = objContato.Sobrenome; 
                txtTelefone.Text = objContato.Contatos; 
                txtCelular.Text = objContato.Cep; 
            }
        }

        private void Botao_Salvar_Click(object sender, EventArgs e)
        {
            if (objContato == null)
                objContato = new Contato();

            objContato.Nome = txtNome.Text;
            objContato.Sobrenome = txtSobrenome.Text;
            objContato.Contatos = txtTelefone.Text;
            objContato.Cep = txtCelular.Text;

            if (objContato.Id == 0)
                objContato.Id = ContatoBLL.InserirBLL(objContato);
            else
                ContatoBLL.AtualizarContatoBLL(objContato);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void Botao_Voltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CONSULTA Voltar = new CONSULTA();
            this.Hide();
            Voltar.Show();
        }*/
    }
}
