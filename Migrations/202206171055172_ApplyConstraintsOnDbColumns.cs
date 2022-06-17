namespace GestiuneBileteAvion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyConstraintsOnDbColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Nume", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clients", "Prenume", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clients", "Cnp", c => c.String(nullable: false, maxLength: 13));
            AlterColumn("dbo.Clients", "TipClient", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "TipClient", c => c.String());
            AlterColumn("dbo.Clients", "Cnp", c => c.String());
            AlterColumn("dbo.Clients", "Prenume", c => c.String());
            AlterColumn("dbo.Clients", "Nume", c => c.String());
        }
    }
}
