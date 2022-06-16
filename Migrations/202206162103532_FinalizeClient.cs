namespace GestiuneBileteAvion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalizeClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "TipClient", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "TipClient");
        }
    }
}
