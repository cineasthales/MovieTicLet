namespace trabFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class textoSessao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sessoes", "textoSessao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sessoes", "textoSessao");
        }
    }
}
