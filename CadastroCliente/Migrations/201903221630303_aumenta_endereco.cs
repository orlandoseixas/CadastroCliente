namespace CadastroCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aumenta_endereco : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Endereco", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "Endereco", c => c.String(maxLength: 200));
        }
    }
}
