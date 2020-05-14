using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.DTO
{
    public class Contato
    {
        private int iD;
        private string nome;
        private string obs;
        private string email;
        private string celular;
        private string telefone;

        public int ID { get => iD; set => iD = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Email { get => email; set => email = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        private int id;
        private string sobrenome;
        private string contato;
        private string cep;

        public int Id { get => id; set => id = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Contatos { get => contato; set => contato = value; }
        public string Cep { get => cep; set => cep = value; }
    }
}
