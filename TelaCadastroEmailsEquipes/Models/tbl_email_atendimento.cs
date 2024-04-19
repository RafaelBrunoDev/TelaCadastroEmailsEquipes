using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelaCadastroEmailsEquipes.Models
{
    public class tbl_email_atendimento
    {
        [Key]
        public int codigo { get; set; }

        [StringLength(250)]
        public string email_atendimento { get; set; }
    }
}