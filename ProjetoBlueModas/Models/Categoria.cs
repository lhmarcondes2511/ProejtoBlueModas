using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Models {
    public class Categoria {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome da Categoria")]
        public string Nome { get; set; }
        public List<Produto> Produto { get; set; }

        public Categoria() {}

        public Categoria(string nome) {
            Nome = nome;
        }
    }
}
