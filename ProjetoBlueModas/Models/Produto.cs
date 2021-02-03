using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Models {
    public class Produto {
        [Key]
        public int Id { get; set; }
        
        
        [Display(Name = "Imagem Nome")]
        public string Imagem { get; set; }

        [NotMapped]
        [Display(Name = "Upload File")]
        public IFormFile Img { get; set; }

        [Required(ErrorMessage = "O código do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Código")]
        public int Codigo { get; set; }
        
        [Required(ErrorMessage = "O nome do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A quantidade do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Quantidade Disponível")]
        public int QuantidadeMaxima { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Preço Unitário")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria", AllowEmptyStrings = false)]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public Produto() { }

        public Produto(int id, string imagem, int codigo, string nome, int quantidadeMaxima, decimal preco, int categoriaId, Categoria categoria) {
            Id = id;
            Imagem = imagem;
            Codigo = codigo;
            Nome = nome;
            QuantidadeMaxima = quantidadeMaxima;
            Preco = preco;
            CategoriaId = categoriaId;
            Categoria = categoria;
        }
    }
}
