namespace trabFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reinclusaoOcupados : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Compras", "Salas_Id", "dbo.Salas");
            DropIndex("dbo.Compras", new[] { "Salas_Id" });
            AddColumn("dbo.Sessoes", "QntOcupados", c => c.Int(nullable: false));
            DropColumn("dbo.Compras", "Salas_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Compras", "Salas_Id", c => c.Int());
            DropColumn("dbo.Sessoes", "QntOcupados");
            CreateIndex("dbo.Compras", "Salas_Id");
            AddForeignKey("dbo.Compras", "Salas_Id", "dbo.Salas", "Id");
        }
    }
}
