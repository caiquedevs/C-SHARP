using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.DAL;
using Pizzaria.DTO;

namespace Pizzaria.BLL
{
    public class ClassBLL
    {
        //** PARTE DE INSERÇÃO - GERAL -----------------------------

        //Inserir Novo Cliente na DAL
        public static int InserirNovoCadastroBLL(ClienteDTO objNovoCliente)
        {  
            if (objNovoCliente.NomeCLiente1         == "Obrigatorio" || objNovoCliente.NomeCLiente1      == "") { return -1; }
            if (objNovoCliente.ContatoCliente1      == "Obrigatorio" || objNovoCliente.ContatoCliente1   == "") { return -2; }
            if (objNovoCliente.EnderecoCliente1     == "Obrigatorio" || objNovoCliente.EnderecoCliente1  == "") { return -3; }
            if (objNovoCliente.CepCliente1          == "Obrigatorio" || objNovoCliente.CepCliente1       == "") { return -4; }
            if (objNovoCliente.NumeroCliente1       == "Obrigatorio" || objNovoCliente.NumeroCliente1    == "") { return -5; }
            if (objNovoCliente.ComplementoCliente1  == "Opcional"    || objNovoCliente.ComplementoCliente1      == "") { objNovoCliente.ComplementoCliente1 = "Não informado"; }

            return ClassDAL.InserirNovoCadastroDAL(objNovoCliente);
        }

        //Inserir Novo Produto na DAL
        public static int InserirNovoProdutoBLL(ProdutoDTO ObjNovoProduto, string Valor)
        {
            if (ObjNovoProduto.NomeProduto1 == "Obrigatorio" || ObjNovoProduto.NomeProduto1 == "") { return -1; }
            else if (ObjNovoProduto.Ingredientes1 == "Obrigatorio" || ObjNovoProduto.Ingredientes1 == "Ex: Mussarela e Azeitona" || ObjNovoProduto.Ingredientes1 == "Ex: Refrigerante ou Suco") { return -2; }
            else if (ObjNovoProduto.Categoria1 == "Categoria") { return -4; }
            if (decimal.TryParse(Valor, out decimal numero))
            {
                ObjNovoProduto.Valor1 = double.Parse(Valor);
            }
            else return -3;


            return ClassDAL.InserirNovoProdutoDAL(ObjNovoProduto);
        }

        //Inserir PEDIDO na DAL
        public static int InserirPedido(string Date, int IDcliente, int IDproduto)
        {
            /*
            if (objNovoCliente.NomeCLiente1 == "Obrigatorio" || objNovoCliente.NomeCLiente1 == "") { return -1; }
            if (objNovoCliente.ContatoCliente1 == "Obrigatorio" || objNovoCliente.ContatoCliente1 == "") { return -2; }
            if (objNovoCliente.EnderecoCliente1 == "Obrigatorio" || objNovoCliente.EnderecoCliente1 == "") { return -3; }
            if (objNovoCliente.CepCliente1 == "Obrigatorio" || objNovoCliente.CepCliente1 == "") { return -4; }
            if (objNovoCliente.NumeroCliente1 == "Obrigatorio" || objNovoCliente.NumeroCliente1 == "") { return -5; }
            if (objNovoCliente.ComplementoCliente1 == "Opcional" || objNovoCliente.ComplementoCliente1 == "") { objNovoCliente.ComplementoCliente1 = "Não informado"; }
            */
            return ClassDAL.InserirPedido(Date, IDcliente, IDproduto);
        }

        
        
        //** PARTE DE BUSCA - PRODUTOS ----------------------------

        //Buscar Todos Produtos 
        public static List<ProdutoDTO> BuscarProdutos()
        {
            return ClassDAL.BuscarProdutos();
        }

        //Buscar Todos Produtos ID 
        public static ProdutoDTO BuscarProduto_ID(int IDLinha)
        {
            return ClassDAL.BuscarProduto_ID(IDLinha);
        }
        
        //Buscar Todos Produtos FILTRO Nome !FORM EDIT
        public static List<ProdutoDTO> BuscarProduto_1Filtro(string[] Filtro)
        {
            return ClassDAL.BuscarProduto_1Filtro(Filtro);
        }

        //Buscar Todos Produtos FILTRO Categoria e Nome !FORM PEDIDO
        public static List<ProdutoDTO> BuscarProduto_2Filtros(string[] Filtro)
        {
            return ClassDAL.BuscarProduto_2Filtros(Filtro);
        }

        //Buscar Todas Pizzas
        public static List<ProdutoDTO> BuscarPizzas()
        {
            return ClassDAL.BuscarPizzas();
        }

        //Buscar Todas Pizzas FILTRO Categoria = Pizza !FORM CRIAR
        public static List<ProdutoDTO> Buscar_Pizza_1Filtro_Cat(string[] Filtro)
        {
            return ClassDAL.Buscar_Pizza_1Filtro_Cat(Filtro);
        }

        //Buscar Todas Pizzas FILTRO Nome !FORM CRIAR
        public static ProdutoDTO Buscar_Pizza_1Filtro_Nome(string Pizza)
        {
            return ClassDAL.Buscar_Pizza_1Filtro_Nome(Pizza);
        }

        //Buscar Todos Pedidos
        public static List<ClassPedido> BuscarPedidos()
        {
            return ClassDAL.BuscarPedidos();
        }




        //** PARTE DE BUSCA - CLIENTES ----------------------------

        //Buscar Todos Clientes
        public static List<ClienteDTO> BuscarClientes()
        {
            return ClassDAL.BuscarClientes();
        }
        
        //Buscar Cliente pelo ID
        public static ClienteDTO BuscarCliente_ID(int IDlinha)
        {
            return ClassDAL.BuscarCliente_ID(IDlinha);
        }

        //Buscar Todos Clientes FILTRO Contato
        public static List<ClienteDTO> BuscarCliente_1Filtro_Contato(string Contato)
        {
            return ClassDAL.BuscarCliente_1Filtro_Contato(Contato);
        }



        //** OUTROS - Exclusão e Edit ----------------------------

        //Atualizar Produto após ser Editado
        public static int AtualizarProduto(ProdutoDTO objProduto, string Valor)
        {
            if (objProduto.NomeProduto1 == "Obrigatorio" || objProduto.NomeProduto1 == "") { return -1; }
            else if (objProduto.Ingredientes1 == "Obrigatorio" || objProduto.Ingredientes1 == "Ex: Mussarela e Azeitona" || objProduto.Ingredientes1 == "Ex: Refrigerante ou Suco") { return -2; }
            else if (objProduto.Categoria1 == "Categoria") { return -4; }
            if (decimal.TryParse(Valor, out decimal numero))
            {
                objProduto.Valor1 = double.Parse(Valor);
            }
            else return -3;

            return ClassDAL.AtualizarProduto(objProduto);
        }

        //Atualizar Cliente após ser Editado
        public static int AtualizarCliente(ClienteDTO objCliente, int IDlinha)
        {
            return ClassDAL.AtualizarCliente(objCliente, IDlinha);
        }
        
        //Excluir Item Pedido
        public static int ExcluirProduto_GRID_PEDIDO(int IDLinha)
        {
            return ClassDAL.ExcluirProduto_GRID_PEDIDO(IDLinha);
        }

        //Excluir Cliente Pedido
        public static int ExcluirCliente_GRID_CLIENTE(int IDLinha)
        {
            return ClassDAL.ExcluirCliente_GRID_CLIENTE(IDLinha);
        }

    }
}
