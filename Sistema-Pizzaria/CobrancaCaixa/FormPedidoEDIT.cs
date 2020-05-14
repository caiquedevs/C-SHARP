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
    public partial class FormPedidoEDIT : Form
    {
        public FormPedidoEDIT()
        {
            InitializeComponent();

            GRID_Pedidos.DataSource = null;

            List<ClassPedido> LISTA = ClassBLL.BuscarPedidos();

            GRID_Pedidos.Rows.Clear();

            foreach (var FORpass in LISTA)
            {
                string[] linhaContato = { FORpass.IDCliente1.ToString(), FORpass.NomeCliente1, FORpass.ContatoCliente1, FORpass.CategoriaProduto1, FORpass.NomeProduto1, FORpass.ValorProduto1.ToString() };
                GRID_Pedidos.Rows.Add(linhaContato);
            }
        }

        private void GRID_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
