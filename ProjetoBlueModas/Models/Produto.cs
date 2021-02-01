using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Models {
    public class Produto {
        public int Id { get; set; }
        public string Imagem { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }

        public Produto() { }

        public Produto(int id, string imagem, int codigo, string nome, int quantidade, float preco) {
            Id = id;
            Imagem = imagem;
            Codigo = codigo;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }
    }
}
