using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Models {
    public class Historico {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public long Protocolo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int CestaId { get; set; }
        public Cesta Cesta { get; set; }

        /*Produto*/
        public string ImagemProduto { get; set; }
        public int CodigoProduto { get; set; }
        [Display( Name = "Produto")]
        public string NomeProduto { get; set; }
        [Display( Name = "Preço")]
        public decimal PrecoProduto { get; set; }

        /*Categoria*/
        public string NomeCategoria { get; set; }

        /*Cesta*/
        [Display( Name = "Quantidade")]
        public int QuantidadeCesta { get; set; }

        /*Cliente*/
        [Display( Name = "Cliente")]
        public string NomeCliente { get; set; }
        [Display( Name = "E-mail")]
        public string EmailCliente { get; set; }
        [Display( Name = "Telefone")]
        public string TelefoneCliente { get; set; }

    }
}
