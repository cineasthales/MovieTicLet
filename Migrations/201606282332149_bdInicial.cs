namespace trabFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bdInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrecoUnitario = c.Double(nullable: false),
                        PrecoTotal = c.Double(nullable: false),
                        Qnt = c.Int(nullable: false),
                        Lugares = c.String(),
                        Sessoes_Id = c.Int(),
                        Usuarios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sessoes", t => t.Sessoes_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .Index(t => t.Sessoes_Id)
                .Index(t => t.Usuarios_Id);
            
            CreateTable(
                "dbo.Sessoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Horario = c.String(maxLength: 5),
                        Data = c.String(maxLength: 10),
                        Legendado = c.Boolean(nullable: false),
                        TresD = c.Boolean(nullable: false),
                        Ocupados = c.String(maxLength: 300),
                        QntOcupados = c.Int(nullable: false),
                        Filmes_Id = c.Int(),
                        Salas_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Filmes", t => t.Filmes_Id)
                .ForeignKey("dbo.Salas", t => t.Salas_Id)
                .Index(t => t.Filmes_Id)
                .Index(t => t.Salas_Id);
            
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TituloOriginal = c.String(maxLength: 100),
                        TituloNacional = c.String(maxLength: 100),
                        Duracao = c.Int(nullable: false),
                        Classificacao = c.Int(nullable: false),
                        Sinopse = c.String(maxLength: 200),
                        Genero = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 30),
                        Capacidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 30),
                        Senha = c.String(maxLength: 30),
                        Nivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Compras", "Sessoes_Id", "dbo.Sessoes");
            DropForeignKey("dbo.Sessoes", "Salas_Id", "dbo.Salas");
            DropForeignKey("dbo.Sessoes", "Filmes_Id", "dbo.Filmes");
            DropIndex("dbo.Sessoes", new[] { "Salas_Id" });
            DropIndex("dbo.Sessoes", new[] { "Filmes_Id" });
            DropIndex("dbo.Compras", new[] { "Usuarios_Id" });
            DropIndex("dbo.Compras", new[] { "Sessoes_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Salas");
            DropTable("dbo.Filmes");
            DropTable("dbo.Sessoes");
            DropTable("dbo.Compras");
        }
    }
}
