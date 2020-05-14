using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DTO
{
    public class ClienteDTO
    {
        private int IDCliente;
        private string NomeCLiente;
        private string ContatoCliente;
        private string CepCliente;
        private string EnderecoCliente;
        private string NumeroCliente;
        private string ComplementoCliente;

        public string ComplementoCliente1 { get => ComplementoCliente; set => ComplementoCliente = value; }
        public string NumeroCliente1      { get => NumeroCliente;   set => NumeroCliente = value; }
        public string EnderecoCliente1    { get => EnderecoCliente; set => EnderecoCliente = value; }
        public string CepCliente1         { get => CepCliente;      set => CepCliente = value; }
        public string ContatoCliente1     { get => ContatoCliente;  set => ContatoCliente = value; }
        public string NomeCLiente1        { get => NomeCLiente;     set => NomeCLiente = value; }
        public int IDCliente1             { get => IDCliente;       set => IDCliente = value; }
    }
}
