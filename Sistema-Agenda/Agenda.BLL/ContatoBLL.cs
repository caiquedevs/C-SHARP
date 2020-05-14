using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.DTO;
using Agenda.DAL;


namespace Agenda.BLL
{
    public class ContatoBLL
    {
        //Metodo Para Cadastrar Novo Cadastro (CADASTRO)
        public static int InserirContato(Contato NovoContato)
        {
            /* Se nome esta vazio */        if (NovoContato.Nome == string.Empty || NovoContato.Nome == "Insira o nome") { return -1; }
            /* Se os contatos estam vazios*/if (NovoContato.Celular == "(00)" && NovoContato.Telefone == "(00)" || NovoContato.Celular == "" && NovoContato.Telefone == "") { return -2; }

            /*Se */
            /**/

            /* Se enviar cel pela metade */
            if(NovoContato.Telefone.Length < 10) { 
                if (NovoContato.Celular.Length >= 0 && NovoContato.Celular.Length < 11) { return -4; }
            }
            /* Se enviar tel pela metade */
            if(NovoContato.Celular.Length < 11) { 
                if (NovoContato.Telefone.Length >= 0 && NovoContato.Telefone.Length < 10) { return -5; }
            }
            /* Se tem Letras no celular */  if (NovoContato.Celular.Length == 11)
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (char.IsDigit(NovoContato.Celular[i])) { }
                    else { return -3; }
                }
            }
            /* Se tem Letrar no telefone */ if (NovoContato.Telefone.Length == 10)
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (char.IsDigit(NovoContato.Telefone[i])) { }
                    else { return -6; }
                }
            }

            return ContatoDAL.InserirContato(NovoContato);
        }

        public static List<Contato> BuscarContatoBLL()
        {
            return ContatoDAL.BuscarContatoDAL();
        }

        //Metodo Para Procurar por um Cadastro específico (FILTRO)
        public static List<Contato> BuscarContatoBLL(string[] filtrosPesquisa)
        {
            return ContatoDAL.BuscarContatoDAL(filtrosPesquisa);
        }

        //Metodo para buscar contato pelo ID
        public static Contato BuscarContatoBLL(int CODContato)
        {
            return ContatoDAL.BuscarContatoDAL(CODContato);
        }

        //Metodo para Atualizar o Cadastro, Utilizado na (EDIÇÃO)
        public static void AtualizarContatoBLL(Contato objContato)
        {
            ContatoDAL.AtualizarContatoDAL(objContato);
        }

        //Metodo para Excluir um Contato específico (EXCLUIR)
        public static void ExcluirContatoBLL(int CodigoLinha)
        {
            ContatoDAL.ExcluirContato(CodigoLinha);
        }
    }
}
