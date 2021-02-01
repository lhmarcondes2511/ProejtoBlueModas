using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ProjetoBlueModas.Models {
    public class ProdutoViewModel {
        [Required(ErrorMessage = "O nome do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Produto")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O código do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Código do Produto")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "A descrição do produto é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Descrição do Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A quantidade do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Quantidade do Produto")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria", AllowEmptyStrings = false)]
        [Display(Name = "Categoria")]
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Imagem")]
        public HttpPostedFileBase Imagem { get; set; }
    }

    public class HttpPostedFileBase {
    }
}