namespace TelaCadastroEmailsEquipes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migraton : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_cadastro_email_equipe",
                c => new
                    {
                        codigo = c.Int(nullable: false, identity: true),
                        ativo = c.Boolean(),
                        equipe = c.String(maxLength: 250),
                        email = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_cadastro_email_equipe");
        }
    }
}
