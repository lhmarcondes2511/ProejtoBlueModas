using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Models {
    public class Historico {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Cesta Cesta { get; set; }

        public Historico() { }

        public Historico(int id, Cliente cliente, Cesta cesta) {
            Id = id;
            Cliente = cliente;
            Cesta = cesta;
        }
    }
}
