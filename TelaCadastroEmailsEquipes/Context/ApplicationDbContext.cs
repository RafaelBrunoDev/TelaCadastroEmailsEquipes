using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TelaCadastroEmailsEquipes.Models;

namespace TelaCadastroEmailsEquipes.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<tbl_cadastro> Cadastros { get; set; }
        public DbSet<tbl_email_atendimento> EmailAtendimentos { get; set; }

    }

}