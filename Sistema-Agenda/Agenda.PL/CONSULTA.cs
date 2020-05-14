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
    public partial class CONSULTA : Form
    {
        public CONSULTA()
        {
            InitializeComponent();

            List<Contato> LISTA = ContatoBLL.BuscarContatoBLL();

            GRID.Rows.Clear();

            foreach (var FORContato in LISTA)
            {
                string[] linhaContato = { FORContato.Id.ToString(), FORContato.Nome, FORContato.Sobrenome, FORContato.Contatos, FORContato.Cep };
                GRID.Rows.Add(linhaContato);
            }
        }

        // ************** EDIÇÃO DO CADASTRO **************//
        private void Botao_Cadastrar_Click(object sender, EventArgs e)
        {
            FormAgenda NewCadastro = new FormAgenda();
            this.Hide();
            NewCadastro.Show();
            
        }

        
        // ************** EDIÇÃO DO FILTRO **************//
        private void Botao_Filtrar_Click(object sender, EventArgs e)
         {
            GRID.Rows.Clear();

            string[] FiltroUser = { txtFiltroNome.Text, txtFiltroContato.Text };

            List<Contato> Contatos = ContatoBLL.BuscarContatoBLL(FiltroUser);

            foreach (var objContato in Contatos)
            {
                string[] linhaContato = { objContato.Id.ToString(), objContato.Nome, objContato.Sobrenome, objContato.Contatos, objContato.Cep };
                GRID.Rows.Add(linhaContato);
            }

            //MessageBox.Show($"{FiltroUser[0]},{FiltroUser[1]}");

        }

        
        // ************** EDIÇÃO DO EXCLUIR **************//
        private void Botao_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do contato selecionado?", "Excluir Contato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               int CodigoContatoLinhaSelecionada = int.Parse(GRID.CurrentRow.Cells["ColunaID"].Value.ToString());

                ContatoBLL.ExcluirContatoBLL(CodigoContatoLinhaSelecionada);

                GRID.Rows.RemoveAt(GRID.CurrentRow.Index);
            }
        }

        // ************** EDIÇÃO DO EDITAR **************//
        private void Botao_Editar_Click(object sender, EventArgs e)
        {
            int IDLinha = int.Parse(GRID.CurrentRow.Cells["ColunaID"].Value.ToString());

            FormAdd FormEdicao = new FormAdd (/*IDLinha*/);
            var result = FormEdicao.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] linhaContato = { FormEdicao.objContato.Id.ToString(), FormEdicao.objContato.Nome, FormEdicao.objContato.Sobrenome, FormEdicao.objContato.Contatos, FormEdicao.objContato.Cep };
                GRID.Rows[GRID.CurrentRow.Index].SetValues(linhaContato);
            }
        }



        // ************** EDIÇÃO DO FRONT **************//

        //Evento ao Digitar no  FILTRO (TEXTBOX NOME)
        private void txtFiltroNome_TextChanged(object sender, EventArgs e)
        {
            txtFiltroNome.ForeColor = Color.Black;
        }

        //Evento ao Digitar no  FILTRO (TEXTBOX CONTATO)
        private void txtFiltroContato_TextChanged(object sender, EventArgs e)
        {
            txtFiltroContato.ForeColor = Color.Black;
        }

        //Evento ao Clicar no   FILTRO (TEXTBOX NOME)
        private void txtFiltroNome_Click(object sender, EventArgs e)
        {
            if (txtFiltroNome.Text == "Nome") { txtFiltroNome.Text = ""; }
            if (txtFiltroContato.Text == "" ) { txtFiltroContato.Text = "Contato"; txtFiltroContato.ForeColor = Color.DarkGray; }
        }
        
        //Evento ao Clicar no   FILTRO (TEXTBOX CONTATO)
        private void txtFiltroContato_Click(object sender, EventArgs e)
        {
            if(txtFiltroContato.Text == "Contato") { txtFiltroContato.Text = ""; }
            if (txtFiltroNome.Text == "")          { txtFiltroNome.Text = "Nome"; txtFiltroNome.ForeColor = Color.DarkGray; }   
        }

        
    }
}
