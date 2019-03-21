using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroCliente.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string Endereco { get; set; }
    }
}