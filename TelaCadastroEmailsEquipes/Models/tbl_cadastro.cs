using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelaCadastroEmailsEquipes.Models
{
    public class tbl_cadastro
    {
        [Key]
        public int codigo { get; set; }

        public bool ativo { get; set; }

        [StringLength(250)]
        public string equipe { get; set; }

        [StringLength(250)]
        public string email { get; set; }
    }
}