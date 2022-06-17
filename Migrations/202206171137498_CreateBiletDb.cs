namespace GestiuneBileteAvion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBiletDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bilets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoculPlecarii = c.String(nullable: false, maxLength: 50),
                        LoculSosirii = c.String(nullable: false, maxLength: 50),
                        DataPlecarii = c.DateTime(nullable: false),
                        Pret = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bilets");
        }
    }
}
