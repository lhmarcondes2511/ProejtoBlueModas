using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Models {
    public class Cliente {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Nome obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O nome precisa ter mais de 3 caracteres")]
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "E-mail obrigatório")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone Obrigatório")]
        public string Telefone { get; set; }

        public Cliente() { }

        public Cliente(int id, string nome, string email, string telefone) {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
