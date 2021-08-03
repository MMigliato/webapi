using ProjetoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProjetoWebAPI.Controllers
{

    [RoutePrefix("api/produtos")]
    public class ProdutosController : ApiController
    {
        private static List<Produto> produtos = new List<Produto>();

        //Método GET
        [AcceptVerbs("GET")]
        [Route("ConsultarProduto")]
        public List<Produto> ConsultarProduto()
        {
            return produtos;
        }

        //Método GET por código
        [AcceptVerbs("GET")]
        [Route("ConsultarProdutoPorCodigo/{codigo}")]
        public Produto ConsultarProdutoPorCodigo(int codigo)
        {
            Produto prod = produtos.Where(n => n.Codigo == codigo).Select(n => n).FirstOrDefault();

            return prod;
        }

        //Método post
        [AcceptVerbs("POST")]
        [Route("IncluirProduto")]
        public void IncluirProduto(int codigo, string descricao, int estoque, double preco)
        {
            produtos.Add(new Produto(codigo, descricao, estoque, preco));
        }

        //Método Put
        [AcceptVerbs("PUT")]
        [Route("AlterarProduto")]
        public string AlterarProduto(Produto prod)
        {
            produtos.Where(p => p.Codigo == prod.Codigo).Select(s =>
             {
                 s.Codigo = prod.Codigo;
                 s.Descricao = prod.Descricao;
                 s.Estoque = prod.Estoque;
                 s.Preco = prod.Preco;

                 return s;
             }).ToList();

            return "Produto alterado com sucesso";
        }
    }
}
