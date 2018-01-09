namespace trabFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exclusaoOcupados : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Compras", "Salas_Id", c => c.Int());
            CreateIndex("dbo.Compras", "Salas_Id");
            AddForeignKey("dbo.Compras", "Salas_Id", "dbo.Salas", "Id");
            DropColumn("dbo.Compras", "Lugares");
            DropColumn("dbo.Sessoes", "Ocupados");
            DropColumn("dbo.Sessoes", "QntOcupados");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sessoes", "QntOcupados", c => c.Int(nullable: false));
            AddColumn("dbo.Sessoes", "Ocupados", c => c.String(maxLength: 300));
            AddColumn("dbo.Compras", "Lugares", c => c.String());
            DropForeignKey("dbo.Compras", "Salas_Id", "dbo.Salas");
            DropIndex("dbo.Compras", new[] { "Salas_Id" });
            DropColumn("dbo.Compras", "Salas_Id");
        }
    }
}
