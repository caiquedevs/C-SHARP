using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pizzaria.DTO;
using MySql.Data.MySqlClient;

namespace Pizzaria.DAL
{
    public class ClassDAL
    {
        //** PARTE DE INSERÇÃO - GERAL ------------------------------

        //Inserir Novo Cliente no BANCO
        public static int InserirNovoCadastroDAL(ClienteDTO objNovoCliente)
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root; PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(Endereco);
                Comando = new MySqlCommand(" INSERT INTO tb_cliente (ID, Nome, Contato, Endereco, Cep, Numero, Complemento) " +
                                           " VALUES (null, ?, ?, ?, ?, ?, ?);", Conectar);
                Conectar.Open();

                //Parametros do Comando
                Comando.Parameters.Add("@Nome", MySqlDbType.VarChar, 50).Value = objNovoCliente.NomeCLiente1;
                Comando.Parameters.Add("@Contato", MySqlDbType.VarChar, 50).Value = objNovoCliente.ContatoCliente1;
                Comando.Parameters.Add("@Endereco", MySqlDbType.VarChar, 50).Value = objNovoCliente.EnderecoCliente1;
                Comando.Parameters.Add("@Cep", MySqlDbType.VarChar, 50).Value = objNovoCliente.CepCliente1;
                Comando.Parameters.Add("@Numero", MySqlDbType.VarChar, 50).Value = objNovoCliente.NumeroCliente1;
                Comando.Parameters.Add("@Complemento", MySqlDbType.VarChar, 50).Value = objNovoCliente.ComplementoCliente1;

                //Executar Comando
                return Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        //Inserir Novo Produto no BANCO
        public static int InserirNovoProdutoDAL(ProdutoDTO objNovoProduto)
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(Endereco);
                Comando = new MySqlCommand("INSERT INTO tb_produto (ID, nome, Ingredientes, Valor, Categoria)" +
                                           "VALUES (null, ?, ?, ?, ?);", Conectar);
                Conectar.Open();

                //Parametros do Comando
                Comando.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = objNovoProduto.NomeProduto1;
                Comando.Parameters.Add("@Ingredientes", MySqlDbType.VarChar, 50).Value = objNovoProduto.Ingredientes1;
                Comando.Parameters.Add("@Valor", MySqlDbType.Double).Value = objNovoProduto.Valor1;
                Comando.Parameters.Add("@Categoria", MySqlDbType.VarChar, 50).Value = objNovoProduto.Categoria1;

