using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Models {
    public class Cesta {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "A quantidade do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        public long Protocolo { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public Cesta () {

        }
    }
}
