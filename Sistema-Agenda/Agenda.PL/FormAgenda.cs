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

namespace Agenda.PL
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();

        }

        int ClickAtual = 1;

        private void Botao_Agenda_Click(object sender, EventArgs e)
        {
            if (ClickAtual == 2)
            {
                Botao_Agenda.BackgroundImage = Botao_Editar.BackgroundImage;
                Botao_Editar.BackgroundImage = Botao_Excluir.BackgroundImage;
            }
            else if (ClickAtual == 3)
            {
                Botao_Agenda.BackgroundImage = Botao_Excluir.BackgroundImage;
                Botao_Excluir.BackgroundImage = Botao_Editar.BackgroundImage;
            }
            ClickAtual = 1;
        }

        private void Botao_Editar_Click(object sender, EventArgs e)
        {   
            if (ClickAtual == 1){
                Botao_Editar.BackgroundImage = Botao_Agenda.BackgroundImage;
                Botao_Agenda.BackgroundImage = Botao_Excluir.BackgroundImage;
            }
            else if(ClickAtual == 3){
                Botao_Editar.BackgroundImage = Botao_Excluir.BackgroundImage;
                Botao_Excluir.BackgroundImage = Botao_Agenda.BackgroundImage;
            }

            ClickAtual = 2;
            
        }

        private void Botao_Excluir_Click(object sender, EventArgs e)
        {
            if (ClickAtual == 1)
            {
                Botao_Excluir.BackgroundImage = Botao_Agenda.BackgroundImage;
                Botao_Agenda.BackgroundImage = Botao_Editar.BackgroundImage;
            }
            else if (ClickAtual == 2)
            {
                Botao_Excluir.BackgroundImage = Botao_Editar.BackgroundImage;
                Botao_Editar.BackgroundImage = Botao_Agenda.BackgroundImage;
            }
            ClickAtual = 3;

        }

        private void Botao_Add_Click(object sender, EventArgs e)
        {
            Botao_Add.FlatAppearance.BorderSize = 0;
            FormAdd newAdd = new FormAdd();
            newAdd.ShowDialog();
        }



        /* Botao Enviar Novo Cadastro do Formulario
        private void Botao_Enviar_Click(object sender, EventArgs e)
        {
            int A;

            Contato objContato = new Contato();

            objContato.Nome = txtNome.Text;
            objContato.Sobrenome = txtSobrenome.Text;
            objContato.Contatos = txtContato.Text;
            objContato.Cep = txtCep.Text;

            A = ContatoBLL.InserirBLL(objContato);

            if (A == 1) { MessageBox.Show("Contato cadastrado com sucesso!"); }

            else if (A == -1) { MessageBox.Show("Preencha Nome"); return; }
            else if (A == -2) { MessageBox.Show("Preencha Sobrenome", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (A == -3) { MessageBox.Show("Preencha Contato", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (A == -4) { MessageBox.Show("Preencha Cep", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            else
                MessageBox.Show("Houve erros ao salvar um contato!");

            txtNome.Text = "Nome"; txtNome.ForeColor = Color.Silver;
            txtSobrenome.Text = "Sobrenome"; txtSobrenome.ForeColor = Color.Silver;
            txtContato.Text = "Contato"; txtContato.ForeColor = Color.Silver;
            txtCep.Text = "Cep"; txtCep.ForeColor = Color.Silver;

            HOME Back = new HOME();
            this.Hide();
            Back.ShowDialog();
        }

        // Labell Link VOLTAR
        private void Botao_Voltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HOME Voltar = new HOME();
            this.Hide();
            Voltar.ShowDialog();
        }

        //Area de edição Do Front Textbox do FORMULARIO

        //Evento Clicar
        private void txtNome_Click(object sender, EventArgs e)
        {
            if (txtSobrenome.Text == "") { txtSobrenome.Text = "Sobrenome"; txtSobrenome.ForeColor = Color.DarkGray; }
            if (txtContato.Text == "")   { txtContato.Text = "Contato"; txtContato.ForeColor = Color.DarkGray; }
            if (txtCep.Text == "")       { txtCep.Text = "Cep"; txtCep.ForeColor = Color.DarkGray; }
            if (txtNome.Text == "Nome")  { txtNome.Text = ""; }
            
        }

        //Evento Clicar
        private void txtSobrenome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")    { txtNome.Text = "Nome"; txtNome.ForeColor = Color.DarkGray; }
            if (txtContato.Text == "") { txtContato.Text = "Contato"; txtContato.ForeColor = Color.DarkGray; }
            if (txtCep.Text == "")     { txtCep.Text = "Cep"; txtCep.ForeColor = Color.DarkGray; }
            if (txtSobrenome.Text == "Sobrenome") { txtSobrenome.Text = ""; }
            
        }

        //Evento Clicar
        private void txtContato_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") { txtNome.Text = "Nome"; txtNome.ForeColor = Color.DarkGray; }
            if (txtSobrenome.Text == "") { txtSobrenome.Text = "Sobrenome"; txtSobrenome.ForeColor = Color.DarkGray; }
            if (txtCep.Text == "") { txtCep.Text = "Cep"; txtCep.ForeColor = Color.DarkGray; }
            if (txtContato.Text == "Contato")   { txtContato.Text = ""; }
            
        }

        //Evento Clicar
        private void txtCep_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") { txtNome.Text = "Nome"; txtNome.ForeColor = Color.DarkGray; }
            if (txtSobrenome.Text == "") { txtSobrenome.Text = "Sobrenome"; txtSobrenome.ForeColor = Color.DarkGray; }
            if (txtContato.Text == "") { txtContato.Text = "Contato"; txtContato.ForeColor = Color.DarkGray; }
            if (txtCep.Text == "Cep") { txtCep.Text = ""; }
            
            
        }

        //Evento Escrever
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.ForeColor = Color.Black;
        }

        //Evento Escrever
        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            txtSobrenome.ForeColor = Color.Black;
        }

        //Evento Escrever
        private void txtContato_TextChanged(object sender, EventArgs e)
        {
            txtContato.ForeColor = Color.Black;
        }

        //Evento Escrever
        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            txtCep.ForeColor = Color.Black;
        }


        */

    }
}
