namespace trabFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class textoSessao2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sessoes", "textoSessao", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sessoes", "textoSessao", c => c.String());
        }
    }
}
