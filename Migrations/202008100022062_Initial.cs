namespace PlantAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plants",
                c => new
                    {
                        PlantId = c.Int(nullable: false, identity: true),
                        PlantName = c.String(),
                        DateLastWatered = c.DateTime(),
                        WateringStatus = c.String(),
                    })
                .PrimaryKey(t => t.PlantId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plants");
        }
    }
}
