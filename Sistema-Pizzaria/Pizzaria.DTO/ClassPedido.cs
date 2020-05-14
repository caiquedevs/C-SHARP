using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DTO
{
    public class ClassPedido
    {
        private int IDCliente;
        private string NomeCliente;
        private string ContatoCliente;
        private string CategoriaProduto;
        private string NomeProduto;
        private double ValorProduto;

        public int IDCliente1 { get => IDCliente; set => IDCliente = value; }
        public string NomeCliente1 { get => NomeCliente; set => NomeCliente = value; }
        public string ContatoCliente1 { get => ContatoCliente; set => ContatoCliente = value; }
        public string CategoriaProduto1 { get => CategoriaProduto; set => CategoriaProduto = value; }
        public string NomeProduto1 { get => NomeProduto; set => NomeProduto = value; }
        public double ValorProduto1 { get => ValorProduto; set => ValorProduto = value; }
    }
}
