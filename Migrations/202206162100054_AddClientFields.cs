namespace GestiuneBileteAvion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Prenume", c => c.String());
            AddColumn("dbo.Clients", "Adresa", c => c.String());
            AddColumn("dbo.Clients", "Cnp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Cnp");
            DropColumn("dbo.Clients", "Adresa");
            DropColumn("dbo.Clients", "Prenume");
        }
    }
}
