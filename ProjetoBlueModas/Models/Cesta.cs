using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Models {
    public class Cesta {
        [Key]
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }

        public Cesta() { }

        public Cesta(int id, Cliente cliente, Produto produto) {
            Id = id;
            Cliente = cliente;
            Produto = produto;
        }
    }
}
