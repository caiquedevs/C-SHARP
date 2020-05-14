using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DTO
{
    public class ProdutoDTO
    {
        private int IDProduto;
        private string NomeProduto;
        private string Ingredientes;
        private double Valor;
        private int qtd;
        private string Categoria;

        public int IDProduto1 { get => IDProduto; set => IDProduto = value; }
        public string NomeProduto1 { get => NomeProduto; set => NomeProduto = value; }
        public string Ingredientes1 { get => Ingredientes; set => Ingredientes = value; }
        public double Valor1 { get => Valor; set => Valor = value; }
        public string Categoria1 { get => Categoria; set => Categoria = value; }
        public int Qtd { get => qtd; set => qtd = value; }
    }
}
