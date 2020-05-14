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
    public partial class FormProcurarCliente : Form
    {
        public ClienteDTO objCliente;

        //Abrir Form Preenchido
        public FormProcurarCliente()
        {
            InitializeComponent();

            GRID_Procurar.DataSource = null;

            List<ClienteDTO> LISTA = ClassBLL.BuscarClientes();

            GRID_Procurar.Rows.Clear();

            foreach (var FORpass in LISTA)
            {
                string[] linhaContato = { FORpass.IDCliente1.ToString(), FORpass.NomeCLiente1, FORpass.ContatoCliente1, FORpass.EnderecoCliente1, FORpass.CepCliente1, FORpass.NumeroCliente1, FORpass.ComplementoCliente1 };
                GRID_Procurar.Rows.Add(linhaContato);
            }

            GRID_Procurar.Visible = true;
        }

        //Botao Procurar Cliente FILTRO
        private void Botao_ProcurarCliente_Click(object sender, EventArgs e)
        {
            GRID_Procurar.Rows.Clear();

            List<ClienteDTO> Contatos = ClassBLL.BuscarCliente_1Filtro_Contato(txtContato.Text);

            foreach (var FORpass in Contatos)
            {
                string[] linhaContato = { FORpass.IDCliente1.ToString(), FORpass.NomeCLiente1, FORpass.ContatoCliente1, FORpass.EnderecoCliente1, FORpass.CepCliente1, FORpass.NumeroCliente1, FORpass.ComplementoCliente1 };
                GRID_Procurar.Rows.Add(linhaContato);
            }

            txtContato.Text = string.Empty;
        }

        //Botao Inserir Dados no Pedido
        private void Botao_Inserir_Click(object sender, EventArgs e)
        {
            int IDLinha = int.Parse(GRID_Procurar.CurrentRow.Cells["Coluna_ID_Procurar"].Value.ToString());

            if (IDLinha != 0)
            {
                objCliente = ClassBLL.BuscarCliente_ID(IDLinha);

                DialogResult = DialogResult.OK;

                Close();
            }

        }
    }
}
