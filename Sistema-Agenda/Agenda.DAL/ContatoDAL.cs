using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Agenda.DTO;

namespace Agenda.DAL
{
    public class ContatoDAL
    {
        //INSERIR O CADASTRO NOVO NO BANCO
        public static int InserirContato(Contato NovoContato)
        {
            string Conecta = "SERVER=localhost; DATABASE=agenda; UID=root; PWD=;";
            MySqlConnection Conexao = null;
            MySqlCommand Comando;

            try
            {
                //Conexao e Comando
                Conexao = new MySqlConnection(Conecta);
                Comando = new MySqlCommand("insert INTO contatos Values (null, ?, ?, ?, ?, ?);", Conexao);
                Conexao.Open();

                //Parametros do Comando
                Comando.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = NovoContato.Nome;
                Comando.Parameters.Add("@obs", MySqlDbType.VarChar, 100).Value = NovoContato.Obs;
                Comando.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = NovoContato.Email;
                Comando.Parameters.Add("@celular", MySqlDbType.VarChar, 30).Value = NovoContato.Celular;
                Comando.Parameters.Add("@telefone", MySqlDbType.VarChar, 30).Value = NovoContato.Telefone;
                
                //Retornar
                return Comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        //METODO CRIADO APENAS PARA ABRIR O FORM DE CONSULTA JÁ POPULADO
        public static List<Contato> BuscarContatoDAL()
        {
            string Conecta = "SERVER=localhost; DATABASE=unip; UID=root; PWD=;";
            MySqlConnection Conexao = null;
            MySqlCommand Comando;

            Conexao = new MySqlConnection(Conecta);
            Comando = new MySqlCommand("SELECT id, nome, sobrenome, contato, cep FROM tb_contato", Conexao);

            Conexao.Open();

            MySqlDataReader DataR = Comando.ExecuteReader();

            List<Contato> Contatos = new List<Contato>();

            if (DataR.HasRows)
            {
                while (DataR.Read())
                {
                    Contato objContato = new Contato();

                    objContato.Id = Convert.ToInt32(DataR["id"]);
                    objContato.Nome = Convert.ToString(DataR["nome"]);
                    objContato.Sobrenome = Convert.ToString(DataR["sobrenome"]);
                    objContato.Contatos = Convert.ToString(DataR["contato"]);
                    objContato.Cep = Convert.ToString(DataR["cep"]);

                    Contatos.Add(objContato);
                }
            }

            return Contatos;

        }

        //METODO PARA BUSCAR CONTATO USANDO O FILTRO
        public static List<Contato> BuscarContatoDAL(string[] filtrosPesquisa)
        {
            string Conecta = "SERVER=localhost; DATABASE=unip; UID=root; PWD=;";
            MySqlConnection Conexao = null;
            MySqlCommand Comando;

            Conexao = new MySqlConnection(Conecta);
            Comando = new MySqlCommand("SELECT id, nome, sobrenome, contato, cep FROM tb_contato", Conexao);

            Conexao.Open();

            //Se os dois Filtros estiverem Preenchidos
            if (filtrosPesquisa[0] != String.Empty && filtrosPesquisa[0] != "Nome"
             && filtrosPesquisa[1] != String.Empty && filtrosPesquisa[1] != "Contato")
            {

                Comando.CommandText += " WHERE nome LIKE @Nome AND contato LIKE @Contato";

                Comando.Parameters.AddWithValue("@Nome", "%" + filtrosPesquisa[0] + "%");
                Comando.Parameters.AddWithValue("@Contato", "%" + filtrosPesquisa[1] + "%");

            }

            //Se apenas o Filtro NOME for preenchido
            else if (filtrosPesquisa[0] != String.Empty && filtrosPesquisa[0] != "Nome" && filtrosPesquisa[1] == String.Empty || filtrosPesquisa[1] == "Contato")
            {
                Comando.CommandText += " WHERE nome LIKE @Nome";
                Comando.Parameters.AddWithValue("@Nome", "%" + filtrosPesquisa[0] + "%");
            }

            //Se Apens o FIltro Contato for Preenchido
            else if (filtrosPesquisa[1] != String.Empty && filtrosPesquisa[1] != "Contato" && filtrosPesquisa[0] == String.Empty || filtrosPesquisa[0] == "Nome")
            {
                //Comando = null;
                //Comando = new MySqlCommand("SELECT id, nome, sobrenome, contato, cep FROM tb_contato WHERE contato LIKE @Contato", Conexao);
                Comando.CommandText += " WHERE contato LIKE @Contato";
                Comando.Parameters.AddWithValue("@Contato", "%" + filtrosPesquisa[1] + "%");
               
            }
            


            MySqlDataReader DataR = Comando.ExecuteReader();

            List<Contato> Contatos = new List<Contato>();

            if (DataR.HasRows)
            {
                while (DataR.Read())
                {
                    Contato objContato = new Contato();

                    objContato.Id        = Convert.ToInt32(DataR["id"]);
                    objContato.Nome      = Convert.ToString(DataR["nome"]);
                    objContato.Sobrenome = Convert.ToString(DataR["sobrenome"]);
                    objContato.Contatos  = Convert.ToString(DataR["contato"]);
                    objContato.Cep   = Convert.ToString(DataR["cep"]);

                    Contatos.Add(objContato);
                }
            }

            return Contatos;
        }

        //METODO PARA BUSCAR CONTATO PELO ID
        public static Contato BuscarContatoDAL( int CODContato)
        {
            string Conecta = "SERVER=localhost; DATABASE=unip; UID=root; PWD=;";
            MySqlConnection Conexao = null;
            MySqlCommand Comando;

            try
            {
                Conexao = new MySqlConnection(Conecta);
                Comando = new MySqlCommand("SELECT id, nome, sobrenome, contato, cep FROM tb_contato WHERE id = @IDContato",Conexao);
                Comando.Parameters.Add("IDContato", MySqlDbType.Int32).Value = CODContato;

                Conexao.Open();
                MySqlDataReader DataR = Comando.ExecuteReader();

                Contato objContato = new Contato();

                if (DataR.HasRows)
                {
                    while (DataR.Read())
                    {
                        objContato.Id = Convert.ToInt32(DataR["id"]);
                        objContato.Nome = Convert.ToString(DataR["nome"]);
                        objContato.Sobrenome = Convert.ToString(DataR["sobrenome"]);
                        objContato.Contatos = Convert.ToString(DataR["contato"]);
                        objContato.Cep = Convert.ToString(DataR["cep"]);
                    }
                }

                return objContato;
            }
            catch(Exception erro)
            {
                throw erro;
            }    
        }

        //METODO PARA ATUALIZAR O CONTATO AO USAR (EDIÇAO)
        public static void AtualizarContatoDAL(Contato objContato)
        {

            string Conecta = "SERVER=localhost; DATABASE=unip; UID=root; PWD=;";
            MySqlConnection Conexao = null;
            MySqlCommand Comando;

            try
            {
                Conexao = new MySqlConnection(Conecta);
                Comando = new MySqlCommand("UPDATE tb_contato SET nome = @Nome, sobrenome = @Sobrenome, contato = @Contato, cep = @Cep WHERE id = @IDContato", Conexao);
                Comando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = objContato.Nome;
                Comando.Parameters.Add("@Sobrenome", MySqlDbType.VarChar).Value = objContato.Sobrenome;
                Comando.Parameters.Add("@Contato", MySqlDbType.VarChar).Value = objContato.Contatos;
                Comando.Parameters.Add("@Cep", MySqlDbType.VarChar).Value = objContato.Cep;
                Comando.Parameters.Add("@IDContato", MySqlDbType.Int32).Value = objContato.Id;

                Conexao.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //METODO PARA EXCLUSÃO DE CADASTRO
        public static void ExcluirContato(int IdContato)
        {
            string Conecta = "SERVER=localhost; DATABASE=unip; UID=root; PWD=;";
            MySqlConnection Conexao = null;
            MySqlCommand Comando;

            try
            {
                Conexao = new MySqlConnection(Conecta);
                Comando = new MySqlCommand("DELETE tb_contato FROM tb_contato WHERE id = @IDCONTATO",Conexao);
                Comando.Parameters.Add("@IDContato", MySqlDbType.Int32).Value = IdContato;

                Conexao.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
    }
}
