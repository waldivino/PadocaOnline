namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste2_migrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false),
                        email = c.String(nullable: false),
                        endereco = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Fornada",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descricao = c.String(nullable: false),
                        dataHora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false),
                        senha = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Cliente");
            DropTable("dbo.Fornada");
            DropTable("dbo.Usuario");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false),
                        senha = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Fornada",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descricao = c.String(nullable: false),
                        dataHora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false),
                        email = c.String(nullable: false),
                        endereco = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Usuario");
            DropTable("dbo.Fornada");
            DropTable("dbo.Cliente");
        }
    }
}