                //Executar Comando
                return Comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }


        }

        //Inserir Novo PEDIDO no BANCO
        public static int InserirPedido(string Date, int IDcliente, int IDproduto)
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(Endereco);
                Comando = new MySqlCommand("INSERT INTO tb_pedido (id, data, idcliente, idproduto)" +
                                           "VALUES (null, ?, ?, ?);", Conectar);
                Conectar.Open();

                //Parametros do Comando
                Comando.Parameters.Add("@data", MySqlDbType.Date).Value = Date;
                Comando.Parameters.Add("@idcliente", MySqlDbType.Int32).Value = IDcliente;
                Comando.Parameters.Add("@idproduto", MySqlDbType.Double).Value = IDproduto;
                

                //Executar Comando
                return Comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }



        //** PARTE DE BUSCA - PRODUTOS ----------------------------

        //Buscar Todos Produtos 
        public static List<ProdutoDTO> BuscarProdutos()
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(Endereco);
                Comando = new MySqlCommand("Select * FROM tb_produto;", Conectar);

                Conectar.Open();

                MySqlDataReader DataR = Comando.ExecuteReader();

                List<ProdutoDTO> LISTA = new List<ProdutoDTO>();

                if (DataR.HasRows)
                {
                    while (DataR.Read())
                    {
                        ProdutoDTO objLeitura = new ProdutoDTO();

                        objLeitura.IDProduto1 = Convert.ToInt32(DataR["ID"]);
                        objLeitura.NomeProduto1 = Convert.ToString(DataR["nome"]);
                        objLeitura.Ingredientes1 = Convert.ToString(DataR["Ingredientes"]);
                        objLeitura.Valor1 = Convert.ToDouble(DataR["Valor"]);
                        objLeitura.Categoria1 = Convert.ToString(DataR["Categoria"]);

                        LISTA.Add(objLeitura);
                    }
                }

                return LISTA;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //Buscar Todos Produtos ID 
        public static ProdutoDTO BuscarProduto_ID(int IDLinha)
        {
            string endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(endereco);
                Comando = new MySqlCommand("SELECT ID, nome, Ingredientes, Valor, Categoria FROM tb_produto WHERE ID = @IDbd", Conectar);
                Comando.Parameters.Add("IDbd", MySqlDbType.Int32).Value = IDLinha;

                Conectar.Open();
                MySqlDataReader DataR = Comando.ExecuteReader();

                ProdutoDTO objProduto = new ProdutoDTO();

                if (DataR.HasRows)
                {
                    while (DataR.Read())
                    {
                        objProduto.IDProduto1 = Convert.ToInt32(DataR["ID"]);
                        objProduto.NomeProduto1 = Convert.ToString(DataR["nome"]);
                        objProduto.Ingredientes1 = Convert.ToString(DataR["Ingredientes"]);
                        objProduto.Valor1 = Convert.ToDouble(DataR["Valor"]);
                        objProduto.Categoria1 = Convert.ToString(DataR["Categoria"]);



                    }
                }

                return objProduto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //Buscar Todos Produtos FILTRO Nome !FORM EDIT
        public static List<ProdutoDTO> BuscarProduto_1Filtro(string[] Filtro)
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            Conectar = new MySqlConnection(Endereco);
            Comando = new MySqlCommand("SELECT ID, nome, Ingredientes, Valor, Categoria FROM tb_produto", Conectar);

            Conectar.Open();

            //Se apenas o Filtro Categoria for preenchido
            if (Filtro[0] != string.Empty && Filtro[0] != "Produto")
            {
                Comando.CommandText += " WHERE nome LIKE @CAT;";
                Comando.Parameters.AddWithValue("@CAT", Filtro[0] + "%");
            }

            MySqlDataReader DataR = Comando.ExecuteReader();

            List<ProdutoDTO> LISTA = new List<ProdutoDTO>();

            if (DataR.HasRows)
            {
                while (DataR.Read())
                {
                    ProdutoDTO objProduto = new ProdutoDTO();

                    objProduto.IDProduto1 = Convert.ToInt32(DataR["ID"]);
                    objProduto.NomeProduto1 = Convert.ToString(DataR["nome"]);
                    objProduto.Ingredientes1 = Convert.ToString(DataR["Ingredientes"]);
                    objProduto.Valor1 = Convert.ToDouble(DataR["Valor"]);
                    objProduto.Categoria1 = Convert.ToString(DataR["Categoria"]);

                    LISTA.Add(objProduto);
                }
            }

            return LISTA;
        }

        //Buscar Todos Produtos FILTRO Categoria e Nome !FORM PEDIDO
        public static List<ProdutoDTO> BuscarProduto_2Filtros(string[] Filtro)
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            Conectar = new MySqlConnection(Endereco);
            Comando = new MySqlCommand("SELECT ID, nome, Ingredientes, Valor, Categoria FROM tb_produto", Conectar);

            Conectar.Open();

            //Se os dois Filtros estiverem Preenchidos
            if (Filtro[0] != String.Empty && Filtro[0] != "Categoria"
             && Filtro[1] != String.Empty && Filtro[1] != "Produto")
            {
                Comando.CommandText += " WHERE Categoria LIKE @CAT AND nome LIKE @NP";
                Comando.Parameters.AddWithValue("@CAT", "%" + Filtro[0] + "%");
                Comando.Parameters.AddWithValue("@NP", "%" + Filtro[1] + "%");
            }

            //Se apenas o Filtro Categoria for preenchido
            else if (Filtro[0] != String.Empty && Filtro[0] != "Categoria" && Filtro[1] == String.Empty || Filtro[1] == "Produto")
            {
                Comando.CommandText += " WHERE Categoria LIKE @CAT";
                Comando.Parameters.AddWithValue("@CAT", "%" + Filtro[0] + "%");
            }

            //Se Apens o FIltro Produto for Preenchido
            else if (Filtro[1] != String.Empty && Filtro[1] != "Produto" && Filtro[0] == String.Empty || Filtro[0] == "Categoria")
            {
                //Comando = null;
                //Comando = new MySqlCommand("SELECT id, nome, sobrenome, contato, cep FROM tb_contato WHERE contato LIKE @Contato", Conexao);
                Comando.CommandText += " WHERE nome LIKE @NP";
                Comando.Parameters.AddWithValue("@NP", "%" + Filtro[1] + "%");

            }



            MySqlDataReader DataR = Comando.ExecuteReader();

            List<ProdutoDTO> LISTA = new List<ProdutoDTO>();

            if (DataR.HasRows)
            {
                while (DataR.Read())
                {
                    ProdutoDTO objContato = new ProdutoDTO();

                    objContato.IDProduto1 = Convert.ToInt32(DataR["ID"]);
                    objContato.NomeProduto1 = Convert.ToString(DataR["nome"]);
                    objContato.Ingredientes1 = Convert.ToString(DataR["Ingredientes"]);
                    objContato.Valor1 = Convert.ToDouble(DataR["Valor"]);
                    objContato.Categoria1 = Convert.ToString(DataR["Categoria"]);

                    LISTA.Add(objContato);
                }
            }

            return LISTA;
        }

        //Buscar Todas Pizzas
        public static List<ProdutoDTO> BuscarPizzas()
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(Endereco);
                Comando = new MySqlCommand("Select * FROM tb_produto Where Categoria = 'Pizza';", Conectar);

                Conectar.Open();

                MySqlDataReader DataR = Comando.ExecuteReader();

                List<ProdutoDTO> LISTA = new List<ProdutoDTO>();

                if (DataR.HasRows)
                {
                    while (DataR.Read())
                    {
                        ProdutoDTO objLeitura = new ProdutoDTO();

                        objLeitura.IDProduto1 = Convert.ToInt32(DataR["ID"]);
                        objLeitura.NomeProduto1 = Convert.ToString(DataR["nome"]);
                        objLeitura.Ingredientes1 = Convert.ToString(DataR["Ingredientes"]);
                        objLeitura.Valor1 = Convert.ToDouble(DataR["Valor"]);
                        objLeitura.Categoria1 = Convert.ToString(DataR["Categoria"]);

                        LISTA.Add(objLeitura);
                    }
                }

                return LISTA;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //Buscar Todas Pizzas FILTRO Categoria = Pizza !FORM CRIAR
        public static List<ProdutoDTO> Buscar_Pizza_1Filtro_Cat(string[] Filtro)
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            Conectar = new MySqlConnection(Endereco);
            Comando = new MySqlCommand("SELECT ID, nome, Ingredientes, Valor, Categoria FROM tb_produto", Conectar);

            Conectar.Open();

            //Somente se o Filtro for preenchido
            if (Filtro[0] != string.Empty && Filtro[0] != "Produto")
            {
                Comando.CommandText += " WHERE nome LIKE @CAT AND Categoria = 'Pizza'";
                Comando.Parameters.AddWithValue("@CAT", "%" + Filtro[0] + "%");
            }
            if (Filtro[0] == string.Empty || Filtro[0] == "Produto")
            {
                Comando.CommandText += " WHERE Categoria = 'Pizza';";
            }




            MySqlDataReader DataR = Comando.ExecuteReader();

            List<ProdutoDTO> LISTA = new List<ProdutoDTO>();

            if (DataR.HasRows)
            {
                while (DataR.Read())
                {
                    ProdutoDTO objContato = new ProdutoDTO();

                    objContato.IDProduto1 = Convert.ToInt32(DataR["ID"]);
                    objContato.NomeProduto1 = Convert.ToString(DataR["nome"]);
                    objContato.Ingredientes1 = Convert.ToString(DataR["Ingredientes"]);
                    objContato.Valor1 = Convert.ToDouble(DataR["Valor"]);
                    objContato.Categoria1 = Convert.ToString(DataR["Categoria"]);

                    LISTA.Add(objContato);
                }
            }

            return LISTA;
        }

        //Buscar Todas Pizzas FILTRO Nome !FORM CRIAR
        public static ProdutoDTO Buscar_Pizza_1Filtro_Nome(string Pizza)
        {
            string endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar = null;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(endereco);
                Comando = new MySqlCommand("SELECT ID, Ingredientes, Valor FROM tb_produto WHERE nome= @Pizzas", Conectar);
                Comando.Parameters.Add("Pizzas", MySqlDbType.VarChar).Value = Pizza;
                

                Conectar.Open();
                MySqlDataReader DataR = Comando.ExecuteReader();

                ProdutoDTO objProduto = new ProdutoDTO();

                if (DataR.HasRows)
                {
                    while (DataR.Read())
                    {
                        objProduto.IDProduto1 = Convert.ToInt32(DataR["ID"]);
                        objProduto.Ingredientes1 = Convert.ToString(DataR["Ingredientes"]);
                        objProduto.Valor1 = Convert.ToDouble(DataR["Valor"]);
                    }
                }

                return objProduto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        
        }

        //Buscar Todos Pedidos
        public static List<ClassPedido> BuscarPedidos()
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(Endereco);
                Comando = new MySqlCommand("select tb_pedido.idcliente, tb_cliente.nome, tb_cliente.contato, tb_produto.Categoria , tb_produto.nome, tb_produto.valor  from tb_cliente tb_cliente Join tb_pedido tb_pedido on tb_cliente.ID = tb_pedido.idcliente Join tb_produto on tb_produto.id = tb_pedido.idproduto; ", Conectar);

                Conectar.Open();

                MySqlDataReader DataR = Comando.ExecuteReader();

                List<ClassPedido> LISTA = new List<ClassPedido>();

                if (DataR.HasRows)
                {
                    while (DataR.Read())
                    {
                        ClassPedido objPedido = new ClassPedido();

                        objPedido.IDCliente1 = Convert.ToInt32(DataR["idcliente"]);
                        objPedido.NomeCliente1 = Convert.ToString(DataR["nome"]);
                        objPedido.ContatoCliente1 = Convert.ToString(DataR["contato"]);
                        objPedido.CategoriaProduto1 = Convert.ToString(DataR["Categoria"]);
                        objPedido.NomeProduto1 = Convert.ToString(DataR["nome"]);
                        objPedido.ValorProduto1 = Convert.ToDouble(DataR["valor"]);
                        
                        LISTA.Add(objPedido);
                    }
                }

                return LISTA;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //** PARTE DE BUSCA - CLIENTES ----------------------------

        //Buscar Todos Clientes
        public static List<ClienteDTO> BuscarClientes()
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(Endereco);
                Comando = new MySqlCommand("select * FROM tb_cliente;", Conectar);

                Conectar.Open();

                MySqlDataReader DataR = Comando.ExecuteReader();

                List<ClienteDTO> LISTA = new List<ClienteDTO>();

                if (DataR.HasRows)
                {
                    while (DataR.Read())
                    {
                        ClienteDTO objLeitura = new ClienteDTO
                        {
                            IDCliente1 = Convert.ToInt32(DataR["ID"]),
                            NomeCLiente1 = Convert.ToString(DataR["Nome"]),
                            ContatoCliente1 = Convert.ToString(DataR["Contato"]),
                            EnderecoCliente1 = Convert.ToString(DataR["Endereco"]),
                            CepCliente1 = Convert.ToString(DataR["Cep"]),
                            NumeroCliente1 = Convert.ToString(DataR["Numero"]),
                            ComplementoCliente1 = Convert.ToString(DataR["Complemento"])

                        };

                        LISTA.Add(objLeitura);
                    }
                }

                return LISTA;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //Buscar Cliente pelo ID
        public static ClienteDTO BuscarCliente_ID(int IDLinha)
        {
            string endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar = null;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(endereco);
                Comando = new MySqlCommand("SELECT Nome, Contato, Endereco, Cep, Numero, Complemento FROM tb_cliente WHERE ID = @IDbd", Conectar);
                Comando.Parameters.Add("IDbd", MySqlDbType.Int32).Value = IDLinha;

                Conectar.Open();
                MySqlDataReader DataR = Comando.ExecuteReader();

                ClienteDTO objCliente = new ClienteDTO();

                if (DataR.HasRows)
                {
                    while (DataR.Read())
                    {
                        //objCliente.IDCliente1 = Convert.ToInt32(DataR["ID"]);
                        objCliente.NomeCLiente1 = Convert.ToString(DataR["Nome"]);
                        objCliente.ContatoCliente1 = Convert.ToString(DataR["Contato"]);
                        objCliente.EnderecoCliente1 = Convert.ToString(DataR["Endereco"]);
                        objCliente.CepCliente1 = Convert.ToString(DataR["Cep"]);
                        objCliente.NumeroCliente1 = Convert.ToString(DataR["Numero"]);
                        objCliente.ComplementoCliente1 = Convert.ToString(DataR["Complemento"]);


                    }
                }

                return objCliente;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        
        //Buscar Todos Clientes FILTRO Contato
        public static List<ClienteDTO> BuscarCliente_1Filtro_Contato(string Contato)
        {
            string Endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            Conectar = new MySqlConnection(Endereco);
            Comando = new MySqlCommand("SELECT ID, Nome, Contato, Endereco, Cep, Numero, Complemento FROM tb_cliente", Conectar);

            Conectar.Open();

            //Se os dois Filtros estiverem Preenchidos
            if (Contato != string.Empty && Contato != "Contato")
            {
                Comando.CommandText += " WHERE Contato LIKE @contato";
                Comando.Parameters.AddWithValue("@contato", "%" + Contato + "%");
            }

            MySqlDataReader DataR = Comando.ExecuteReader();

            List<ClienteDTO> LISTA = new List<ClienteDTO>();

            if (DataR.HasRows)
            {
                while (DataR.Read())
                {
                    ClienteDTO objCliente = new ClienteDTO();

                    objCliente.IDCliente1 = Convert.ToInt32(DataR["ID"]);
                    objCliente.NomeCLiente1 = Convert.ToString(DataR["Nome"]);
                    objCliente.ContatoCliente1 = Convert.ToString(DataR["Contato"]);
                    objCliente.EnderecoCliente1 = Convert.ToString(DataR["Endereco"]);
                    objCliente.CepCliente1 = Convert.ToString(DataR["Cep"]);
                    objCliente.NumeroCliente1 = Convert.ToString(DataR["Numero"]);
                    objCliente.ComplementoCliente1 = Convert.ToString(DataR["Complemento"]);

                    LISTA.Add(objCliente);
                }
            }

            return LISTA;

        }



        //** OUTROS - Exclusão e Edit ----------------------------

        //Atualizar Produto ao Editar 
        public static int AtualizarProduto(ProdutoDTO objProduto)
        {

            string endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(endereco);
                Comando = new MySqlCommand("UPDATE tb_produto SET nome= @Nome, Ingredientes = @Ingre, Valor = @VL, Categoria = @CAT WHERE id = @IDContato", Conectar);

                Comando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = objProduto.NomeProduto1;
                Comando.Parameters.Add("@Ingre", MySqlDbType.VarChar).Value = objProduto.Ingredientes1;
                Comando.Parameters.Add("@VL", MySqlDbType.Double).Value = objProduto.Valor1;
                Comando.Parameters.Add("@CAT", MySqlDbType.VarChar).Value = objProduto.Categoria1;
                Comando.Parameters.Add("@IDContato", MySqlDbType.Int32).Value = objProduto.IDProduto1;

                Conectar.Open();
                return Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //Atualizar Cliente ao Editar 
        public static int AtualizarCliente(ClienteDTO objCliente, int IDLinha)
        {

            string endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(endereco);
                Comando = new MySqlCommand("UPDATE tb_cliente SET Nome = @NOM, Contato = @CON, Endereco = @END, Cep = @CP, Numero = @NUM, Complemento = @COM WHERE ID = @IDs;", Conectar);

                
                Comando.Parameters.Add("@NOM", MySqlDbType.VarChar).Value = objCliente.NomeCLiente1;
                Comando.Parameters.Add("@CON", MySqlDbType.VarChar).Value = objCliente.ContatoCliente1;
                Comando.Parameters.Add("@END", MySqlDbType.VarChar).Value = objCliente.EnderecoCliente1;
                Comando.Parameters.Add("@CP", MySqlDbType.VarChar).Value = objCliente.CepCliente1;
                Comando.Parameters.Add("@NUM", MySqlDbType.VarChar).Value = objCliente.NumeroCliente1;
                Comando.Parameters.Add("@COM", MySqlDbType.VarChar).Value = objCliente.ComplementoCliente1;
                Comando.Parameters.Add("@IDs", MySqlDbType.Int32).Value = IDLinha;

                Conectar.Open();
                return Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //Excluir Item do Pedido
        public static int ExcluirProduto_GRID_PEDIDO(int IDLinha)
        {
            string endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(endereco);
                Comando = new MySqlCommand("DELETE tb_produto FROM tb_produto WHERE id = @IDCONTATO", Conectar);
                Comando.Parameters.Add("@IDContato", MySqlDbType.Int32).Value = IDLinha;

                Conectar.Open();
                return Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        
        //Excluir Item do Pedido
        public static int ExcluirCliente_GRID_CLIENTE(int IDLinha)
        {
            string endereco = "SERVER=localhost; DATABASE=pizzaria; UID=root;  PWD=cldeveloper;";
            MySqlConnection Conectar = null;
            MySqlCommand Comando;

            try
            {
                Conectar = new MySqlConnection(endereco);
                Comando = new MySqlCommand("DELETE tb_cliente FROM tb_cliente WHERE id = @IDCONTATO", Conectar);
                Comando.Parameters.Add("@IDContato", MySqlDbType.Int32).Value = IDLinha;

                Conectar.Open();
                return Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
    }
}
