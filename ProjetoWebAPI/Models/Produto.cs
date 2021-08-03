using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWebAPI.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }

        public Produto(int codigo, string descricao, int estoque, double preco)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Estoque = estoque;
            this.Preco = preco;
        }
    }
}