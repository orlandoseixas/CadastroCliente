using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CadastroCliente.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [RegularExpression(@"^[\w\sÀ-ü,.'-\/;]+$")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(200)]
        [RegularExpression(@"^[\w\sÀ-ü,.'-\/;]+$")]
        public string SobreNome { get; set; }

        [Required]
        [MaxLength(500)]
        [RegularExpression(@"^[\w\sÀ-ü,.'-\/;]+$")]  
        public string Endereco { get; set; }
    }
}