namespace CadastroCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validacoes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String( maxLength: 200));
            AlterColumn("dbo.Pessoas", "SobreNome", c => c.String(maxLength: 200));
            AlterColumn("dbo.Pessoas", "Endereco", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "Endereco", c => c.String());
            AlterColumn("dbo.Pessoas", "SobreNome", c => c.String());
            AlterColumn("dbo.Pessoas", "Nome", c => c.String());
        }
    }
}
