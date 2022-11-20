namespace ASPNETMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionadopropriedadecertificado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "QuerCertificado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "QuerCertificado");
        }
    }
}
