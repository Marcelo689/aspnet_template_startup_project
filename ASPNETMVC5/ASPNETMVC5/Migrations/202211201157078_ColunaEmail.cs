namespace ASPNETMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColunaEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Email", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Clientes", "Nome", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Clientes", "Sobrenome", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Sobrenome", c => c.String());
            AlterColumn("dbo.Clientes", "Nome", c => c.String());
            DropColumn("dbo.Clientes", "Email");
        }
    }
}
