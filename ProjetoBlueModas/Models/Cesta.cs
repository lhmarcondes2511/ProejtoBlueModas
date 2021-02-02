using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Models {
    public class Cesta {
        [Key]
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
