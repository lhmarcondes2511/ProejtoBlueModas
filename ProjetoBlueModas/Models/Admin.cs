using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjetoBlueModas.Models {
    public class Admin {
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

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Senha obrigatório")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "A senha precisa ter mais de 3 caracteres")]
        public string Senha { get; set; }
    }
}
