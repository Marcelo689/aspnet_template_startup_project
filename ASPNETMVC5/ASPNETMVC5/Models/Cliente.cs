using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETMVC5.Models
{
    public class Cliente 
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = "Digite no máximo 150 caracteres!")]
        [MinLength(2, ErrorMessage = "Digite 2 caracteres ou mais!")]
        [DisplayName("Nome do cliente")]
        [Required( ErrorMessage = "O campo deve ser preenchido!")]
        public string Nome { get; set; }

        [MaxLength(150, ErrorMessage = "Digite no máximo 150 caracteres!")]
        [MinLength(2, ErrorMessage = "Digite 2 caracteres ou mais!")]
        [DisplayName("Sobrenome do cliente")]
        [Required(ErrorMessage = "O campo deve ser preenchido!")]
        public string Sobrenome { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool QuerCertificado { get; set; }

        [MaxLength(150, ErrorMessage = "Digite no máximo 150 caracteres!")]
        [MinLength(2, ErrorMessage = "Digite 2 caracteres ou mais!")]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O campo deve ser preenchido!")]
        [EmailAddress(ErrorMessage = "Formato de email inválido!")]
        public string Email { get; set; }
    }
}