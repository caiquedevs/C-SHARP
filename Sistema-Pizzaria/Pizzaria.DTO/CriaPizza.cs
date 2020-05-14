using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DTO
{
    public class CriaPizza
    {
        private int ID;
        private int Qtd;
        private string Nome1;
        private string Nome2;
        private string IngreCria1;
        private string IngreCria2;
        private double Valor;

        public int ID1 { get => ID; set => ID = value; }
        public int Qtd1 { get => Qtd; set => Qtd = value; }
        public string Nome11 { get => Nome1; set => Nome1 = value; }
        public string Nome21 { get => Nome2; set => Nome2 = value; }
        public string IngreCria11 { get => IngreCria1; set => IngreCria1 = value; }
        public string IngreCria21 { get => IngreCria2; set => IngreCria2 = value; }
        public double Valor1 { get => Valor; set => Valor = value; }
    }
}
